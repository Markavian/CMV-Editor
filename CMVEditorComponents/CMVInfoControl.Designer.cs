namespace CMVEditorComponents
{
    partial class CMVInfoControl
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
            this.textboxInfo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textboxInfo
            // 
            this.textboxInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxInfo.BackColor = System.Drawing.SystemColors.Highlight;
            this.textboxInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxInfo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxInfo.Location = new System.Drawing.Point(0, 0);
            this.textboxInfo.Margin = new System.Windows.Forms.Padding(0);
            this.textboxInfo.MaxLength = 65536;
            this.textboxInfo.Name = "textboxInfo";
            this.textboxInfo.ReadOnly = true;
            this.textboxInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.textboxInfo.Size = new System.Drawing.Size(138, 154);
            this.textboxInfo.TabIndex = 0;
            this.textboxInfo.Text = "No file loaded";
            // 
            // CMVInfoControl
            // 
            this.Controls.Add(this.textboxInfo);
            this.Name = "CMVInfoControl";
            this.Size = new System.Drawing.Size(138, 154);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox textboxInfo;
    }
}
