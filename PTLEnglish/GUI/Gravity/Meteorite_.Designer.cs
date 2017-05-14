namespace PTLEnglish.GUI.Gravity
{
    partial class Meteorite_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Meteorite_));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbMeteorite = new System.Windows.Forms.PictureBox();
            this.lbWord = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMeteorite)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbWord);
            this.panel1.Controls.Add(this.pbMeteorite);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 247);
            this.panel1.TabIndex = 0;
            // 
            // pbMeteorite
            // 
            this.pbMeteorite.Image = ((System.Drawing.Image)(resources.GetObject("pbMeteorite.Image")));
            this.pbMeteorite.Location = new System.Drawing.Point(3, 3);
            this.pbMeteorite.Name = "pbMeteorite";
            this.pbMeteorite.Size = new System.Drawing.Size(233, 241);
            this.pbMeteorite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMeteorite.TabIndex = 0;
            this.pbMeteorite.TabStop = false;
            // 
            // lbWord
            // 
            this.lbWord.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbWord.Location = new System.Drawing.Point(37, 96);
            this.lbWord.Name = "lbWord";
            this.lbWord.Size = new System.Drawing.Size(162, 61);
            this.lbWord.TabIndex = 1;
            this.lbWord.Text = "Word";
            // 
            // Meteorite_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Meteorite_";
            this.Size = new System.Drawing.Size(239, 247);
            this.Load += new System.EventHandler(this.Meteorite__Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMeteorite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbMeteorite;
        private System.Windows.Forms.Label lbWord;
    }
}
