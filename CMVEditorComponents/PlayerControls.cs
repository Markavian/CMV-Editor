using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace CMVEditorComponents
{
    public partial class PlayerControls : UserControl
    {
        [Category("Player Controls")]
        public event EventHandler PlayClick, PauseClick, RewindClick, SkipToEndClick, StepBackwardsClick, StepForwardsClick;

        public PlayerControls()
        {
            InitializeComponent();
        }

        /* Public properties */
        public string FrameNumberText
        {
            get { return textFrameNumber.Text; }
            set { textFrameNumber.Text = value; }
        }

        /* Event handlers */

        private void handleRewindClick(object sender, EventArgs e)
        {
            if (RewindClick != null)
                RewindClick(sender, e);
        }

        private void handlePlayClick(object sender, EventArgs e)
        {
            if (PlayClick != null)
                PlayClick(sender, e);
        }

        private void handlePauseClick(object sender, EventArgs e)
        {
            if (PauseClick != null)
                PauseClick(sender, e);
        }

        private void handleSkipToEndClick(object sender, EventArgs e)
        {
            if (SkipToEndClick != null)
                SkipToEndClick(sender, e);
        }

        private void handleStepBackwardsClick(object sender, EventArgs e)
        {
            if (StepBackwardsClick != null)
                StepBackwardsClick(sender, e);
        }

        private void handleStepForwardsClick(object sender, EventArgs e)
        {
            if (StepForwardsClick != null)
                StepForwardsClick(sender, e);
        }


    }
}
