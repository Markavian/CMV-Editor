using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using CMVData;

namespace CMVEditorComponents
{
    public partial class TileSelectorGrid : UserControl
    {
        TileSet tileset;

        Color borderColor;
        Color dividerColor;
        Color highlightColor;

        int cols, rows;
        Rectangle box;
        Point p1;
        int cursorIndex;

        Pen penWorker;
        SolidBrush brushWorker;

        public delegate void IndexHandler(object sender, int index);
        [Category("TileSelector")]
        public event IndexHandler TileIndexSelected;

        public TileSelectorGrid()
        {
            InitializeComponent();

            borderColor = Color.Black;
            dividerColor = Color.Black;
            highlightColor = Color.Blue;

            cols = 0;
            rows = 0;
            box = new Rectangle(0, 0, 10, 10);
            p1 = new Point(0, 0);

            cursorIndex = -1;

            brushWorker = new SolidBrush(dividerColor);
            penWorker = new Pen(brushWorker, 1.0f);

            DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphic;
            Bitmap tile;

            base.OnPaint(e);
            graphic = e.Graphics;

            if (tileset == null)
                return;

            cols = (int)Math.Sqrt(tileset.NumberOfTiles);
            rows = (int)(tileset.NumberOfTiles / cols);

            Width = (int)(cols * tileset.TileWidth) + 2;
            Height = (int)(rows * tileset.TileHeight) + 2;

            for(int i=0; i<tileset.NumberOfTiles; i++)
            {
                box.Width = (int)tileset.TileWidth;
                box.Height = (int)tileset.TileHeight;

                tile = tileset.Tiles[i];

                p1.X = i % cols * box.Width + 1;
                p1.Y = (int)Math.Floor((double)(i / rows)) * box.Height + 1;

                box.Location = p1;

                // Draw tile image
                tile.MakeTransparent(Color.Magenta);
                graphic.DrawImageUnscaled(tile, p1);

                if (i == cursorIndex)
                {
                    // Draw hover state fade
                    brushWorker.Color = Color.FromArgb(150, highlightColor);
                    graphic.FillRectangle(brushWorker, box);
                }

                // Draw border around the image
                box.Width++;
                box.Height++;
                brushWorker.Color = Color.FromArgb(50, dividerColor);
                penWorker.Brush = brushWorker;
                graphic.DrawRectangle(penWorker, box);
            }

            // Draw border around control
            box.X = box.Y = 0;
            box.Width = Width - 1;
            box.Height = Height - 1;

            brushWorker.Color = borderColor;
            penWorker.Brush = brushWorker;
            graphic.DrawRectangle(penWorker, box);
        }

        private int getTileIndexUnderMouse(MouseEventArgs mouse)
        {
            int col = (int)Math.Round((double)(mouse.X / tileset.TileWidth));
            int row = (int)Math.Round((double)(mouse.Y / tileset.TileHeight));

            return (row * cols) + col;
        }

        /* Public properties */
        public TileSet TileSet
        {
            get { return tileset; }
            set { tileset = value; Invalidate(); }
        }

        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; Invalidate(); }
        }

        public Color DividerColor
        {
            get { return dividerColor; }
            set { dividerColor = value; Invalidate(); }
        }

        public Color HighlightColor
        {
            get { return highlightColor; }
            set { highlightColor = value; Invalidate(); }
        }

        /* Event handlers */
        private void handleMouseMove(object sender, MouseEventArgs e)
        {
            cursorIndex = getTileIndexUnderMouse(e);
            Invalidate();
        }

        private void handleMouseLeave(object sender, EventArgs e)
        {
            cursorIndex = -1;
            Invalidate();
        }

        private void handleMouseUp(object sender, MouseEventArgs e)
        {
            cursorIndex = getTileIndexUnderMouse(e);

            if (TileIndexSelected != null)
                TileIndexSelected(this, cursorIndex);

            Invalidate();
        }

        private void handleMouseDown(object sender, MouseEventArgs e)
        {
            cursorIndex = getTileIndexUnderMouse(e);
            Invalidate();
        }

        /* Protected Events */
        protected void OnTileIndexSelected(object sender, int index)
        {
            TileIndexSelected(sender, index);
        }
    }
}
