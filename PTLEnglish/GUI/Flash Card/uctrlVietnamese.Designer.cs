namespace PTLEnglish.GUI.Flash_Card
{
    partial class uctrlVietnamese
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uctrlVietnamese));
            this.pnVietnamese = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pic_Hard = new System.Windows.Forms.PictureBox();
            this.lbVietnamese = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.pnVietnamese.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Hard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnVietnamese
            // 
            this.pnVietnamese.Controls.Add(this.label1);
            this.pnVietnamese.Controls.Add(this.pictureBox1);
            this.pnVietnamese.Controls.Add(this.pic_Hard);
            this.pnVietnamese.Controls.Add(this.lbVietnamese);
            this.pnVietnamese.Controls.Add(this.pbImage);
            this.pnVietnamese.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnVietnamese.Location = new System.Drawing.Point(0, 0);
            this.pnVietnamese.Name = "pnVietnamese";
            this.pnVietnamese.Size = new System.Drawing.Size(623, 303);
            this.pnVietnamese.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(169)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(472, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "CLICK HERE TO FLIP";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PTLEnglish.Properties.Resources.Restart_64__1_;
            this.pictureBox1.Location = new System.Drawing.Point(440, 269);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // pic_Hard
            // 
            this.pic_Hard.BackColor = System.Drawing.Color.White;
            this.pic_Hard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Hard.Image = ((System.Drawing.Image)(resources.GetObject("pic_Hard.Image")));
            this.pic_Hard.Location = new System.Drawing.Point(583, 4);
            this.pic_Hard.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.pic_Hard.Name = "pic_Hard";
            this.pic_Hard.Size = new System.Drawing.Size(34, 34);
            this.pic_Hard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Hard.TabIndex = 28;
            this.pic_Hard.TabStop = false;
            // 
            // lbVietnamese
            // 
            this.lbVietnamese.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold);
            this.lbVietnamese.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(83)))), ((int)(((byte)(88)))));
            this.lbVietnamese.Location = new System.Drawing.Point(253, 93);
            this.lbVietnamese.Name = "lbVietnamese";
            this.lbVietnamese.Size = new System.Drawing.Size(366, 101);
            this.lbVietnamese.TabIndex = 24;
            this.lbVietnamese.Text = "Vietnamese";
            this.lbVietnamese.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(9, 61);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(239, 185);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 23;
            this.pbImage.TabStop = false;
            // 
            // uctrlVietnamese
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnVietnamese);
            this.Name = "uctrlVietnamese";
            this.Size = new System.Drawing.Size(623, 303);
            this.pnVietnamese.ResumeLayout(false);
            this.pnVietnamese.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Hard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnVietnamese;
        private System.Windows.Forms.Label lbVietnamese;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.PictureBox pic_Hard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
