using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace CMVEditorComponents
{
    public partial class TimelineControl : UserControl
    {
        // Information variables
        int selectionStartIndex;
        int selectionEndIndex;

        int maxValue;
        int playHeadPosition;

        // Draw variables
        float zoom;
        int viewOffset;
        bool trackPlayhead;

        // Mouse interactions
        int hoverIndex;
        int pressIndex;
        int releaseIndex;
        bool dragged;

        const int DEFAULT_PEG_WIDTH = 5;

        public delegate void IndexHandler(object sender, int index);
        public delegate void SelectionHandler(object sender, int startIndex, int endIndex);

        [Category("Timeline")]
        public event IndexHandler FrameSelected, ViewOffsetChanged;
        [Category("Timeline")]
        public event SelectionHandler SelectionChanged;

        public TimelineControl()
        {
            initialise();
        }

        private void initialise()
        {
            InitializeComponent();

            ClearSelection();

            maxValue = 0;
            playHeadPosition = 0;

            zoom = 1.0f;
            viewOffset = 0;
            trackPlayhead = true;
            hoverIndex = -1;

            makeBrushes();

            Invalidate();
        }

        /* Drawing objects */
        SolidBrush brushBackground;
        SolidBrush brushPegLine, brushPegFill;
        SolidBrush brushSelectionFill;
        SolidBrush brushSelectionEdges;
        SolidBrush brushPlayHead;
        SolidBrush brushHoverPosition;
        SolidBrush brushLabel;

        Pen penWorker;
        Font fontWorker;

        Rectangle drawingBox;
        Point p1, p2;

        int lowViewRange;
        int highViewRange;
        int pegSize;
        int visiblePegs;
        int frameIndexToDraw;

        private void makeBrushes()
        {
            brushBackground = new SolidBrush(Color.LightGray);
            brushPegLine = new SolidBrush(Color.Gray);
            brushPegFill = new SolidBrush(Color.Gray);
            brushSelectionEdges = new SolidBrush(Color.LightSlateGray);
            brushSelectionFill = new SolidBrush(Color.FromArgb(50, Color.Green));
            brushPlayHead = new SolidBrush(Color.FromArgb(150, Color.Navy));
            brushHoverPosition = new SolidBrush(Color.FromArgb(50, Color.Red));
            brushLabel = new SolidBrush(Color.Black);

            penWorker = new Pen(brushBackground, 1);
            fontWorker = new Font("Arial", 8.0f, GraphicsUnit.Pixel);
            drawingBox = new Rectangle();

            p1 = new Point(0, 0);
            p2 = new Point(0, 0);
        }

        // Paint me...
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphic;
            Rectangle box;

            base.OnPaint(e);
            graphic = e.Graphics;

            box = drawingBox;

            validateSelectionRange();
            validatePlayHead();

            // Calculate timeline properties
            pegSize = (int)Math.Ceiling(DEFAULT_PEG_WIDTH * zoom);
            visiblePegs = (int)Math.Ceiling((double)(Width / pegSize));

            lowViewRange = viewOffset - (visiblePegs / 2);
            if (lowViewRange < 0)
                lowViewRange = 0;

            highViewRange = lowViewRange + visiblePegs;
            if (highViewRange > maxValue)
                highViewRange = maxValue;

            // Draw background
            box.X = 0; box.Y = 0;
            box.Height = Height;
            box.Width = Width;
            graphic.FillRectangle(brushBackground, box);

            // Draw visible frames
            penWorker.Brush = brushPegLine;
            box.Y = 2; box.Height = Height - 10;
            for (int i = 0; lowViewRange + i < highViewRange; i++)
            {
                box.X = (i * pegSize);
                box.Width = pegSize;

                frameIndexToDraw = lowViewRange + i;

                // Draw text labels spaced out
                if (frameIndexToDraw % 10 == 0)
                {
                    graphic.FillRectangle(brushPegFill, box);

                    p1.X = box.X;
                    p1.Y = box.Y + box.Height;
                    graphic.DrawString((frameIndexToDraw + 1).ToString(), fontWorker, brushLabel, p1);
                }

                // Draw selection area
                if (frameIndexToDraw >= selectionStartIndex && frameIndexToDraw <= selectionEndIndex)
                    graphic.FillRectangle(brushSelectionFill, box);

                // Draw play head
                if (frameIndexToDraw == playHeadPosition)
                    graphic.FillRectangle(brushPlayHead, box);

                // Draw hover position
                if (frameIndexToDraw == hoverIndex)
                    graphic.FillRectangle(brushHoverPosition, box);

                // Draw peg outlines
                graphic.DrawRectangle(penWorker, box);
            }

        }

        private void handleResize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void validatePlayHead()
        {
            // Ensure play head is within acceptable range
            if (playHeadPosition > maxValue)
                playHeadPosition = maxValue;
            if (playHeadPosition < 0)
                playHeadPosition = 0;

            // Update viewOffset based on playhead position
            if (trackPlayhead)
            {
                if (playHeadPosition > highViewRange)
                    viewOffset = playHeadPosition;

                else if (playHeadPosition < lowViewRange)
                    viewOffset = playHeadPosition;
            }
        }

        private void validateSelectionRange()
        {
            int swap;
            if (selectionStartIndex > selectionEndIndex)
            {
                swap = selectionEndIndex;
                selectionEndIndex = selectionStartIndex;
                selectionStartIndex = swap;
            }
        }

        private int getFrameUnderCursor(MouseEventArgs mouse)
        {
            pegSize = (int)Math.Ceiling(DEFAULT_PEG_WIDTH * zoom);
            int frame = Math.Max(0, lowViewRange + (mouse.X / pegSize));

            if (frame < 0)
                frame = 0;
            if (frame > FrameCount)
                frame = FrameCount;

            return frame;
        }

        /* Public methods */
        public void ClearSelection()
        {
            selectionStartIndex = -1; // selection start and end
            selectionEndIndex = -1;
        }

        /* Public properties */
        public int FrameCount
        {
            get { return maxValue; }
            set { maxValue = value; Invalidate(); }
        }

        public int SelectionStart
        {
            get { return selectionStartIndex; }
            set { selectionStartIndex = value; Invalidate();  }
        }

        public int SelectionEnd
        {
            get { return selectionEndIndex; }
            set { selectionEndIndex = value; Invalidate(); }
        }

        public float Zoom
        {
            get { return zoom; }
            set {
                zoom = value;
                if (zoom > Width / DEFAULT_PEG_WIDTH)
                    zoom = Width / DEFAULT_PEG_WIDTH;
                if (zoom < (float)2 / (float)DEFAULT_PEG_WIDTH)
                    zoom = (float)2 / (float)DEFAULT_PEG_WIDTH;
                Invalidate();
            }
        }

        public int ViewOffset
        {
            get { return viewOffset; }
            set { viewOffset = value; Invalidate(); }
        }

        public int PlayHeadPosition
        {
            get { return playHeadPosition; }
            set { playHeadPosition = value; Invalidate(); }
        }

        public bool TrackPlayhead
        {
            get { return trackPlayhead; }
            set { trackPlayhead = value; }
        }

        /* Event handlers */
        private void handleMouseMove(object sender, MouseEventArgs e)
        {
            hoverIndex = getFrameUnderCursor(e);
            if (dragged)
            {
                if (FrameSelected != null)
                    FrameSelected(this, hoverIndex);

                selectionStartIndex = pressIndex;
                selectionEndIndex = hoverIndex;

                validateSelectionRange();

                if (SelectionChanged != null)
                    SelectionChanged(this, selectionStartIndex, selectionEndIndex);
            }
            Invalidate();
        }

        private void handleMouseLeave(object sender, EventArgs e)
        {
            hoverIndex = -1;
            Invalidate();
        }

        private void handleMouseUp(object sender, MouseEventArgs e)
        {
            releaseIndex = getFrameUnderCursor(e);
            dragged = false;

            if (FrameSelected != null)
                FrameSelected(this, releaseIndex);

            selectionStartIndex = pressIndex;
            selectionEndIndex = releaseIndex;

            validateSelectionRange();

            if (SelectionChanged != null)
                SelectionChanged(this, selectionStartIndex, selectionEndIndex);
 
            Invalidate();
        }

        private void handleMouseDown(object sender, MouseEventArgs e)
        {
            pressIndex = getFrameUnderCursor(e);

            selectionStartIndex = pressIndex;
            selectionEndIndex = pressIndex;

            dragged = true;

            Invalidate();
        }

        /* Protected Events */
        protected virtual void OnFrameSelected(object sender, int frameIndex)
        {
            FrameSelected(sender, frameIndex);
        }

        protected virtual void OnViewOffsetChanged(object sender, int frameIndex)
        {
            ViewOffsetChanged(sender, frameIndex);
        }

        protected virtual void OnSelectionChanged(object sender, int startIndex, int endIndex)
        {
            SelectionChanged(sender, startIndex, endIndex);
        }
    }
}
