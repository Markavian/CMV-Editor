using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace CMVEditorComponents
{
    public partial class PlainButton : Button
    {
        Color borderFocusColor;
        int borderFocusSize;

        SolidBrush brushWorker;
        Pen penWorker;
        Rectangle box;

        bool mouseDrag;
        bool mouseOver;

        public PlainButton()
        {
            InitializeComponent();

            // Create drawing objects
            brushWorker = new SolidBrush(Color.Red);
            penWorker = new Pen(brushWorker);

            box = new Rectangle(0, 0, Width, Height);

            FlatAppearance.BorderSize = 1;
            FlatAppearance.BorderColor = Color.Black;
            borderFocusColor = Color.White;
            borderFocusSize = 1;

            mouseDrag = false;
            mouseOver = false;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics;

            //base.OnPaint(e);

            graphics = e.Graphics;

            box.X = box.Y = 0;
            box.Width = Width;
            box.Height = Height;

            brushWorker.Color = BackColor;
            graphics.FillRectangle(brushWorker, box);

            if (mouseDrag)
            {
                brushWorker.Color = FlatAppearance.MouseDownBackColor;
                graphics.FillRectangle(brushWorker, box);
            }
            else if (mouseOver)
            {
                brushWorker.Color = FlatAppearance.MouseOverBackColor;
                graphics.FillRectangle(brushWorker, box);
            }

            if (BackgroundImage != null)
            {
                box.X = (Width - BackgroundImage.Width) / 2;
                box.Y = (Height - BackgroundImage.Height) / 2;
                box.Width = BackgroundImage.Width;
                box.Height = BackgroundImage.Height;

                graphics.DrawImageUnscaledAndClipped(BackgroundImage, box);
            }

            brushWorker.Color = FlatAppearance.BorderColor;
            penWorker.Brush = brushWorker;
            penWorker.Width = FlatAppearance.BorderSize;

            // Draw border
            box.X = box.Y = (FlatAppearance.BorderSize / 2);
            box.Width = Width - FlatAppearance.BorderSize;
            box.Height = Height - FlatAppearance.BorderSize;

            if(FlatAppearance.BorderSize > 0)
                graphics.DrawRectangle(penWorker, box);

            // Draw focused border
            if (Focused && borderFocusSize > 0)
            {
                brushWorker.Color = borderFocusColor;
                penWorker.Brush = brushWorker;
                penWorker.Width = borderFocusSize;

                box.X = box.Y = FlatAppearance.BorderSize + (borderFocusSize / 2);
                box.Width = Width - (FlatAppearance.BorderSize * 2) - (borderFocusSize);
                box.Height = Height - (FlatAppearance.BorderSize * 2) - (borderFocusSize);

                graphics.DrawRectangle(penWorker, box);
            }
        }

        /* Public properties */
        [Category("Appearance")]
        public Color BorderFocusColor
        {
            get { return borderFocusColor; }
            set { borderFocusColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        public int BorderFocusSize
        {
            get { return borderFocusSize; }
            set { borderFocusSize = value; Invalidate(); }
        }

        /* Mouse event handlers */
        private void handleClick(object sender, EventArgs e)
        {
            Focus();
            Invalidate();
        }

        private void handleFocus(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void handleMouseLeave(object sender, EventArgs e)
        {
            mouseOver = false;
            Invalidate();
        }

        private void handleMouseEnter(object sender, EventArgs e)
        {
            mouseOver = true;
            Invalidate();
        }

        private void handleMouseDown(object sender, MouseEventArgs e)
        {
            mouseDrag = true;
            Invalidate();
        }

        private void handleMouseUp(object sender, MouseEventArgs e)
        {
            mouseDrag = false;
            Invalidate();
        }
    }
}
