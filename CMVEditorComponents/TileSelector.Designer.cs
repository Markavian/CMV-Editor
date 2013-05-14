namespace CMVEditorComponents
{
    partial class TileSelector
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
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.flowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.tileBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.flowLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tileBox)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown
            // 
            this.numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown.Location = new System.Drawing.Point(73, 3);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(52, 26);
            this.numericUpDown.TabIndex = 0;
            this.numericUpDown.ValueChanged += new System.EventHandler(this.numericIndexChanged);
            // 
            // flowLayout
            // 
            this.flowLayout.Controls.Add(this.tileBox);
            this.flowLayout.Controls.Add(this.numericUpDown);
            this.flowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayout.Location = new System.Drawing.Point(0, 0);
            this.flowLayout.Name = "flowLayout";
            this.flowLayout.Size = new System.Drawing.Size(128, 70);
            this.flowLayout.TabIndex = 1;
            // 
            // tileBox
            // 
            this.tileBox.BackColor = System.Drawing.Color.Black;
            this.tileBox.Location = new System.Drawing.Point(3, 3);
            this.tileBox.Name = "tileBox";
            this.tileBox.Size = new System.Drawing.Size(64, 64);
            this.tileBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.tileBox.TabIndex = 1;
            this.tileBox.TabStop = false;
            this.tileBox.Click += new System.EventHandler(this.handleTileBoxClick);
            // 
            // TileSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayout);
            this.Name = "TileSelector";
            this.Size = new System.Drawing.Size(128, 70);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.flowLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tileBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.FlowLayoutPanel flowLayout;
        private System.Windows.Forms.PictureBox tileBox;
    }
}
