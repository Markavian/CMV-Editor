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
    public partial class CMVInfoControl : UserControl
    {
        CMV cmv;

        public CMVInfoControl()
        {
            InitializeComponent();
        }

        public void updateInfo()
        {
            string NL = "\n";
            StringBuilder str = new StringBuilder();

            if (cmv == null)
            {
                str = new StringBuilder("No CMV file loaded");
            }
            else
            {
                str.AppendFormat("File: {0} {1}", cmv.Filename, NL);
                str.AppendFormat("Version: {0} {1}", cmv.Version, NL);
                str.AppendFormat("Size: {0} by {1} {2}", cmv.Columns, cmv.Rows, NL);
                str.AppendFormat("Frames: {0} {1}", cmv.FrameCount, NL);
                str.AppendFormat("Sounds: {0} {1}", cmv.Sounds, NL);
            }

            textboxInfo.Text = str.ToString();
        }

        public CMV CMV
        {
            get { return cmv; }
            set {
                cmv = value;
                updateInfo();
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
