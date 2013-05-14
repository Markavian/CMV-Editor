using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace CMVEditorComponents
{
    public partial class TimelineControls : UserControl
    {
        [Category("Timeline Controls")]
        public event EventHandler CutClick, CopyClick, PasteClick, CropClick, DeleteClick, PadClick, StripClick, UndoClick;
        public event EventHandler TimelineChanged;

        private TimelineControl timeline;

        public TimelineControls()
        {
            InitializeComponent();
        }

        public TimelineControls(TimelineControl timelineControl)
        {
            timeline = timelineControl;

            timelineZoomControls.Timeline = timeline;
        }

        /* Public properties */
        public bool PasteEnabled
        {
            get { return buttonPaste.Enabled; }
            set { buttonPaste.Enabled = value; }
        }

        public bool UndoEnabled
        {
            get { return buttonUndo.Enabled; }
            set { buttonUndo.Enabled = value; }
        }

        public TimelineControl Timeline
        {
            get { return timeline; }
            set
            {
                timeline = value;

                timelineZoomControls.Timeline = timeline;

                if (TimelineChanged != null)
                    TimelineChanged(this, new EventArgs());
            }
        }

        /* Event handlers */
        private void handleCutClick(object sender, EventArgs e)
        {
            if (CutClick != null)
                CutClick(sender, e);

            if (timeline != null)
            {
                // TODO: Write cut method
            }
        }

        private void handleCopyClick(object sender, EventArgs e)
        {
            if (CopyClick != null)
                CopyClick(sender, e);

            if (timeline != null)
            {
                // TODO: Write copy method
            }
        }

        private void handlePasteClick(object sender, EventArgs e)
        {
            if (PasteClick != null)
                PasteClick(sender, e);

            if (timeline != null)
            {
                // TODO: Write paste method
            }
        }

        private void handleCropClick(object sender, EventArgs e)
        {
            if (CropClick != null)
                CropClick(sender, e);

            if (timeline != null)
            {
                // TODO: Write crop method
            }
        }

        private void handleDeleteClick(object sender, EventArgs e)
        {
            if (DeleteClick != null)
                DeleteClick(sender, e);

            if (timeline != null)
            {
                // TODO: Write delete method
            }
        }

        private void handlePadClick(object sender, EventArgs e)
        {
            if (PadClick != null)
                PadClick(sender, e);

            if (timeline != null)
            {
                // TODO: Write pad method
            }
        }

        private void handleStripClick(object sender, EventArgs e)
        {
            if (StripClick != null)
                StripClick(sender, e);

            if (timeline != null)
            {
                // TODO: Write strip method
            }
        }

        private void handleUndoClick(object sender, EventArgs e)
        {
            if (UndoClick != null)
                UndoClick(sender, e);
        }

        private void handleTimelineChanged(object sender, EventArgs e)
        {
            if (TimelineChanged != null)
                TimelineChanged(sender, e);
        }
    }
}
