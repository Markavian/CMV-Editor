namespace ImmutableTimeline
{
    partial class DemoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.timelineControls1 = new CMVEditorComponents.TimelineControls();
            this.timelineControl1 = new CMVEditorComponents.TimelineControl();
            this.labelSelectedFrame = new System.Windows.Forms.Label();
            this.labelValue = new System.Windows.Forms.Label();
            this.labelFrameIndex = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timelineControls1
            // 
            this.timelineControls1.AutoSize = true;
            this.timelineControls1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.timelineControls1.Location = new System.Drawing.Point(12, 79);
            this.timelineControls1.Name = "timelineControls1";
            this.timelineControls1.Size = new System.Drawing.Size(424, 36);
            this.timelineControls1.TabIndex = 1;
            this.timelineControls1.Timeline = this.timelineControl1;
            this.timelineControls1.DeleteClick += new System.EventHandler(this.action_Delete);
            this.timelineControls1.CopyClick += new System.EventHandler(this.action_Copy);
            this.timelineControls1.UndoClick += new System.EventHandler(this.action_Undo);
            this.timelineControls1.StripClick += new System.EventHandler(this.action_Strip);
            this.timelineControls1.CropClick += new System.EventHandler(this.action_Crop);
            this.timelineControls1.PasteClick += new System.EventHandler(this.action_Paste);
            this.timelineControls1.PadClick += new System.EventHandler(this.action_Pad);
            this.timelineControls1.CutClick += new System.EventHandler(this.action_Cut);
            // 
            // timelineControl1
            // 
            this.timelineControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.timelineControl1.FrameCount = 0;
            this.timelineControl1.Location = new System.Drawing.Point(12, 28);
            this.timelineControl1.Name = "timelineControl1";
            this.timelineControl1.Padding = new System.Windows.Forms.Padding(2);
            this.timelineControl1.PlayHeadPosition = 0;
            this.timelineControl1.SelectionEnd = -1;
            this.timelineControl1.SelectionStart = -1;
            this.timelineControl1.Size = new System.Drawing.Size(544, 45);
            this.timelineControl1.TabIndex = 0;
            this.timelineControl1.TrackPlayhead = true;
            this.timelineControl1.ViewOffset = 0;
            this.timelineControl1.Zoom = 1F;
            this.timelineControl1.FrameSelected += new CMVEditorComponents.TimelineControl.IndexHandler(this.timelineControl1_FrameSelected);
            // 
            // labelSelectedFrame
            // 
            this.labelSelectedFrame.AutoSize = true;
            this.labelSelectedFrame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedFrame.Location = new System.Drawing.Point(13, 12);
            this.labelSelectedFrame.Name = "labelSelectedFrame";
            this.labelSelectedFrame.Size = new System.Drawing.Size(131, 13);
            this.labelSelectedFrame.TabIndex = 2;
            this.labelSelectedFrame.Text = "Selected frame value:";
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(150, 12);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(45, 13);
            this.labelValue.TabIndex = 3;
            this.labelValue.Text = "[not set]";
            // 
            // labelFrameIndex
            // 
            this.labelFrameIndex.AutoSize = true;
            this.labelFrameIndex.Location = new System.Drawing.Point(502, 12);
            this.labelFrameIndex.Name = "labelFrameIndex";
            this.labelFrameIndex.Size = new System.Drawing.Size(54, 13);
            this.labelFrameIndex.TabIndex = 4;
            this.labelFrameIndex.Text = "[no frame]";
            this.labelFrameIndex.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // DemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 120);
            this.Controls.Add(this.labelFrameIndex);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.labelSelectedFrame);
            this.Controls.Add(this.timelineControls1);
            this.Controls.Add(this.timelineControl1);
            this.Name = "DemoForm";
            this.Text = "Immutable Timeline";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CMVEditorComponents.TimelineControl timelineControl1;
        private CMVEditorComponents.TimelineControls timelineControls1;
        private System.Windows.Forms.Label labelSelectedFrame;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Label labelFrameIndex;
    }
}

