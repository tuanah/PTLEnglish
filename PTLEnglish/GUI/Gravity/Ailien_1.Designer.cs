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
            this.lbWord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbWord
            // 
            this.lbWord.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.lbWord.ForeColor = System.Drawing.Color.Green;
            this.lbWord.Location = new System.Drawing.Point(39, 211);
            this.lbWord.Name = "lbWord";
            this.lbWord.Size = new System.Drawing.Size(189, 52);
            this.lbWord.TabIndex = 4;
            this.lbWord.Text = "Word";
            this.lbWord.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Ailien_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.lbWord);
            this.DoubleBuffered = true;
            this.Name = "Ailien_1";
            this.Size = new System.Drawing.Size(263, 274);
            this.Load += new System.EventHandler(this.Ailien_1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbWord;
    }
}
