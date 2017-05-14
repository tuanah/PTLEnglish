namespace PTLEnglish.GUI.Gravity
{
    partial class Ailien_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ailien_1));
            this.pbAilien = new System.Windows.Forms.PictureBox();
            this.lbWord = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAilien)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAilien
            // 
            this.pbAilien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbAilien.Image = ((System.Drawing.Image)(resources.GetObject("pbAilien.Image")));
            this.pbAilien.Location = new System.Drawing.Point(0, 0);
            this.pbAilien.Name = "pbAilien";
            this.pbAilien.Size = new System.Drawing.Size(282, 293);
            this.pbAilien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAilien.TabIndex = 0;
            this.pbAilien.TabStop = false;
            // 
            // lbWord
            // 
            this.lbWord.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold);
            this.lbWord.Location = new System.Drawing.Point(32, 155);
            this.lbWord.Name = "lbWord";
            this.lbWord.Size = new System.Drawing.Size(211, 48);
            this.lbWord.TabIndex = 1;
            this.lbWord.Text = "Word";
            this.lbWord.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Ailien_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbWord);
            this.Controls.Add(this.pbAilien);
            this.Name = "Ailien_1";
            this.Size = new System.Drawing.Size(282, 293);
            this.Load += new System.EventHandler(this.Ailien_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAilien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAilien;
        private System.Windows.Forms.Label lbWord;
    }
}
