using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using System.Drawing.Imaging;

using CMVData;

namespace CMVEditorComponents
{
    public partial class CMVPlayer : UserControl
    {
        Rectangle drawArea;

        Timer playTimer;
        TileSet tileset;
        CMV cmv;
        int frameIndex;
        bool forceRedraw;

        uint tileWidth;
        uint tileHeight;

        Bitmap drawTile;
        Color magenta;
        ImageAttributes attributes;
        Rectangle destination;
        Rectangle source;

        Dictionary<short, Bitmap> renderedTiles;

        [Category("CMV Player")]
        public event EventHandler FrameChanged, PlayStarted, Paused, TileSetChanged, CMVChanged, PlayRateChanged;

        public CMVPlayer()
        {
            InitializeComponent();

            // Paint values
            drawArea = new Rectangle(0, 0, Width, Height);

            // Draw stage constants
            magenta = Color.FromArgb(255, 255, 0, 255);

            attributes = new ImageAttributes();

            playTimer = new Timer();
            playTimer.Interval = 1000 / 25;
            playTimer.Tick += new EventHandler(timerTick);

            DoubleBuffered = true;

            Reset();

            cmv = new CMV();
            tileset = new TileSet();

            renderedTiles = new Dictionary<short, Bitmap>();
            forceRedraw = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics surface;

            surface = e.Graphics;
            surface.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;

            checkFrameIndex();
            drawFrame(surface);

            base.OnPaint(e);
        }

        unsafe private void drawFrame(Graphics g)
        {
            CMVFrame frame;
            uint rows, cols, framesize;
            Color[] colors;

            if (cmv.FrameCount == 0)
                return;
            if (tileset.NumberOfTiles == 0)
                return;

            frame = cmv[frameIndex];
            rows = cmv.Rows;
            cols = cmv.Columns;
            framesize = (uint)(frame.Frame.Length / 2);
            colors = CMVColours.Colors;

            if (forceRedraw == false && frameIndex > 0)
                if (cmv[frameIndex - 1] == frame)
                    return;

            // Draw current frame
            int index;
            byte cbyte;
            int intensity, b, f;
            Color fg, bg;
            SolidBrush brush = new SolidBrush(Color.Black);

            drawTile = new Bitmap((int)tileWidth, (int)tileHeight);

            g.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;

            int x, y, offset;
            int i, j;
            short cacheKey;

            Bitmap sourceTile;
            byte* srcrow, tarrow;
            BitmapData srcbmd, tarbmd;
            Color c;

            for (x = 0; x < cols; x++)
            {
                for (y = 0; y < rows; y++)
                {
                    offset = (int)((x * rows) + (y));
                    index = frame.Frame[offset];
                    cbyte = frame.Frame[offset + framesize];

                    cacheKey = (short)((index << 4) + cbyte);

                    if (renderedTiles.ContainsKey(cacheKey) == false)
                    {
                        // cbyte format: 0ibbbfff
                        b = (cbyte & 0x38) >> 3;
                        f = (cbyte & 0x07);
                        intensity = (cbyte & 0x40) >> 6;

                        bg = colors[b];
                        fg = colors[f + (8 * intensity)];

                        sourceTile = tileset.Tiles[index];

                        srcbmd = sourceTile.LockBits(source, ImageLockMode.ReadOnly, sourceTile.PixelFormat);
                        tarbmd = drawTile.LockBits(source, ImageLockMode.WriteOnly, drawTile.PixelFormat);
                        int PixelSize = 4;

                        for (i = 0; i < tileHeight; i++)
                        {
                            srcrow = (byte*)srcbmd.Scan0 + (i * srcbmd.Stride);
                            tarrow = (byte*)tarbmd.Scan0 + (i * tarbmd.Stride);

                            for (j = 0; j < tileWidth; j++)
                            {
                                c = Color.FromArgb(
                                    srcrow[(j * PixelSize) + 3], // A
                                    srcrow[(j * PixelSize) + 2], // R
                                    srcrow[(j * PixelSize) + 1], // G
                                    srcrow[(j * PixelSize) + 0]  // B
                                );

                                if (c == magenta)
                                {
                                    tarrow[(j * PixelSize) + 3] = bg.A;
                                    tarrow[(j * PixelSize) + 2] = bg.R;
                                    tarrow[(j * PixelSize) + 1] = bg.G;
                                    tarrow[(j * PixelSize) + 0] = bg.B;
                                }
                                else
                                {
                                    c = Color.FromArgb((int)(c.GetBrightness() * 255), fg);

                                    tarrow[(j * PixelSize) + 3] = c.A;
                                    tarrow[(j * PixelSize) + 2] = c.R;
                                    tarrow[(j * PixelSize) + 1] = c.G;
                                    tarrow[(j * PixelSize) + 0] = c.B;
                                }
                            }
                        }

                        sourceTile.UnlockBits(srcbmd);
                        drawTile.UnlockBits(tarbmd);

                        renderedTiles.Add(cacheKey, (Bitmap)(drawTile.Clone()));
                    }

                    destination.X = (int)(x * tileWidth);
                    destination.Y = (int)(y * tileHeight);

                    g.DrawImage(renderedTiles[cacheKey], destination, 0, 0, tileWidth, tileHeight, GraphicsUnit.Pixel, attributes);
                }
            }

            forceRedraw = false;
        }

