namespace PTLEnglish.GUI.Flash_Card
{
    partial class uctrlMainFlashCard
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnProgress = new System.Windows.Forms.Panel();
            this.pnProgressRun = new System.Windows.Forms.Panel();
            this.lbProgress = new System.Windows.Forms.Label();
            this.flipPanel = new PTLEnglish.GUI.Flash_Card.FlipPanel();
            this.timerPlay = new System.Windows.Forms.Timer(this.components);
            this.pbLeft = new System.Windows.Forms.PictureBox();
            this.pbRight = new System.Windows.Forms.PictureBox();
            this.pbBoth = new System.Windows.Forms.PictureBox();
            this.pbShuffle = new System.Windows.Forms.PictureBox();
            this.pbAutoPlay = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.pnProgress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShuffle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAutoPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.panel3.Controls.Add(this.pnProgress);
            this.panel3.Controls.Add(this.lbProgress);
            this.panel3.Location = new System.Drawing.Point(29, 502);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(643, 45);
            this.panel3.TabIndex = 12;
            // 
            // pnProgress
            // 
            this.pnProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(205)))), ((int)(((byte)(232)))));
            this.pnProgress.Controls.Add(this.pnProgressRun);
            this.pnProgress.Location = new System.Drawing.Point(115, 8);
            this.pnProgress.Name = "pnProgress";
            this.pnProgress.Size = new System.Drawing.Size(525, 29);
            this.pnProgress.TabIndex = 20;
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
            this.lbProgress.Location = new System.Drawing.Point(2, 12);
            this.lbProgress.Name = "lbProgress";
            this.lbProgress.Size = new System.Drawing.Size(109, 22);
            this.lbProgress.TabIndex = 19;
            this.lbProgress.Text = "PROGRESS:";
            // 
            // flipPanel
            // 
            this.flipPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.flipPanel.Behind = null;
            this.flipPanel.CheckAnimation = true;
            this.flipPanel.Front = null;
            this.flipPanel.H_Behind = null;
            this.flipPanel.H_Front = null;
            this.flipPanel.Location = new System.Drawing.Point(39, 47);
            this.flipPanel.Name = "flipPanel";
            this.flipPanel.Size = new System.Drawing.Size(623, 303);
            this.flipPanel.TabIndex = 14;
            this.flipPanel.TimerInterval = 100;
            // 
            // timerPlay
            // 
            this.timerPlay.Tick += new System.EventHandler(this.timerPlay_Tick);
            // 
            // pbLeft
            // 
            this.pbLeft.Enabled = false;
            this.pbLeft.Image = global::PTLEnglish.Properties.Resources.Left_5121;
            this.pbLeft.Location = new System.Drawing.Point(230, 353);
            this.pbLeft.Name = "pbLeft";
            this.pbLeft.Size = new System.Drawing.Size(51, 66);
            this.pbLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLeft.TabIndex = 15;
            this.pbLeft.TabStop = false;
            this.pbLeft.Click += new System.EventHandler(this.pbLeft_Click);
            this.pbLeft.MouseLeave += new System.EventHandler(this.pbLeft_MouseLeave);
            this.pbLeft.MouseHover += new System.EventHandler(this.pbLeft_MouseHover);
            // 
            // pbRight
            // 
            this.pbRight.Image = global::PTLEnglish.Properties.Resources.Right_3_5121;
            this.pbRight.Location = new System.Drawing.Point(436, 352);
            this.pbRight.Name = "pbRight";
            this.pbRight.Size = new System.Drawing.Size(51, 66);
            this.pbRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRight.TabIndex = 13;
            this.pbRight.TabStop = false;
            this.pbRight.Click += new System.EventHandler(this.pbRight_Click);
            this.pbRight.MouseLeave += new System.EventHandler(this.pbRight_MouseLeave);
            this.pbRight.MouseHover += new System.EventHandler(this.pbRight_MouseHover);
            // 
            // pbBoth
            // 
            this.pbBoth.Image = global::PTLEnglish.Properties.Resources.both_1;
            this.pbBoth.Location = new System.Drawing.Point(492, 438);
            this.pbBoth.Name = "pbBoth";
            this.pbBoth.Size = new System.Drawing.Size(171, 46);
            this.pbBoth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBoth.TabIndex = 2;
            this.pbBoth.TabStop = false;
            this.pbBoth.Click += new System.EventHandler(this.pbBoth_Click);
            this.pbBoth.MouseLeave += new System.EventHandler(this.pbBoth_MouseLeave);
            this.pbBoth.MouseHover += new System.EventHandler(this.pbBoth_MouseHover);
            // 
            // pbShuffle
            // 
            this.pbShuffle.Image = global::PTLEnglish.Properties.Resources.shuffle_1;
            this.pbShuffle.Location = new System.Drawing.Point(269, 438);
            this.pbShuffle.Name = "pbShuffle";
            this.pbShuffle.Size = new System.Drawing.Size(171, 46);
            this.pbShuffle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShuffle.TabIndex = 1;
            this.pbShuffle.TabStop = false;
            this.pbShuffle.Click += new System.EventHandler(this.pbShuffle_Click);
            this.pbShuffle.MouseLeave += new System.EventHandler(this.pbShuffle_MouseLeave);
            this.pbShuffle.MouseHover += new System.EventHandler(this.pbShuffle_MouseHover);
            // 
            // pbAutoPlay
            // 
            this.pbAutoPlay.Image = global::PTLEnglish.Properties.Resources.auto_2;
            this.pbAutoPlay.Location = new System.Drawing.Point(39, 438);
            this.pbAutoPlay.Name = "pbAutoPlay";
            this.pbAutoPlay.Size = new System.Drawing.Size(171, 46);
            this.pbAutoPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAutoPlay.TabIndex = 0;
            this.pbAutoPlay.TabStop = false;
            this.pbAutoPlay.Click += new System.EventHandler(this.pbAutoPlay_Click);
            this.pbAutoPlay.MouseLeave += new System.EventHandler(this.pbAutoPlay_MouseLeave);
            this.pbAutoPlay.MouseHover += new System.EventHandler(this.pbAutoPlay_MouseHover);
            // 
            // uctrlMainFlashCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbLeft);
            this.Controls.Add(this.flipPanel);
            this.Controls.Add(this.pbRight);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pbBoth);
            this.Controls.Add(this.pbShuffle);
            this.Controls.Add(this.pbAutoPlay);
            this.Name = "uctrlMainFlashCard";
            this.Size = new System.Drawing.Size(697, 561);
            this.Load += new System.EventHandler(this.uctrlMainFlashCard_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnProgress.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShuffle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAutoPlay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAutoPlay;
        private System.Windows.Forms.PictureBox pbShuffle;
        private System.Windows.Forms.PictureBox pbBoth;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnProgress;
        private System.Windows.Forms.Panel pnProgressRun;
        private System.Windows.Forms.Label lbProgress;
        private System.Windows.Forms.PictureBox pbRight;
        private FlipPanel flipPanel;
        private System.Windows.Forms.PictureBox pbLeft;
        private System.Windows.Forms.Timer timerPlay;
    }
}
