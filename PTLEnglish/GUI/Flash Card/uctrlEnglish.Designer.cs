namespace PTLEnglish.GUI.Flash_Card
{
    partial class uctrlEnglish
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uctrlEnglish));
            this.pnEnglish = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pic_Hard = new System.Windows.Forms.PictureBox();
            this.pbSound = new System.Windows.Forms.PictureBox();
            this.lbEnglish = new System.Windows.Forms.Label();
            this.pnEnglish.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Hard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSound)).BeginInit();
            this.SuspendLayout();
            // 
            // pnEnglish
            // 
            this.pnEnglish.Controls.Add(this.label1);
            this.pnEnglish.Controls.Add(this.pictureBox1);
            this.pnEnglish.Controls.Add(this.pic_Hard);
            this.pnEnglish.Controls.Add(this.pbSound);
            this.pnEnglish.Controls.Add(this.lbEnglish);
            this.pnEnglish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnEnglish.Location = new System.Drawing.Point(0, 0);
            this.pnEnglish.Name = "pnEnglish";
            this.pnEnglish.Size = new System.Drawing.Size(643, 339);
            this.pnEnglish.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(169)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(491, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "CLICK HERE TO FLIP";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PTLEnglish.Properties.Resources.Restart_64__1_;
            this.pictureBox1.Location = new System.Drawing.Point(459, 305);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // pic_Hard
            // 
            this.pic_Hard.BackColor = System.Drawing.Color.White;
            this.pic_Hard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Hard.Image = ((System.Drawing.Image)(resources.GetObject("pic_Hard.Image")));
            this.pic_Hard.Location = new System.Drawing.Point(594, 10);
            this.pic_Hard.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.pic_Hard.Name = "pic_Hard";
            this.pic_Hard.Size = new System.Drawing.Size(34, 34);
            this.pic_Hard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Hard.TabIndex = 27;
            this.pic_Hard.TabStop = false;
            // 
            // pbSound
            // 
            this.pbSound.Image = global::PTLEnglish.Properties.Resources.Room_Sound_Filled_50;
            this.pbSound.Location = new System.Drawing.Point(543, 10);
            this.pbSound.Name = "pbSound";
            this.pbSound.Size = new System.Drawing.Size(34, 34);
            this.pbSound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSound.TabIndex = 26;
            this.pbSound.TabStop = false;
            this.pbSound.Click += new System.EventHandler(this.pbSound_Click);
            this.pbSound.MouseLeave += new System.EventHandler(this.pbSound_MouseLeave);
            this.pbSound.MouseHover += new System.EventHandler(this.pbSound_MouseHover);
            // 
            // lbEnglish
            // 
            this.lbEnglish.AutoSize = true;
            this.lbEnglish.Font = new System.Drawing.Font("Cambria", 34.25F, System.Drawing.FontStyle.Bold);
            this.lbEnglish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(83)))), ((int)(((byte)(88)))));
            this.lbEnglish.Location = new System.Drawing.Point(197, 138);
            this.lbEnglish.Name = "lbEnglish";
            this.lbEnglish.Size = new System.Drawing.Size(178, 54);
            this.lbEnglish.TabIndex = 25;
            this.lbEnglish.Text = "English";
            // 
            // uctrlEnglish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnEnglish);
            this.Name = "uctrlEnglish";
            this.Size = new System.Drawing.Size(643, 339);
            this.pnEnglish.ResumeLayout(false);
            this.pnEnglish.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Hard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSound)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnEnglish;
        private System.Windows.Forms.PictureBox pic_Hard;
        private System.Windows.Forms.PictureBox pbSound;
        private System.Windows.Forms.Label lbEnglish;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}
