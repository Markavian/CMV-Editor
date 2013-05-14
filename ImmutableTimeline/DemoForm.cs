using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ImmutableTimeline
{
    public partial class DemoForm : Form
    {
        List<DD> copyBuffer; 
        ImmutableList<DD> demoList;

        public DemoForm()
        {
            InitializeComponent();
            copyBuffer = new List<DD>();

            createDemoData();
        }

        private void createDemoData()
        {
            /* Create sample data */
            List<DD> sampleData = new List<DD>();
            for(int i=0; i<100; i++)
            {
                sampleData.Add(new DD((i + 1) * 100));
            }

            /* Initialise list */
            demoList = new ImmutableList<DD>(sampleData);

            /* Add start marker */
            demoList = demoList.Insert(0, new DD(-1));

            /* Add end marker */
            demoList = demoList.Add(new DD(-2));

            /* Remove frames inbetween */
            //demoList = demoList.RemoveRange(2, demoList.Count - 3);

            /* Remove third frame */
            //demoList = demoList.RemoveAt(2);

            /* Remove known frame */
            //DD frame = demoList[1];
            //demoList = demoList.Remove(frame);

            /* Update timeline control */
            RefreshTimelineControl();
            RefreshControls();
        }

        private class DD
        {
            int value;

            public DD(int val)
            {
                value = val;
            }

            public override string ToString()
            {
                return "" + value;
            }
        }

        private void timelineControl1_FrameSelected(object sender, int index)
        {
            timelineControl1.PlayHeadPosition = index;

            labelFrameIndex.Text = index.ToString();

            try
            {
                labelValue.Text = demoList[index - 1].ToString();
            }
            catch (Exception)
            {
                labelValue.Text = "[not set]";
            }
        }

        private void action_Copy(object sender, EventArgs e)
        {
            CMVEditorComponents.TimelineControl control = timelineControl1;
            copyBuffer = demoList.GetRange(control.SelectionStart - 1, control.SelectionEnd - 1);
        }

        private void action_Crop(object sender, EventArgs e)
        {
            CMVEditorComponents.TimelineControl control = timelineControl1;
            demoList = demoList.Crop(control.SelectionStart - 1, control.SelectionEnd - 1);

            RefreshTimelineControl();
            control.SelectionStart = 0;
            control.SelectionEnd = control.FrameCount - 1;
        }

        private void action_Cut(object sender, EventArgs e)
        {
            CMVEditorComponents.TimelineControl control = timelineControl1;
            copyBuffer = demoList.GetRange(control.SelectionStart - 1, control.SelectionEnd - 1);
            demoList = demoList.RemoveRange(control.SelectionStart - 1, control.SelectionEnd - 1);

            RefreshTimelineControl();
            control.SelectionEnd = control.SelectionStart;

            RefreshControls();
        }

        private void action_Delete(object sender, EventArgs e)
        {
            CMVEditorComponents.TimelineControl control = timelineControl1;
            demoList = demoList.RemoveRange(control.SelectionStart - 1, control.SelectionEnd - 1);

            RefreshTimelineControl();
            control.SelectionEnd = control.SelectionStart;

            RefreshControls();
        }

        private void action_Pad(object sender, EventArgs e)
        {
            RefreshTimelineControl();
            RefreshControls();
        }

        private void action_Paste(object sender, EventArgs e)
        {
            if (copyBuffer.Count == 0)
                return;

            CMVEditorComponents.TimelineControl control = timelineControl1;
            if (control.SelectionStart == control.SelectionEnd)
            {
                // Insert just before selection
                DD[] range = new DD[copyBuffer.Count];
                copyBuffer.CopyTo(range);
                demoList = demoList.InsertRange(control.SelectionStart - 1, range);

                RefreshTimelineControl();
                control.SelectionEnd = control.SelectionStart + copyBuffer.Count - 1;
            }
            else
            {
                // Replace selection
                DD[] range = new DD[copyBuffer.Count];
                copyBuffer.CopyTo(range);
                demoList = demoList.ReplaceRange(control.SelectionStart - 1, control.SelectionEnd - 1, range);

                RefreshTimelineControl();
                control.SelectionEnd = control.SelectionStart + copyBuffer.Count - 1;
            }

            RefreshControls();
        }

        private void action_Strip(object sender, EventArgs e)
        {
            RefreshTimelineControl();
            RefreshControls();
        }

        private void action_Undo(object sender, EventArgs e)
        {
            demoList = demoList.PreviousState;
            RefreshTimelineControl();
            RefreshControls();
        }

        public void RefreshTimelineControl()
        {
            CMVEditorComponents.TimelineControl control = timelineControl1;
            control.FrameCount = demoList.Count;
        }

        public void RefreshControls()
        {
            CMVEditorComponents.TimelineControls controls = timelineControls1;

            controls.PasteEnabled = (copyBuffer.Count > 0) ? true : false;
            controls.UndoEnabled = (demoList.PreviousState != demoList) ? true : false;

            timelineControl1_FrameSelected(this, timelineControl1.SelectionEnd);
        }

    }
}