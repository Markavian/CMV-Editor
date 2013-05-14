namespace CMVEditor
{
    partial class ChooseDimensionsBox
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.labelWidth = new System.Windows.Forms.Label();
            this.formWidth = new System.Windows.Forms.NumericUpDown();
            this.labelHeight = new System.Windows.Forms.Label();
            this.formHeight = new System.Windows.Forms.NumericUpDown();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.Controls.Add(this.flowLayoutPanel);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.groupBox.Size = new System.Drawing.Size(188, 94);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Dimensions";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Controls.Add(this.labelWidth);
            this.flowLayoutPanel.Controls.Add(this.formWidth);
            this.flowLayoutPanel.Controls.Add(this.labelHeight);
            this.flowLayoutPanel.Controls.Add(this.formHeight);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(3, 28);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(182, 63);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(3, 0);
            this.labelWidth.MinimumSize = new System.Drawing.Size(110, 0);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(110, 13);
            this.labelWidth.TabIndex = 0;
            this.labelWidth.Text = "Width (columns)";
            // 
            // formWidth
            // 
            this.formWidth.Location = new System.Drawing.Point(119, 3);
            this.formWidth.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.formWidth.Name = "formWidth";
            this.formWidth.Size = new System.Drawing.Size(55, 20);
            this.formWidth.TabIndex = 4;
            this.formWidth.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(3, 26);
            this.labelHeight.MinimumSize = new System.Drawing.Size(110, 0);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(110, 13);
            this.labelHeight.TabIndex = 1;
            this.labelHeight.Text = "Height (rows)";
            // 
            // formHeight
            // 
            this.formHeight.Location = new System.Drawing.Point(119, 29);
            this.formHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.formHeight.Name = "formHeight";
            this.formHeight.Size = new System.Drawing.Size(55, 20);
            this.formHeight.TabIndex = 5;
            this.formHeight.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(125, 110);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(44, 110);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // ChooseDimensionsBox
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(212, 139);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChooseDimensionsBox";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Choose Dimensions";
            this.TopMost = true;
            this.groupBox.ResumeLayout(false);
            this.flowLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formHeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.NumericUpDown formWidth;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.NumericUpDown formHeight;
    }
}