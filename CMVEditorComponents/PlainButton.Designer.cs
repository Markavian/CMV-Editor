namespace CMVEditorComponents
{
    partial class PlainButton
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
            // PlainButton
            // 
            this.Name = "PlainButton";
            this.Size = new System.Drawing.Size(40, 40);
            this.MouseLeave += new System.EventHandler(this.handleMouseLeave);
            this.Click += new System.EventHandler(this.handleClick);
            this.Leave += new System.EventHandler(this.handleFocus);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.handleMouseDown);
            this.Enter += new System.EventHandler(this.handleFocus);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.handleMouseUp);
            this.MouseEnter += new System.EventHandler(this.handleMouseEnter);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
