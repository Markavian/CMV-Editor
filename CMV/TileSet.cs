using System;
using System.Collections.Generic;
using System.Text;

using System.Drawing;
using System.IO;

namespace CMVData
{
    public class TileSet
    {
        const uint NUM_COLS = 16;
        const uint NUM_ROWS = 16;

        uint tileWidth;
        uint tileHeight;

        List<Bitmap> tiles;

        public TileSet()
        {
            tiles = new List<Bitmap>();
            updateTileSize();
        }

        public TileSet(Bitmap tilesetImage)
        {
            tiles = splitTileset(tilesetImage);
            updateTileSize();
        }

        public TileSet(String filename)
        {
            Bitmap image;
            try
            {
                image = new Bitmap(filename);
            }
            catch (Exception)
            {
                throw new FileNotFoundException("Could not load Bitmap file as TileSet, file not found.", filename);
            }
            tiles = splitTileset(image);
            image.Dispose();

            updateTileSize();
        }

        private void updateTileSize()
        {
            if (tiles.Count > 0)
            {
                tileWidth  = (uint)tiles[0].Width;
                tileHeight = (uint)tiles[0].Height;
            }
            else
            {
                tileWidth = 0;
                tileHeight = 0;
            }
        }

        public static List<Bitmap> splitTileset(Bitmap tilesetImage)
        {
            List<Bitmap> tiles;

            Bitmap tileset;
            Bitmap tile;
            Graphics graphics;

            int tileWidth;
            int tileHeight;

            Rectangle source;
            Rectangle destination;

            tileset = tilesetImage;
            tiles = new List<Bitmap>();

            tileWidth  = (int)(tileset.Width / NUM_COLS);
            tileHeight = (int)(tileset.Height / NUM_ROWS);

            source = new Rectangle(0, 0, tileWidth, tileHeight);
            destination = new Rectangle(0, 0, tileWidth, tileHeight);

            for (uint i = 0; i < NUM_ROWS; i++)
            {
                for (uint j = 0; j < NUM_COLS; j++)
                {
                    tile = new Bitmap(tileWidth, tileHeight);

                    source.X = (int)(j * tileWidth);
                    source.Y = (int)(i * tileHeight);

                    graphics = Graphics.FromImage(tile);
                    graphics.DrawImage(tileset, destination, source, GraphicsUnit.Pixel);

                    tiles.Add(tile);
                }
            }

            return tiles;
        }

        /* Properties */
        public List<Bitmap> Tiles
        {
            get { return tiles; }
        }

        public int NumberOfTiles
        {
            get { return tiles.Count; }
        }

        public uint TileWidth
        {
            get { return tileWidth; }
        }

        public uint TileHeight
        {
            get { return tileHeight; }
        }
    }
}
