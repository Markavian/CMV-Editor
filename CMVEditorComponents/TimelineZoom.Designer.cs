namespace CMVEditorComponents
{
    partial class TimelineZoom
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
            this.zoomOutButton = new CMVEditorComponents.PlainButton();
            this.zoomInButton = new CMVEditorComponents.PlainButton();
            this.SuspendLayout();
            // 
            // zoomOutButton
            // 
            this.zoomOutButton.BackgroundImage = global::CMVEditorComponents.Properties.Resources.timeline_zoomout_icon;
            this.zoomOutButton.BorderFocusColor = System.Drawing.Color.Empty;
            this.zoomOutButton.BorderFocusSize = 1;
            this.zoomOutButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.zoomOutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.zoomOutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.zoomOutButton.Location = new System.Drawing.Point(0, 17);
            this.zoomOutButton.Margin = new System.Windows.Forms.Padding(0);
            this.zoomOutButton.Name = "zoomOutButton";
            this.zoomOutButton.Size = new System.Drawing.Size(40, 18);
            this.zoomOutButton.TabIndex = 1;
            this.zoomOutButton.Text = "zoomOutButton";
            this.zoomOutButton.UseVisualStyleBackColor = true;
            this.zoomOutButton.Click += new System.EventHandler(this.handleZoomOutClick);
            // 
            // zoomInButton
            // 
            this.zoomInButton.BackgroundImage = global::CMVEditorComponents.Properties.Resources.timeline_zoomin_icon;
            this.zoomInButton.BorderFocusColor = System.Drawing.Color.Empty;
            this.zoomInButton.BorderFocusSize = 1;
            this.zoomInButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.zoomInButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.zoomInButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.zoomInButton.Location = new System.Drawing.Point(0, 0);
            this.zoomInButton.Margin = new System.Windows.Forms.Padding(0);
            this.zoomInButton.Name = "zoomInButton";
            this.zoomInButton.Size = new System.Drawing.Size(40, 18);
            this.zoomInButton.TabIndex = 0;
            this.zoomInButton.Text = "zoomInButton";
            this.zoomInButton.UseVisualStyleBackColor = true;
            this.zoomInButton.Click += new System.EventHandler(this.handleZoomInClick);
            // 
            // TimelineZoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.zoomOutButton);
            this.Controls.Add(this.zoomInButton);
            this.Name = "TimelineZoom";
            this.Size = new System.Drawing.Size(40, 35);
            this.ResumeLayout(false);

        }

        #endregion

        private PlainButton zoomInButton;
        private PlainButton zoomOutButton;
    }
}
