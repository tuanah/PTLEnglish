namespace PTLEnglish.GUI.Listen
{
    partial class uctrlListen1
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
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnImageAndMean = new System.Windows.Forms.Panel();
            this.lbMean = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.pnReadListenSub = new System.Windows.Forms.Panel();
            this.lbkey = new System.Windows.Forms.Label();
            this.lbCommand = new System.Windows.Forms.Label();
            this.pnHorizontal = new System.Windows.Forms.Panel();
            this.pnHorizontalRun = new System.Windows.Forms.Panel();
            this.pbListen = new System.Windows.Forms.PictureBox();
            this.tbText = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnImageAndMean.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.pnReadListenSub.SuspendLayout();
            this.pnHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbListen)).BeginInit();
            this.SuspendLayout();
            // 
            // pnImageAndMean
            // 
            this.pnImageAndMean.Controls.Add(this.lbMean);
            this.pnImageAndMean.Controls.Add(this.pbImage);
            this.pnImageAndMean.Location = new System.Drawing.Point(5, 10);
            this.pnImageAndMean.Name = "pnImageAndMean";
            this.pnImageAndMean.Size = new System.Drawing.Size(571, 144);
            this.pnImageAndMean.TabIndex = 20;
            // 
            // lbMean
            // 
            this.lbMean.AutoSize = true;
            this.lbMean.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbMean.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(83)))), ((int)(((byte)(88)))));
            this.lbMean.Location = new System.Drawing.Point(213, 52);
            this.lbMean.Name = "lbMean";
            this.lbMean.Size = new System.Drawing.Size(82, 32);
            this.lbMean.TabIndex = 13;
            this.lbMean.Text = "Mean";
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(37, 10);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(161, 117);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 12;
            this.pbImage.TabStop = false;
            // 
            // pnReadListenSub
            // 
            this.pnReadListenSub.Controls.Add(this.lbkey);
            this.pnReadListenSub.Controls.Add(this.lbCommand);
            this.pnReadListenSub.Controls.Add(this.pnHorizontal);
            this.pnReadListenSub.Controls.Add(this.pbListen);
            this.pnReadListenSub.Controls.Add(this.tbText);
            this.pnReadListenSub.Location = new System.Drawing.Point(6, 168);
            this.pnReadListenSub.Name = "pnReadListenSub";
            this.pnReadListenSub.Size = new System.Drawing.Size(570, 106);
            this.pnReadListenSub.TabIndex = 21;
            // 
            // lbkey
            // 
            this.lbkey.AutoSize = true;
            this.lbkey.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbkey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(83)))), ((int)(((byte)(88)))));
            this.lbkey.Location = new System.Drawing.Point(83, 80);
            this.lbkey.Name = "lbkey";
            this.lbkey.Size = new System.Drawing.Size(57, 22);
            this.lbkey.TabIndex = 14;
            this.lbkey.Text = "Mean";
            this.lbkey.Visible = false;
            // 
            // lbCommand
            // 
            this.lbCommand.AutoSize = true;
            this.lbCommand.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCommand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.lbCommand.Location = new System.Drawing.Point(77, 59);
            this.lbCommand.Name = "lbCommand";
            this.lbCommand.Size = new System.Drawing.Size(166, 17);
            this.lbCommand.TabIndex = 10;
            this.lbCommand.Text = "TYPE WHAT YOU HEAR";
            // 
            // pnHorizontal
            // 
            this.pnHorizontal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnHorizontal.Controls.Add(this.pnHorizontalRun);
            this.pnHorizontal.Location = new System.Drawing.Point(80, 52);
            this.pnHorizontal.Name = "pnHorizontal";
            this.pnHorizontal.Size = new System.Drawing.Size(449, 3);
            this.pnHorizontal.TabIndex = 6;
            // 
            // pnHorizontalRun
            // 
            this.pnHorizontalRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnHorizontalRun.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnHorizontalRun.Location = new System.Drawing.Point(0, 0);
            this.pnHorizontalRun.Name = "pnHorizontalRun";
            this.pnHorizontalRun.Size = new System.Drawing.Size(0, 3);
            this.pnHorizontalRun.TabIndex = 2;
            // 
            // pbListen
            // 
            this.pbListen.Image = global::PTLEnglish.Properties.Resources.Room_Sound_Filled_50;
            this.pbListen.Location = new System.Drawing.Point(20, 6);
            this.pbListen.Name = "pbListen";
            this.pbListen.Size = new System.Drawing.Size(51, 51);
            this.pbListen.TabIndex = 9;
            this.pbListen.TabStop = false;
            this.pbListen.Click += new System.EventHandler(this.pbListen_Click);
            this.pbListen.MouseLeave += new System.EventHandler(this.pbListen_MouseLeave);
            this.pbListen.MouseHover += new System.EventHandler(this.pbListen_MouseHover);
            // 
            // tbText
            // 
            this.tbText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbText.Font = new System.Drawing.Font("Cambria", 19.75F);
            this.tbText.Location = new System.Drawing.Point(78, 15);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(451, 31);
            this.tbText.TabIndex = 8;
            this.tbText.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbText_MouseClick);
            this.tbText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbText_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.panel2.Location = new System.Drawing.Point(21, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 2);
            this.panel2.TabIndex = 22;
            // 
            // uctrlListen1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnReadListenSub);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnImageAndMean);
            this.Name = "uctrlListen1";
            this.Size = new System.Drawing.Size(584, 281);
            this.Load += new System.EventHandler(this.uctrlListen1_Load);
            this.pnImageAndMean.ResumeLayout(false);
            this.pnImageAndMean.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.pnReadListenSub.ResumeLayout(false);
            this.pnReadListenSub.PerformLayout();
            this.pnHorizontal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbListen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel pnImageAndMean;
        private System.Windows.Forms.Label lbMean;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Panel pnReadListenSub;
        private System.Windows.Forms.Label lbkey;
        private System.Windows.Forms.Label lbCommand;
        private System.Windows.Forms.Panel pnHorizontal;
        private System.Windows.Forms.Panel pnHorizontalRun;
        private System.Windows.Forms.PictureBox pbListen;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Panel panel2;
    }
}
