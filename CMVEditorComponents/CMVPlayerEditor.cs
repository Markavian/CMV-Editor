using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace CMVEditorComponents
{
    public enum ToolMode { NONE, PAINT_TOOL, TEXT_TOOL, SELECTION_TOOL };

	public class CMVPlayerEditor : CMVPlayer
	{
        bool editable;

        Point hoverCell;
        Point pressCell;
        Rectangle selectionArea;

        bool mouseDrag;
        ToolMode toolMode;
        Timer cursorFlashTimer;
        bool cursorVisible;

        [Category("CMV Player Editor")]
        public event EventHandler CellSelected, CellPaintStart, CellPaintMove;

        public CMVPlayerEditor() : base()
        {
            editable = true;

            hoverCell = new Point(-1, -1);
            pressCell = new Point(-1, -1);
            selectionArea = new Rectangle(-1, -1, 0, 0);

            mouseDrag = false;
            toolMode = ToolMode.NONE;
            cursorFlashTimer = new Timer();
            cursorFlashTimer.Interval = 450;
            cursorFlashTimer.Tick += new EventHandler(handleCursorFlash);

            makeBrushes();

            InitializeComponent();
        }

        /* Public properties */
        public bool Editable
        {
            get { return editable; }
            set { editable = value; Invalidate(); }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CMVEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "CMVEditor";
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.handleMouseUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.handleMouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.handleMouseMove);
            this.MouseLeave += new System.EventHandler(this.handleMouseLeave);
            this.ResumeLayout(false);
        }

        private void setPointUnderMouse(ref Point point, MouseEventArgs mouse)
        {
            if (TileSet.TileWidth > 0)
            {
                point.X = (int)Math.Floor((double)(mouse.X / TileSet.TileWidth));
                point.Y = (int)Math.Floor((double)(mouse.Y / TileSet.TileHeight));
            }
            else
            {
                point.X = -1;
                point.Y = -1;
            }
        }

        private void validateSelectionArea()
        {
            // Decide on top left location
            if (pressCell.X < hoverCell.X)
                selectionArea.X = pressCell.X;
            else
                selectionArea.X = hoverCell.X;

            if (pressCell.Y < hoverCell.Y)
                selectionArea.Y = pressCell.Y;
            else
                selectionArea.Y = hoverCell.Y;

            // Set width and height
            selectionArea.Width = Math.Abs(pressCell.X - hoverCell.X) + 1;
            selectionArea.Height = Math.Abs(pressCell.Y - hoverCell.Y) + 1;
        }


        /* Drawing objects */
        SolidBrush brushSelectionEdges;
        SolidBrush brushHoverPosition;
        SolidBrush brushFlashingCursor;

        Pen penWorker;
        Rectangle drawingBox;

        uint tw, th;
 
        private void makeBrushes()
        {
            brushSelectionEdges = new SolidBrush(Color.FromArgb(255, Color.CornflowerBlue));
            brushHoverPosition = new SolidBrush(Color.FromArgb(255, Color.SandyBrown));
            brushFlashingCursor = new SolidBrush(Color.FromArgb(255, Color.White));

            penWorker = new Pen(brushSelectionEdges, 2);
            drawingBox = new Rectangle();
        }

        // Paint me...
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (editable == false)
                return;

            Graphics graphic;

            graphic = e.Graphics;
            tw = TileSet.TileWidth;
            th = TileSet.TileHeight;

            if (toolMode == ToolMode.SELECTION_TOOL)
            {
                // draw selection rectangle
                if (selectionArea.X > -1)
                {
                    drawingBox.X = (int)(selectionArea.X * tw) - 1;
                    drawingBox.Y = (int)(selectionArea.Y * th) - 1;
                    drawingBox.Width = (int)(selectionArea.Width * tw) + 2;
                    drawingBox.Height = (int)(selectionArea.Height * th) + 2;

                    penWorker.Brush = brushSelectionEdges;
                    graphic.DrawRectangle(penWorker, drawingBox);
                }
            }
            else if (toolMode == ToolMode.PAINT_TOOL)
            {
                // draw cursor position rectangle
                if (hoverCell.X > -1)
                {
                    drawingBox.X = (int)(hoverCell.X * tw) - 1;
                    drawingBox.Y = (int)(hoverCell.Y * th) - 1;
                    drawingBox.Width = (int)tw + 2;
                    drawingBox.Height = (int)th + 2;

                    penWorker.Brush = brushHoverPosition;
                    graphic.DrawRectangle(penWorker, drawingBox);
                }
            }
            else if (toolMode == ToolMode.TEXT_TOOL)
            {
                // draw flashing cursor
                if (selectionArea.X > -1 && cursorVisible)
                {
                    drawingBox.X = (int)(selectionArea.X * tw) - 1;
                    drawingBox.Y = (int)(selectionArea.Y * th) - 1;
                    drawingBox.Width = (int)(selectionArea.Width * tw) + 2;
                    drawingBox.Height = (int)(selectionArea.Height * th) + 2;

                    penWorker.Brush = brushFlashingCursor;
                    graphic.DrawRectangle(penWorker, drawingBox);
                }
            }
        }

        /* Event handlers*/
        private void handleMouseDown(object sender, MouseEventArgs e)
        {
            mouseDrag = true;
            setPointUnderMouse(ref hoverCell, e);
            setPointUnderMouse(ref pressCell, e);
            cursorVisible = true;

            if (toolMode == ToolMode.PAINT_TOOL)
                if (CellPaintStart != null)
                    CellPaintStart(this, new EventArgs());

            Invalidate();
        }

        private void handleMouseUp(object sender, MouseEventArgs e)
        {
            
            setPointUnderMouse(ref hoverCell, e);
            if (mouseDrag)
            {
                mouseDrag = false;
                validateSelectionArea();
            }

            if (CellSelected != null)
                CellSelected(this, new EventArgs());

            Invalidate();
        }

        private void handleMouseMove(object sender, MouseEventArgs e)
        {
            if (editable == false)
                return;

            setPointUnderMouse(ref hoverCell, e);

            if (mouseDrag)
            {
                validateSelectionArea();

                if (toolMode == ToolMode.PAINT_TOOL)
                    if (CellPaintMove != null)
                        CellPaintMove(this, new EventArgs());
            }

            if (toolMode == ToolMode.PAINT_TOOL || mouseDrag)
            {
                Invalidate();
            }
        }

        private void handleMouseLeave(object sender, EventArgs e)
        {
            hoverCell.X = -1;
            hoverCell.Y = -1;
            mouseDrag = false;
            Invalidate();
        }

        private void handleCursorFlash(object sender, EventArgs e)
        {
            cursorVisible = !cursorVisible;
            Invalidate();
        }

        /* Public properties */
        [Category("CMV Player Editor")]
        public ToolMode ToolMode
        {
            get { return toolMode; }
            set {
                toolMode = value;

                if (toolMode == ToolMode.TEXT_TOOL)
                    cursorFlashTimer.Start();
                else
                    cursorFlashTimer.Stop();

                Invalidate();
            }
        }

        public Point PaintedCell
        {
            get { return hoverCell; }
        }

        public Rectangle SelectionArea
        {
            get { return selectionArea; }
        }
	}
}