        private void updateDrawArea()
        {
            // Update draw / redraw area
            tileWidth  = tileset.TileWidth;
            tileHeight = tileset.TileHeight;

            drawArea.X = 0; drawArea.Y = 0;
            drawArea.Width  = (int)(tileWidth * cmv.Columns);
            drawArea.Height = (int)(tileHeight * cmv.Rows);

            Width  = drawArea.Width;
            Height = drawArea.Height;

            destination = new Rectangle(0, 0, (int)tileWidth, (int)tileHeight);
            source = new Rectangle(0, 0, (int)tileWidth, (int)tileHeight);

            Width = drawArea.Width;
            Height = drawArea.Height;
        }

        private void checkFrameIndex()
        {
            if (frameIndex < 0)
            {
                frameIndex = 0;
                Pause();
            }
            else if (frameIndex >= cmv.FrameCount)
            {
                frameIndex = (int)(cmv.FrameCount - 1);
                Pause();
            }
        }

        void timerTick(object sender, EventArgs e)
        {
            frameIndex++;
            Invalidate(drawArea);

            if(FrameChanged != null)
                FrameChanged(this, new EventArgs());
        }

        /* Public methods */
        public void Play()
        {
            Invalidate();
            playTimer.Start();

            if(PlayStarted != null)
                PlayStarted(this, new EventArgs());
        }

        public void Pause()
        {
            playTimer.Stop();

            if(Paused != null)
                Paused(this, new EventArgs());
        }

        public void Reset()
        {
            Pause();

            frameIndex = 0;
            Invalidate();
        }

        public void NextFrame()
        {
            Pause();

            frameIndex++;
            checkFrameIndex();
            Invalidate();

            if(FrameChanged != null)
                FrameChanged(this, new EventArgs());
        }

        public void PreviousFrame()
        {
            Pause();

            frameIndex--;
            checkFrameIndex();
            Invalidate();

            if (FrameChanged != null)
                FrameChanged(this, new EventArgs());
        }

        public void ForceRedraw()
        {
            forceRedraw = true;
            Invalidate();
        }

        /* Public properties */
        [Category("CMV Player")]
        public TileSet TileSet
        {
            get { return tileset; }
            set {
                tileset = value; 

                renderedTiles = new Dictionary<short, Bitmap>();
                forceRedraw = true;

                updateDrawArea(); Invalidate();

                if(TileSetChanged != null)
                    TileSetChanged(this, new EventArgs());
            }
        }

        public CMV CMV
        {
            get { return cmv; }
            set {
                cmv = value; updateDrawArea(); Reset();

                renderedTiles.Clear();

                if (CMVChanged != null)
                    CMVChanged(this, new EventArgs());
            }
        }

        public int Frame
        {
            get { return frameIndex; }
            set {
                frameIndex = value;
                forceRedraw = true;
                Invalidate();

                if (FrameChanged != null)
                    FrameChanged(this, new EventArgs());
            }
        }

        public int PlayRate
        {
            get { return playTimer.Interval; }
            set {
                playTimer.Interval = 1000 / value;
                
                if(PlayRateChanged != null)
                    PlayRateChanged(this, new EventArgs());
            }
        }

        public Rectangle DrawArea
        {
            get { return drawArea; }
        }

        public bool isPaused
        {
            get { return !playTimer.Enabled; }
        }

        public bool isPlaying
        {
            get { return playTimer.Enabled; }
        }

        /* Protected events */
        protected virtual void OnFrameChanged(object sender, EventArgs e)
        {
            FrameChanged(sender, e);
        }

        protected virtual void OnPlayStarted(object sender, EventArgs e)
        {
            PlayStarted(sender, e);
        }

        protected virtual void OnPaused(object sender, EventArgs e)
        {
            Paused(sender, e);
        }

        protected virtual void OnTileSetChanged(object sender, EventArgs e)
        {
            TileSetChanged(sender, e);
        }

        protected virtual void OnCMVChanged(object sender, EventArgs e)
        {
            CMVChanged(sender, e);
        }

        protected virtual void OnPlayRateChanged(object sender, EventArgs e)
        {
            PlayRateChanged(sender, e);
        }
    }
}
