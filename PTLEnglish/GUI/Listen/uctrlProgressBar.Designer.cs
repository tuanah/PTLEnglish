namespace PTLEnglish.GUI.Listen
{
    partial class uctrlProgressBar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnWrong = new System.Windows.Forms.Panel();
            this.pnWrongRun = new System.Windows.Forms.Panel();
            this.lbWrong = new System.Windows.Forms.Label();
            this.pnCorrect = new System.Windows.Forms.Panel();
            this.pnCorrectRun = new System.Windows.Forms.Panel();
            this.lbCorrect = new System.Windows.Forms.Label();
            this.pnProgress = new System.Windows.Forms.Panel();
            this.pnProgressRun = new System.Windows.Forms.Panel();
            this.lbProgress = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnWrong.SuspendLayout();
            this.pnCorrect.SuspendLayout();
            this.pnProgress.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pnWrong);
            this.panel1.Controls.Add(this.lbWrong);
            this.panel1.Controls.Add(this.pnCorrect);
            this.panel1.Controls.Add(this.lbCorrect);
            this.panel1.Controls.Add(this.pnProgress);
            this.panel1.Controls.Add(this.lbProgress);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 134);
            this.panel1.TabIndex = 5;
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
            // uctrlProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "uctrlProgressBar";
            this.Size = new System.Drawing.Size(651, 134);
            this.Load += new System.EventHandler(this.uctrlProgressBar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnWrong.ResumeLayout(false);
            this.pnCorrect.ResumeLayout(false);
            this.pnProgress.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnWrong;
        private System.Windows.Forms.Panel pnWrongRun;
        private System.Windows.Forms.Label lbWrong;
        private System.Windows.Forms.Panel pnCorrect;
        private System.Windows.Forms.Panel pnCorrectRun;
        private System.Windows.Forms.Label lbCorrect;
        private System.Windows.Forms.Panel pnProgress;
        private System.Windows.Forms.Panel pnProgressRun;
        private System.Windows.Forms.Label lbProgress;
    }
}
