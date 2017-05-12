namespace PTLEnglish.GUI.Listen
{
    partial class uctrlListen
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
            this.fpnMain = new System.Windows.Forms.FlowLayoutPanel();
            this.pnImageAndMean = new System.Windows.Forms.Panel();
            this.lbMean = new System.Windows.Forms.Label();
            this.pnReadListen = new System.Windows.Forms.Panel();
            this.pnReadListenSub = new System.Windows.Forms.Panel();
            this.lbkey = new System.Windows.Forms.Label();
            this.lbCommand = new System.Windows.Forms.Label();
            this.pnHorizontal = new System.Windows.Forms.Panel();
            this.pnHorizontalRun = new System.Windows.Forms.Panel();
            this.tbText = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnWrong = new System.Windows.Forms.Panel();
            this.pnWrongRun = new System.Windows.Forms.Panel();
            this.lbWrong = new System.Windows.Forms.Label();
            this.pnCorrect = new System.Windows.Forms.Panel();
            this.pnCorrectRun = new System.Windows.Forms.Panel();
            this.lbCorrect = new System.Windows.Forms.Label();
            this.pnProgress = new System.Windows.Forms.Panel();
            this.pnProgressRun = new System.Windows.Forms.Panel();
            this.lbProgress = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.pbListen = new System.Windows.Forms.PictureBox();
            this.fpnMain.SuspendLayout();
            this.pnImageAndMean.SuspendLayout();
            this.pnReadListen.SuspendLayout();
            this.pnReadListenSub.SuspendLayout();
            this.pnHorizontal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnWrong.SuspendLayout();
            this.pnCorrect.SuspendLayout();
            this.pnProgress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbListen)).BeginInit();
            this.SuspendLayout();
            // 
            // fpnMain
            // 
            this.fpnMain.AutoScroll = true;
            this.fpnMain.BackColor = System.Drawing.Color.White;
            this.fpnMain.Controls.Add(this.pnImageAndMean);
            this.fpnMain.Controls.Add(this.pnReadListen);
            this.fpnMain.Controls.Add(this.panel1);
            this.fpnMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fpnMain.Location = new System.Drawing.Point(12, 13);
            this.fpnMain.Name = "fpnMain";
            this.fpnMain.Size = new System.Drawing.Size(667, 538);
            this.fpnMain.TabIndex = 0;
            this.fpnMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseClick);
            // 
            // pnImageAndMean
            // 
            this.pnImageAndMean.Controls.Add(this.lbMean);
            this.pnImageAndMean.Controls.Add(this.pbImage);
            this.pnImageAndMean.Location = new System.Drawing.Point(3, 3);
            this.pnImageAndMean.Name = "pnImageAndMean";
            this.pnImageAndMean.Size = new System.Drawing.Size(642, 248);
            this.pnImageAndMean.TabIndex = 18;
            this.pnImageAndMean.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseClick);
            // 
            // lbMean
            // 
            this.lbMean.AutoSize = true;
            this.lbMean.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbMean.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(83)))), ((int)(((byte)(88)))));
            this.lbMean.Location = new System.Drawing.Point(35, 209);
            this.lbMean.Name = "lbMean";
            this.lbMean.Size = new System.Drawing.Size(82, 32);
            this.lbMean.TabIndex = 13;
            this.lbMean.Text = "Mean";
            // 
            // pnReadListen
            // 
            this.pnReadListen.Controls.Add(this.pnReadListenSub);
            this.pnReadListen.Controls.Add(this.panel2);
            this.pnReadListen.Location = new System.Drawing.Point(3, 257);
            this.pnReadListen.Name = "pnReadListen";
            this.pnReadListen.Size = new System.Drawing.Size(651, 138);
            this.pnReadListen.TabIndex = 17;
            this.pnReadListen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseClick);
            // 
            // pnReadListenSub
            // 
            this.pnReadListenSub.Controls.Add(this.lbkey);
            this.pnReadListenSub.Controls.Add(this.lbCommand);
            this.pnReadListenSub.Controls.Add(this.pnHorizontal);
            this.pnReadListenSub.Controls.Add(this.pbListen);
            this.pnReadListenSub.Controls.Add(this.tbText);
            this.pnReadListenSub.Location = new System.Drawing.Point(8, 14);
            this.pnReadListenSub.Name = "pnReadListenSub";
            this.pnReadListenSub.Size = new System.Drawing.Size(634, 116);
            this.pnReadListenSub.TabIndex = 14;
            // 
            // lbkey
            // 
            this.lbkey.AutoSize = true;
            this.lbkey.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbkey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(83)))), ((int)(((byte)(88)))));
            this.lbkey.Location = new System.Drawing.Point(83, 80);
            this.lbkey.Name = "lbkey";
            this.lbkey.Size = new System.Drawing.Size(82, 32);
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
            this.pnHorizontal.Size = new System.Drawing.Size(490, 3);
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
            // tbText
            // 
            this.tbText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbText.Font = new System.Drawing.Font("Cambria", 19.75F);
            this.tbText.Location = new System.Drawing.Point(78, 15);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(492, 31);
            this.tbText.TabIndex = 8;
            this.tbText.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbText_MouseClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.panel2.Location = new System.Drawing.Point(23, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 2);
            this.panel2.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pnWrong);
            this.panel1.Controls.Add(this.lbWrong);
            this.panel1.Controls.Add(this.pnCorrect);
            this.panel1.Controls.Add(this.lbCorrect);
            this.panel1.Controls.Add(this.pnProgress);
            this.panel1.Controls.Add(this.lbProgress);
            this.panel1.Location = new System.Drawing.Point(3, 401);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 134);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(651, 6);
            this.panel3.TabIndex = 23;
            // 
            // pnWrong
            // 
            this.pnWrong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(161)))), ((int)(((byte)(145)))));
            this.pnWrong.Controls.Add(this.pnWrongRun);
            this.pnWrong.Location = new System.Drawing.Point(117, 54);
            this.pnWrong.Name = "pnWrong";
            this.pnWrong.Size = new System.Drawing.Size(525, 29);
            this.pnWrong.TabIndex = 22;
            // 
            // pnWrongRun
            // 
            this.pnWrongRun.BackColor = System.Drawing.Color.Red;
            this.pnWrongRun.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnWrongRun.Location = new System.Drawing.Point(0, 0);
            this.pnWrongRun.Name = "pnWrongRun";
            this.pnWrongRun.Size = new System.Drawing.Size(0, 29);
            this.pnWrongRun.TabIndex = 14;
            // 
            // lbWrong
            // 
            this.lbWrong.AutoSize = true;
            this.lbWrong.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbWrong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(83)))), ((int)(((byte)(88)))));
            this.lbWrong.Location = new System.Drawing.Point(29, 58);
            this.lbWrong.Name = "lbWrong";
            this.lbWrong.Size = new System.Drawing.Size(84, 22);
            this.lbWrong.TabIndex = 21;
            this.lbWrong.Text = "WRONG:";
            // 
            // pnCorrect
            // 
            this.pnCorrect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(230)))), ((int)(((byte)(141)))));
            this.pnCorrect.Controls.Add(this.pnCorrectRun);
            this.pnCorrect.Location = new System.Drawing.Point(117, 13);
            this.pnCorrect.Name = "pnCorrect";
            this.pnCorrect.Size = new System.Drawing.Size(525, 29);
            this.pnCorrect.TabIndex = 20;
            // 
            // pnCorrectRun
            // 
            this.pnCorrectRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.pnCorrectRun.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnCorrectRun.Location = new System.Drawing.Point(0, 0);
            this.pnCorrectRun.Name = "pnCorrectRun";
            this.pnCorrectRun.Size = new System.Drawing.Size(0, 29);
            this.pnCorrectRun.TabIndex = 14;
            // 
            // lbCorrect
            // 
            this.lbCorrect.AutoSize = true;
            this.lbCorrect.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbCorrect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(83)))), ((int)(((byte)(88)))));
            this.lbCorrect.Location = new System.Drawing.Point(14, 17);
            this.lbCorrect.Name = "lbCorrect";
            this.lbCorrect.Size = new System.Drawing.Size(99, 22);
            this.lbCorrect.TabIndex = 19;
            this.lbCorrect.Text = "CORRECT:";
            // 
            // pnProgress
            // 
            this.pnProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(205)))), ((int)(((byte)(232)))));
            this.pnProgress.Controls.Add(this.pnProgressRun);
            this.pnProgress.Location = new System.Drawing.Point(117, 95);
            this.pnProgress.Name = "pnProgress";
            this.pnProgress.Size = new System.Drawing.Size(525, 29);
            this.pnProgress.TabIndex = 18;
            // 
            // pnProgressRun
            // 
            this.pnProgressRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(87)))), ((int)(((byte)(178)))));
            this.pnProgressRun.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnProgressRun.Location = new System.Drawing.Point(0, 0);
            this.pnProgressRun.Name = "pnProgressRun";
            this.pnProgressRun.Size = new System.Drawing.Size(0, 29);
            this.pnProgressRun.TabIndex = 19;
            // 
            // lbProgress
            // 
            this.lbProgress.AutoSize = true;
            this.lbProgress.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(83)))), ((int)(((byte)(88)))));
            this.lbProgress.Location = new System.Drawing.Point(4, 99);
            this.lbProgress.Name = "lbProgress";
            this.lbProgress.Size = new System.Drawing.Size(109, 22);
            this.lbProgress.TabIndex = 16;
            this.lbProgress.Text = "PROGRESS:";
            // 
            // timer
            // 
            this.timer.Interval = 400;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(41, 11);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(211, 195);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 12;
            this.pbImage.TabStop = false;
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
            // uctrlListen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.Controls.Add(this.fpnMain);
            this.Name = "uctrlListen";
            this.Size = new System.Drawing.Size(697, 561);
            this.Tag = "697, 561";
            this.Load += new System.EventHandler(this.uctrlListen_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseClick);
            this.fpnMain.ResumeLayout(false);
            this.pnImageAndMean.ResumeLayout(false);
            this.pnImageAndMean.PerformLayout();
            this.pnReadListen.ResumeLayout(false);
            this.pnReadListenSub.ResumeLayout(false);
            this.pnReadListenSub.PerformLayout();
            this.pnHorizontal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnWrong.ResumeLayout(false);
            this.pnCorrect.ResumeLayout(false);
            this.pnProgress.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbListen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.FlowLayoutPanel fpnMain;
        private System.Windows.Forms.Panel pnImageAndMean;
        private System.Windows.Forms.Label lbMean;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Panel pnReadListen;
        private System.Windows.Forms.Label lbCommand;
        private System.Windows.Forms.PictureBox pbListen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Panel pnHorizontal;
        private System.Windows.Forms.Panel pnHorizontalRun;
        private System.Windows.Forms.Label lbkey;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnProgress;
        private System.Windows.Forms.Panel pnProgressRun;
        private System.Windows.Forms.Label lbProgress;
        private System.Windows.Forms.Panel pnCorrect;
        private System.Windows.Forms.Label lbCorrect;
        private System.Windows.Forms.Panel pnWrong;
        private System.Windows.Forms.Label lbWrong;
        private System.Windows.Forms.Panel pnCorrectRun;
        private System.Windows.Forms.Panel pnWrongRun;
        private System.Windows.Forms.Panel pnReadListenSub;
        private System.Windows.Forms.Panel panel3;
    }
}
