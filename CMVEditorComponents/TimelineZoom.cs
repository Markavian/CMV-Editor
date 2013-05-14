using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace CMVEditorComponents
{
    public partial class TimelineZoom : UserControl
    {
        private TimelineControl timeline;
        private decimal increment;

        [Category("Timeline Zoom")]
        public event EventHandler ZoomInClick, ZoomOutClick, TimelineChanged, IncrementChanged;

        public TimelineZoom()
        {
            InitializeComponent();
            increment = 0.5M;
        }

        /* Public properties */
        public TimelineControl Timeline
        {
            get { return timeline; }
            set
            {
                timeline = value;
                if (TimelineChanged != null)
                    TimelineChanged(this, new EventArgs());
            }
        }

        public decimal Increment
        {
            get { return increment; }
            set
            {
                increment = value;
                if (IncrementChanged != null)
                    IncrementChanged(this, new EventArgs());
            }
        }

        /* Event handlers */
        public void handleZoomInClick(object sender, EventArgs e)
        {
            if (timeline != null)
                timeline.Zoom = (float)Decimal.Multiply((Decimal)timeline.Zoom, (1 + increment));

            if (ZoomInClick != null)
                ZoomInClick(this, new EventArgs());
        }

        public void handleZoomOutClick(object sender, EventArgs e)
        {
            if (timeline != null)
                timeline.Zoom = (float)Decimal.Multiply((Decimal)timeline.Zoom, (1 - increment));

            if (ZoomOutClick != null)
                ZoomOutClick(this, new EventArgs());
        }
    }
}
