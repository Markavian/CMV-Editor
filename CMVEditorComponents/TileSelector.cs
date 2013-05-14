using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Data;
using System.Text;
using System.Windows.Forms;

using CMVData;

namespace CMVEditorComponents
{
    public partial class TileSelector : UserControl
    {
        TileSet tileset;
        Color foregroundColor;

        Form tileSelectorDialog;
        TileSelectorGrid tileSelectorGrid;

        //public delegate void IndexEvent(int tileIndex);
        //public event IndexEvent TileSelected;

        public TileSelector()
        {
            InitializeComponent();

            tileset = new TileSet();

            foregroundColor = Color.White;

            createTileSelectorDialog();
        }

        unsafe private void updateTileBox()
        {
            Bitmap scaledTile;
            Bitmap sourceTile;
            Graphics graphic;
            ImageAttributes attributes;

            Rectangle source;
            Rectangle destination;

            int ZOOM = 4;
            int numTiles = tileset.NumberOfTiles;

            if (numTiles > 0)
            {
                numericUpDown.Maximum = numTiles - 1;

                sourceTile = new Bitmap(tileset.Tiles[(int)numericUpDown.Value]);
                scaledTile = new Bitmap(sourceTile.Width * ZOOM, sourceTile.Height * ZOOM);

                destination = new Rectangle(0, 0, scaledTile.Width, scaledTile.Height);
                source = new Rectangle(0, 0, sourceTile.Width, sourceTile.Height);

                attributes = new ImageAttributes();
                //attributes.SetColorKey(Color.Magenta, Color.Magenta);

                graphic = Graphics.FromImage(scaledTile);
                graphic.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;

                Color c;
                Color a = Color.FromArgb(0, 0, 0, 255);
                Color magenta = Color.FromArgb(255, 255, 0, 255);
                BitmapData bmd = sourceTile.LockBits(source, ImageLockMode.ReadWrite, sourceTile.PixelFormat);
                int PixelSize = 4;

                for (int y = 0; y < bmd.Height; y++)
                {
                    byte* row = (byte*)bmd.Scan0 + (y * bmd.Stride);

                    for (int x = 0; x < bmd.Width; x++)
                    {
                        c = Color.FromArgb(
                            row[(x * PixelSize)+3], // A
                            row[(x * PixelSize)+2], // R
                            row[(x * PixelSize)+1], // G
                            row[(x * PixelSize)+0]  // B
                        );
                        if (c == magenta)
                        {
                            row[(x * PixelSize)+3] = a.A;
                            row[(x * PixelSize)+2] = a.R;
                            row[(x * PixelSize)+1] = a.G;
                            row[(x * PixelSize)+0] = a.B;
                        }
                        else
                        {
                            c = Color.FromArgb((int)(c.GetBrightness()*255), foregroundColor);
                            
                            row[(x * PixelSize)+3] = c.A;
                            row[(x * PixelSize)+2] = c.R;
                            row[(x * PixelSize)+1] = c.G;
                            row[(x * PixelSize)+0] = c.B;
                        }
                    }
                }

                sourceTile.UnlockBits(bmd);

                graphic.DrawImage(sourceTile, destination, source.X, source.Y, source.Width, source.Height, GraphicsUnit.Pixel, attributes);

                tileBox.Image = scaledTile;
            }
            else
            {
                numericUpDown.Maximum = 0;
            }

        }

        private void numericIndexChanged(object sender, EventArgs e)
        {
            updateTileBox();

            //TileSelected(SelectedTile);
        }

        private void createTileSelectorDialog()
        {
            Form form;
            TileSelectorGrid grid;

            tileSelectorDialog = new Form();
            tileSelectorGrid = new TileSelectorGrid();

            tileSelectorGrid.TileIndexSelected += new TileSelectorGrid.IndexHandler(handleTileIndexSelected);

            form = tileSelectorDialog;
            grid = tileSelectorGrid;

            form.Owner = ParentForm;
            grid.Parent = form;

            grid.Top = 2;
            grid.Left = 2;

            grid.Margin = new Padding(2);

            form.FormBorderStyle = FormBorderStyle.None;
            form.AutoSize = true;

            form.Width = grid.Width;
            form.Height = grid.Height;

            form.Margin = new Padding(0);

            form.Name = "Tile Selector";
            form.ShowInTaskbar = false;
        }

        private void showTileSelectorGrid()
        {
            Form form;
            TileSelectorGrid grid;
            Point p0, p1, p2, p3;

            form = tileSelectorDialog;
            grid = tileSelectorGrid;
            p0 = new Point(0, 0);

            form.Hide();
            form.Show(ParentForm);
            grid.Show();

            p1 = ParentForm.PointToScreen(p0);
            p2 = PointToScreen(p0);
            p3 = form.Location;

            p3.X = Math.Abs(p1.X - p2.X) + ParentForm.Location.X;
            p3.Y = Math.Abs(p1.Y - p2.Y) + ParentForm.Location.Y;

            form.Location = p3;
        }

        /* Public properties */
        public TileSet TileSet
        {
            get { return tileset; }
            set { tileset = value; updateTileBox(); tileSelectorGrid.TileSet = tileset; }
        }

        public int SelectedTile
        {
            get { return (int)numericUpDown.Value; }
            set { numericUpDown.Value = value; }
        }

        public Color BackgroundColor
        {
            get { return tileBox.BackColor; }
            set { tileBox.BackColor = value; updateTileBox(); }
        }

        public Color ForegroundColor
        {
            get { return foregroundColor; }
            set { foregroundColor = value; updateTileBox(); }
        }

        public byte TileIndex
        {
            get { return (byte)SelectedTile; }
        }

        public byte TileColor
        {
            get { return CMVColours.GenerateColorCode(ForegroundColor, BackgroundColor); }
        }

        /* Event handlers*/
        private void handleTileBoxClick(object sender, EventArgs e)
        {
            showTileSelectorGrid();
        }

        private void handleTileIndexSelected(object sender, int index)
        {
            SelectedTile = index;
            tileSelectorDialog.Hide();
        }
    }
}
