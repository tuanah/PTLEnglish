namespace PTLEnglish.GUI.Listen
{
    partial class uctrlBoth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uctrlBoth));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lbVietnamese = new System.Windows.Forms.Label();
            this.lbEnglish = new System.Windows.Forms.Label();
            this.pic_Hard = new System.Windows.Forms.PictureBox();
            this.pbSound = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Hard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSound)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(222)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(0, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 2);
            this.panel1.TabIndex = 0;
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(19, 176);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(226, 136);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 1;
            this.pbImage.TabStop = false;
            // 
            // lbVietnamese
            // 
            this.lbVietnamese.Font = new System.Drawing.Font("Cambria", 28.25F, System.Drawing.FontStyle.Bold);
            this.lbVietnamese.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(83)))), ((int)(((byte)(88)))));
            this.lbVietnamese.Location = new System.Drawing.Point(195, 57);
            this.lbVietnamese.Name = "lbVietnamese";
            this.lbVietnamese.Size = new System.Drawing.Size(413, 58);
            this.lbVietnamese.TabIndex = 23;
            this.lbVietnamese.Text = "Vietnamese";
            // 
            // lbEnglish
            // 
            this.lbEnglish.Font = new System.Drawing.Font("Cambria", 28.25F, System.Drawing.FontStyle.Bold);
            this.lbEnglish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(83)))), ((int)(((byte)(88)))));
            this.lbEnglish.Location = new System.Drawing.Point(268, 223);
            this.lbEnglish.Name = "lbEnglish";
            this.lbEnglish.Size = new System.Drawing.Size(317, 55);
            this.lbEnglish.TabIndex = 24;
            this.lbEnglish.Text = "English";
            // 
            // pic_Hard
            // 
            this.pic_Hard.BackColor = System.Drawing.Color.White;
            this.pic_Hard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Hard.Image = ((System.Drawing.Image)(resources.GetObject("pic_Hard.Image")));
            this.pic_Hard.Location = new System.Drawing.Point(588, 3);
            this.pic_Hard.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.pic_Hard.Name = "pic_Hard";
            this.pic_Hard.Size = new System.Drawing.Size(34, 34);
            this.pic_Hard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Hard.TabIndex = 29;
            this.pic_Hard.TabStop = false;
            // 
            // pbSound
            // 
            this.pbSound.Image = global::PTLEnglish.Properties.Resources.Room_Sound_Filled_50;
            this.pbSound.Location = new System.Drawing.Point(537, 3);
            this.pbSound.Name = "pbSound";
            this.pbSound.Size = new System.Drawing.Size(34, 34);
            this.pbSound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSound.TabIndex = 28;
            this.pbSound.TabStop = false;
            this.pbSound.Click += new System.EventHandler(this.pbSound_Click);
            this.pbSound.MouseLeave += new System.EventHandler(this.pbSound_MouseLeave);
            this.pbSound.MouseHover += new System.EventHandler(this.pbSound_MouseHover);
            // 
            // uctrlBoth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pic_Hard);
            this.Controls.Add(this.pbSound);
            this.Controls.Add(this.lbEnglish);
            this.Controls.Add(this.lbVietnamese);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.panel1);
            this.Name = "uctrlBoth";
            this.Size = new System.Drawing.Size(643, 339);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Hard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSound)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lbVietnamese;
        private System.Windows.Forms.Label lbEnglish;
        private System.Windows.Forms.PictureBox pic_Hard;
        private System.Windows.Forms.PictureBox pbSound;
    }
}
