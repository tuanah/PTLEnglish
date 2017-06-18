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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uctrlMainFlashCard));
            this.pbAutoPlay = new System.Windows.Forms.PictureBox();
            this.pbShuffle = new System.Windows.Forms.PictureBox();
            this.pbBoth = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnProgress = new System.Windows.Forms.Panel();
            this.pnProgressRun = new System.Windows.Forms.Panel();
            this.lbProgress = new System.Windows.Forms.Label();
            this.pbRight = new System.Windows.Forms.PictureBox();
            this.flipPanel = new PTLEnglish.GUI.Flash_Card.FlipPanel();
            this.pbLeft = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAutoPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShuffle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoth)).BeginInit();
            this.panel3.SuspendLayout();
            this.pnProgress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAutoPlay
            // 
            this.pbAutoPlay.Location = new System.Drawing.Point(37, 438);
            this.pbAutoPlay.Name = "pbAutoPlay";
            this.pbAutoPlay.Size = new System.Drawing.Size(171, 46);
            this.pbAutoPlay.TabIndex = 0;
            this.pbAutoPlay.TabStop = false;
            // 
            // pbShuffle
            // 
            this.pbShuffle.Location = new System.Drawing.Point(269, 438);
            this.pbShuffle.Name = "pbShuffle";
            this.pbShuffle.Size = new System.Drawing.Size(171, 46);
            this.pbShuffle.TabIndex = 1;
            this.pbShuffle.TabStop = false;
            // 
            // pbBoth
            // 
            this.pbBoth.Location = new System.Drawing.Point(492, 438);
            this.pbBoth.Name = "pbBoth";
            this.pbBoth.Size = new System.Drawing.Size(171, 46);
            this.pbBoth.TabIndex = 2;
            this.pbBoth.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.pnProgress);
            this.panel3.Controls.Add(this.lbProgress);
            this.panel3.Location = new System.Drawing.Point(27, 502);
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
            // pbRight
            // 
            this.pbRight.Image = ((System.Drawing.Image)(resources.GetObject("pbRight.Image")));
            this.pbRight.Location = new System.Drawing.Point(413, 357);
            this.pbRight.Name = "pbRight";
            this.pbRight.Size = new System.Drawing.Size(36, 56);
            this.pbRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRight.TabIndex = 13;
            this.pbRight.TabStop = false;
            // 
            // flipPanel
            // 
            this.flipPanel.BackColor = System.Drawing.SystemColors.Control;
            this.flipPanel.Behind = null;
            this.flipPanel.CheckAnimation = true;
            this.flipPanel.Front = null;
            this.flipPanel.H_Behind = null;
            this.flipPanel.H_Front = null;
            this.flipPanel.Location = new System.Drawing.Point(33, 47);
            this.flipPanel.Name = "flipPanel";
            this.flipPanel.Size = new System.Drawing.Size(623, 303);
            this.flipPanel.TabIndex = 14;
            this.flipPanel.TimerInterval = 100;
            // 
            // pbLeft
            // 
            this.pbLeft.Enabled = false;
            this.pbLeft.Image = ((System.Drawing.Image)(resources.GetObject("pbLeft.Image")));
            this.pbLeft.Location = new System.Drawing.Point(230, 357);
            this.pbLeft.Name = "pbLeft";
            this.pbLeft.Size = new System.Drawing.Size(36, 56);
            this.pbLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLeft.TabIndex = 15;
            this.pbLeft.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.pbAutoPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShuffle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoth)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnProgress.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft)).EndInit();
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
    }
}
