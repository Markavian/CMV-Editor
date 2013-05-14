using System;
using System.Collections.Generic;
using System.Text;

using System.Drawing;

namespace CMVData
{
    public class CMVColours
    {
        // Index array of colours
        public static Color[] Colors
        {
            get
            {
                var colors = new Color[16];

                colors[0]  = BLACK;
                colors[1]  = BLUE;
                colors[2]  = GREEN;
                colors[3]  = CYAN;
                colors[4]  = RED;
                colors[5]  = MAGENTA;
                colors[6]  = BROWN;
                colors[7]  = LGRAY;
                colors[8]  = DGRAY;
                colors[9]  = LBLUE;
                colors[10] = LGREEN;
                colors[11] = LCYAN;
                colors[12] = LRED;
                colors[13] = LMAGENTA;
                colors[14] = YELLOW;
                colors[15] = WHITE;

                return colors;
            }
        }

        public static Color[] BackgroundColors
        {
            get
            {
                var colors = new Color[8];

                colors[0] = BLACK;
                colors[1] = BLUE;
                colors[2] = GREEN;
                colors[3] = CYAN;
                colors[4] = RED;
                colors[5] = MAGENTA;
                colors[6] = BROWN;
                colors[7] = LGRAY;

                return colors;
            }
        }

        public static Color[] ForegroundColors
        {
            get { return CMVColours.Colors; }
        }

        /* Static methods */
        public static byte GenerateColorCode(byte backgroundColor, byte foregroundColor, byte foregroundIntensity)
        {
            int cbyte;

            // cbyte format: 0ibbbfff
            backgroundColor = (byte)(backgroundColor & 0x07); // Mask to 3 bits (range 0-7)
            foregroundColor = (byte)(foregroundColor & 0x07); // Mask to 3 bits (range 0-7)

            cbyte = (foregroundIntensity << 6) + (backgroundColor << 3) + (foregroundColor);

            return (byte)cbyte;
        }

        public static byte GenerateColorCode(Color backgroundColor, Color foregroundColor)
        {
            Color[] colors = Colors;
            byte backgroundByte = 0, foregroundByte = 0, intensityByte = 0;

            for (int i = 0; i < colors.Length; i++)
            {
                if (colors[i].Equals(foregroundColor))
                {
                    if (i > 8)
                    {
                        intensityByte = 1;
                        foregroundByte = (byte)(i - 8);
                    }
                    else
                    {
                        foregroundByte = (byte)i;
                    }
                }

                if (colors[i].Equals(backgroundColor))
                {
                    if (i > 8)
                        backgroundByte = (byte)(i - 8);
                    else
                        backgroundByte = (byte)i;
                }
            }

            return GenerateColorCode(backgroundByte, foregroundByte, intensityByte);
        }

        /* Named colour properties */
        public static Color BLACK {
            get { return Color.FromArgb(0, 0, 0); }
        }

        public static Color BLUE {
            get { return Color.FromArgb(0, 0, 128); }
        }


        public static Color GREEN {
            get { return Color.FromArgb(0, 130, 55); }
        }

        public static Color CYAN {
            get { return Color.FromArgb(0, 128, 128); }
        }

        public static Color RED {
            get { return Color.FromArgb(128, 0, 0); }
        }

        public static Color MAGENTA {
            get { return Color.FromArgb(128, 0, 128); }
        }

        public static Color BROWN {
            get { return Color.FromArgb(161, 112, 41); }
        }

        public static Color LGRAY {
            get { return Color.FromArgb(150, 150, 150); }
        }

        public static Color DGRAY {
            get { return Color.FromArgb(80, 80, 80); }
        }

        public static Color LBLUE {
            get { return Color.FromArgb(50, 100, 255); }
        }

        public static Color LGREEN {
            get { return Color.FromArgb(50, 200, 50); }
        }

        public static Color LCYAN {
            get { return Color.FromArgb(60, 180, 240); }
        }

        public static Color LRED {
            get { return Color.FromArgb(255, 0, 0); }
        }

        public static Color LMAGENTA {
            get { return Color.FromArgb(245, 0, 255); }
        }

        public static Color YELLOW {
            get { return Color.FromArgb(255, 220, 0); }
        }

        public static Color WHITE
        {
            get { return Color.FromArgb(255, 255, 255); }
        }
    }
}
