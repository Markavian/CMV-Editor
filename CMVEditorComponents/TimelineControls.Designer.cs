namespace CMVEditorComponents
{
    partial class TimelineControls
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonCut = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonPaste = new System.Windows.Forms.Button();
            this.buttonCrop = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonPad = new System.Windows.Forms.Button();
            this.buttonStrip = new System.Windows.Forms.Button();
            this.timelineZoomControls = new CMVEditorComponents.TimelineZoom();
            this.buttonUndo = new System.Windows.Forms.Button();
            this.toolTipController = new System.Windows.Forms.ToolTip(this.components);
            this.flowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowPanel
            // 
            this.flowPanel.AutoSize = true;
            this.flowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowPanel.Controls.Add(this.buttonCut);
            this.flowPanel.Controls.Add(this.buttonCopy);
            this.flowPanel.Controls.Add(this.buttonPaste);
            this.flowPanel.Controls.Add(this.buttonCrop);
            this.flowPanel.Controls.Add(this.buttonDelete);
            this.flowPanel.Controls.Add(this.buttonPad);
            this.flowPanel.Controls.Add(this.buttonStrip);
            this.flowPanel.Controls.Add(this.timelineZoomControls);
            this.flowPanel.Controls.Add(this.buttonUndo);
            this.flowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanel.Location = new System.Drawing.Point(0, 0);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(424, 36);
            this.flowPanel.TabIndex = 0;
            // 
            // buttonCut
            // 
            this.buttonCut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCut.Location = new System.Drawing.Point(0, 0);
            this.buttonCut.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.buttonCut.Name = "buttonCut";
            this.buttonCut.Size = new System.Drawing.Size(45, 36);
            this.buttonCut.TabIndex = 12;
            this.buttonCut.Text = "Cut";
            this.buttonCut.UseVisualStyleBackColor = true;
            this.buttonCut.Click += new System.EventHandler(this.handleCutClick);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCopy.Location = new System.Drawing.Point(48, 0);
            this.buttonCopy.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(45, 36);
            this.buttonCopy.TabIndex = 13;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.handleCopyClick);
            // 
            // buttonPaste
            // 
            this.buttonPaste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPaste.Enabled = false;
            this.buttonPaste.Location = new System.Drawing.Point(96, 0);
            this.buttonPaste.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.buttonPaste.Name = "buttonPaste";
            this.buttonPaste.Size = new System.Drawing.Size(45, 36);
            this.buttonPaste.TabIndex = 14;
            this.buttonPaste.Text = "Paste";
            this.buttonPaste.UseVisualStyleBackColor = true;
            this.buttonPaste.Click += new System.EventHandler(this.handlePasteClick);
            // 
            // buttonCrop
            // 
            this.buttonCrop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCrop.Location = new System.Drawing.Point(144, 0);
            this.buttonCrop.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.buttonCrop.Name = "buttonCrop";
            this.buttonCrop.Size = new System.Drawing.Size(45, 36);
            this.buttonCrop.TabIndex = 9;
            this.buttonCrop.Text = "Crop";
            this.buttonCrop.UseVisualStyleBackColor = true;
            this.buttonCrop.Click += new System.EventHandler(this.handleCropClick);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDelete.Location = new System.Drawing.Point(192, 0);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(45, 36);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "Del";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.handleDeleteClick);
            // 
            // buttonPad
            // 
            this.buttonPad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPad.Enabled = false;
            this.buttonPad.Location = new System.Drawing.Point(240, 0);
            this.buttonPad.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.buttonPad.Name = "buttonPad";
            this.buttonPad.Size = new System.Drawing.Size(45, 36);
            this.buttonPad.TabIndex = 15;
            this.buttonPad.Text = "Pad";
            this.buttonPad.UseVisualStyleBackColor = true;
            this.buttonPad.Click += new System.EventHandler(this.handlePadClick);
            // 
            // buttonStrip
            // 
            this.buttonStrip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonStrip.Enabled = false;
            this.buttonStrip.Location = new System.Drawing.Point(288, 0);
            this.buttonStrip.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.buttonStrip.Name = "buttonStrip";
            this.buttonStrip.Size = new System.Drawing.Size(45, 36);
            this.buttonStrip.TabIndex = 16;
            this.buttonStrip.Text = "Strip";
            this.buttonStrip.UseVisualStyleBackColor = true;
            this.buttonStrip.Click += new System.EventHandler(this.handleStripClick);
            // 
            // timelineZoomControls
            // 
            this.timelineZoomControls.AutoSize = true;
            this.timelineZoomControls.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.timelineZoomControls.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.timelineZoomControls.Location = new System.Drawing.Point(336, 0);
            this.timelineZoomControls.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.timelineZoomControls.Name = "timelineZoomControls";
            this.timelineZoomControls.Size = new System.Drawing.Size(40, 35);
            this.timelineZoomControls.TabIndex = 11;
            this.timelineZoomControls.Timeline = null;
            // 
            // buttonUndo
            // 
            this.buttonUndo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonUndo.Enabled = false;
            this.buttonUndo.Location = new System.Drawing.Point(379, 0);
            this.buttonUndo.Margin = new System.Windows.Forms.Padding(0);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(45, 36);
            this.buttonUndo.TabIndex = 18;
            this.buttonUndo.Text = "Undo";
            this.buttonUndo.UseVisualStyleBackColor = true;
            this.buttonUndo.Click += new System.EventHandler(this.handleUndoClick);
            // 
            // TimelineControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.flowPanel);
            this.Name = "TimelineControls";
            this.Size = new System.Drawing.Size(424, 36);
            this.flowPanel.ResumeLayout(false);
            this.flowPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowPanel;
        private System.Windows.Forms.ToolTip toolTipController;
        private System.Windows.Forms.Button buttonCut;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonPaste;
        private System.Windows.Forms.Button buttonCrop;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonPad;
        private System.Windows.Forms.Button buttonStrip;
        private TimelineZoom timelineZoomControls;
        private System.Windows.Forms.Button buttonUndo;
    }
}
