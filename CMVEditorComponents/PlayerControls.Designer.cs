namespace CMVEditorComponents
{
    partial class PlayerControls
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
            this.textFrameNumber = new System.Windows.Forms.TextBox();
            this.toolTipController = new System.Windows.Forms.ToolTip(this.components);
            this.rewindButton = new CMVEditorComponents.PlainButton();
            this.skipToEndButton = new CMVEditorComponents.PlainButton();
            this.playButton = new CMVEditorComponents.PlainButton();
            this.pauseButton = new CMVEditorComponents.PlainButton();
            this.stepBackwardsButton = new CMVEditorComponents.PlainButton();
            this.stepForwardsButton = new CMVEditorComponents.PlainButton();
            this.flowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowPanel
            // 
            this.flowPanel.AutoSize = true;
            this.flowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowPanel.Controls.Add(this.rewindButton);
            this.flowPanel.Controls.Add(this.skipToEndButton);
            this.flowPanel.Controls.Add(this.playButton);
            this.flowPanel.Controls.Add(this.pauseButton);
            this.flowPanel.Controls.Add(this.textFrameNumber);
            this.flowPanel.Controls.Add(this.stepBackwardsButton);
            this.flowPanel.Controls.Add(this.stepForwardsButton);
            this.flowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanel.Location = new System.Drawing.Point(0, 0);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(299, 36);
            this.flowPanel.TabIndex = 0;
            // 
            // textFrameNumber
            // 
            this.textFrameNumber.AcceptsReturn = true;
            this.textFrameNumber.Enabled = false;
            this.textFrameNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textFrameNumber.Location = new System.Drawing.Point(156, 0);
            this.textFrameNumber.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.textFrameNumber.Multiline = true;
            this.textFrameNumber.Name = "textFrameNumber";
            this.textFrameNumber.ReadOnly = true;
            this.textFrameNumber.Size = new System.Drawing.Size(65, 36);
            this.textFrameNumber.TabIndex = 6;
            this.textFrameNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipController.SetToolTip(this.textFrameNumber, "Current frame number");
            // 
            // rewindButton
            // 
            this.rewindButton.BackColor = System.Drawing.SystemColors.Control;
            this.rewindButton.BackgroundImage = global::CMVEditorComponents.Properties.Resources.rewind_icon;
            this.rewindButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rewindButton.BorderFocusColor = System.Drawing.Color.White;
            this.rewindButton.BorderFocusSize = 2;
            this.rewindButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rewindButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.rewindButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rewindButton.Location = new System.Drawing.Point(0, 0);
            this.rewindButton.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.rewindButton.Name = "rewindButton";
            this.rewindButton.Size = new System.Drawing.Size(36, 36);
            this.rewindButton.TabIndex = 2;
            this.toolTipController.SetToolTip(this.rewindButton, "Jump to previous marker");
            this.rewindButton.UseVisualStyleBackColor = false;
            this.rewindButton.Click += new System.EventHandler(this.handleRewindClick);
            // 
            // skipToEndButton
            // 
            this.skipToEndButton.BackColor = System.Drawing.SystemColors.Control;
            this.skipToEndButton.BackgroundImage = global::CMVEditorComponents.Properties.Resources.skiptoend_icon;
            this.skipToEndButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.skipToEndButton.BorderFocusColor = System.Drawing.Color.White;
            this.skipToEndButton.BorderFocusSize = 2;
            this.skipToEndButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.skipToEndButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.skipToEndButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.skipToEndButton.Location = new System.Drawing.Point(39, 0);
            this.skipToEndButton.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.skipToEndButton.Name = "skipToEndButton";
            this.skipToEndButton.Size = new System.Drawing.Size(36, 36);
            this.skipToEndButton.TabIndex = 3;
            this.toolTipController.SetToolTip(this.skipToEndButton, "Jump to next marker");
            this.skipToEndButton.UseVisualStyleBackColor = false;
            this.skipToEndButton.Click += new System.EventHandler(this.handleSkipToEndClick);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.SystemColors.Control;
            this.playButton.BackgroundImage = global::CMVEditorComponents.Properties.Resources.play_icon;
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.playButton.BorderFocusColor = System.Drawing.Color.White;
            this.playButton.BorderFocusSize = 2;
            this.playButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.playButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.playButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.playButton.Location = new System.Drawing.Point(78, 0);
            this.playButton.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(36, 36);
            this.playButton.TabIndex = 0;
            this.toolTipController.SetToolTip(this.playButton, "Play / Pause");
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.handlePlayClick);
            // 
            // pauseButton
            // 
            this.pauseButton.BackColor = System.Drawing.SystemColors.Control;
            this.pauseButton.BackgroundImage = global::CMVEditorComponents.Properties.Resources.pause_icon;
            this.pauseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pauseButton.BorderFocusColor = System.Drawing.Color.White;
            this.pauseButton.BorderFocusSize = 2;
            this.pauseButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.pauseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.pauseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pauseButton.Location = new System.Drawing.Point(117, 0);
            this.pauseButton.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(36, 36);
            this.pauseButton.TabIndex = 1;
            this.toolTipController.SetToolTip(this.pauseButton, "Pause");
            this.pauseButton.UseVisualStyleBackColor = false;
            this.pauseButton.Click += new System.EventHandler(this.handlePauseClick);
            // 
            // stepBackwardsButton
            // 
            this.stepBackwardsButton.BackColor = System.Drawing.SystemColors.Control;
            this.stepBackwardsButton.BackgroundImage = global::CMVEditorComponents.Properties.Resources.stepbackwards_icon;
            this.stepBackwardsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.stepBackwardsButton.BorderFocusColor = System.Drawing.Color.White;
            this.stepBackwardsButton.BorderFocusSize = 2;
            this.stepBackwardsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.stepBackwardsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.stepBackwardsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.stepBackwardsButton.Location = new System.Drawing.Point(224, 0);
            this.stepBackwardsButton.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.stepBackwardsButton.Name = "stepBackwardsButton";
            this.stepBackwardsButton.Size = new System.Drawing.Size(36, 36);
            this.stepBackwardsButton.TabIndex = 4;
            this.toolTipController.SetToolTip(this.stepBackwardsButton, "Step backwards");
            this.stepBackwardsButton.UseVisualStyleBackColor = false;
            this.stepBackwardsButton.Click += new System.EventHandler(this.handleStepBackwardsClick);
            // 
            // stepForwardsButton
            // 
            this.stepForwardsButton.BackColor = System.Drawing.SystemColors.Control;
            this.stepForwardsButton.BackgroundImage = global::CMVEditorComponents.Properties.Resources.stepforwards_icon;
            this.stepForwardsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.stepForwardsButton.BorderFocusColor = System.Drawing.Color.White;
            this.stepForwardsButton.BorderFocusSize = 2;
            this.stepForwardsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.stepForwardsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.stepForwardsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.stepForwardsButton.Location = new System.Drawing.Point(263, 0);
            this.stepForwardsButton.Margin = new System.Windows.Forms.Padding(0);
            this.stepForwardsButton.Name = "stepForwardsButton";
            this.stepForwardsButton.Size = new System.Drawing.Size(36, 36);
            this.stepForwardsButton.TabIndex = 5;
            this.toolTipController.SetToolTip(this.stepForwardsButton, "Step forwards");
            this.stepForwardsButton.UseVisualStyleBackColor = false;
            this.stepForwardsButton.Click += new System.EventHandler(this.handleStepForwardsClick);
            // 
            // PlayerControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.flowPanel);
            this.Name = "PlayerControls";
            this.Size = new System.Drawing.Size(299, 36);
            this.flowPanel.ResumeLayout(false);
            this.flowPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowPanel;
        private System.Windows.Forms.ToolTip toolTipController;
        private System.Windows.Forms.TextBox textFrameNumber;
        private PlainButton rewindButton;
        private PlainButton playButton;
        private PlainButton pauseButton;
        private PlainButton skipToEndButton;
        private PlainButton stepBackwardsButton;
        private PlainButton stepForwardsButton;
    }
}
