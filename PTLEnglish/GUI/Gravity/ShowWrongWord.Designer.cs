namespace PTLEnglish.GUI.Gravity
{
    partial class ShowWrongWord
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
            this.lbWord = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbWord
            // 
            this.lbWord.Font = new System.Drawing.Font("Cambria", 26.25F);
            this.lbWord.ForeColor = System.Drawing.Color.White;
            this.lbWord.Location = new System.Drawing.Point(3, 12);
            this.lbWord.Name = "lbWord";
            this.lbWord.Size = new System.Drawing.Size(395, 71);
            this.lbWord.TabIndex = 0;
            this.lbWord.Text = "label1";
            this.lbWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(46, 101);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(312, 172);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 1;
            this.pbImage.TabStop = false;
            // 
            // ShowWrongWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.lbWord);
            this.Name = "ShowWrongWord";
            this.Size = new System.Drawing.Size(412, 291);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbWord;
        private System.Windows.Forms.PictureBox pbImage;
    }
}
