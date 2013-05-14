namespace CMVEditorComponents
{
    partial class TimelineControl
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
            this.SuspendLayout();
            // 
            // TimelineControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.DoubleBuffered = true;
            this.Name = "TimelineControl";
            this.Size = new System.Drawing.Size(565, 67);
            this.MouseLeave += new System.EventHandler(this.handleMouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.handleMouseMove);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.handleMouseDown);
            this.Resize += new System.EventHandler(this.handleResize);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.handleMouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
