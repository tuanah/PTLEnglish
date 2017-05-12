namespace PTLEnglish.GUI.Flash_Card
{
    partial class uctrlFlashCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uctrlFlashCard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbQuickKeyBoard = new System.Windows.Forms.PictureBox();
            this.pbLeft = new System.Windows.Forms.PictureBox();
            this.pbRight = new System.Windows.Forms.PictureBox();
            this.pnProgress = new System.Windows.Forms.Panel();
            this.pnProgressRun = new System.Windows.Forms.Panel();
            this.lbProgress = new System.Windows.Forms.Label();
            this.flipPanel = new PTLEnglish.GUI.Flash_Card.FlipPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSuffle = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnBoth = new System.Windows.Forms.Button();
            this.pnQuickPress = new System.Windows.Forms.Panel();
            this.pbDown = new System.Windows.Forms.PictureBox();
            this.timerPlay = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuickKeyBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRight)).BeginInit();
            this.pnProgress.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDown)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbQuickKeyBoard);
            this.panel1.Controls.Add(this.pbLeft);
            this.panel1.Controls.Add(this.pbRight);
            this.panel1.Location = new System.Drawing.Point(48, 361);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 62);
            this.panel1.TabIndex = 6;
            // 
            // pbQuickKeyBoard
            // 
            this.pbQuickKeyBoard.Image = global::PTLEnglish.Properties.Resources.Keyboard_Filled_50__1_;
            this.pbQuickKeyBoard.Location = new System.Drawing.Point(549, 13);
            this.pbQuickKeyBoard.Name = "pbQuickKeyBoard";
            this.pbQuickKeyBoard.Size = new System.Drawing.Size(45, 42);
            this.pbQuickKeyBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbQuickKeyBoard.TabIndex = 2;
            this.pbQuickKeyBoard.TabStop = false;
            this.pbQuickKeyBoard.Click += new System.EventHandler(this.pbQuickKeyBoard_Click);
            this.pbQuickKeyBoard.MouseLeave += new System.EventHandler(this.pbQuickKeyBoard_MouseLeave);
            this.pbQuickKeyBoard.MouseHover += new System.EventHandler(this.pbQuickKeyBoard_MouseHover);
            // 
            // pbLeft
            // 
            this.pbLeft.BackColor = System.Drawing.Color.Transparent;
            this.pbLeft.Image = global::PTLEnglish.Properties.Resources.Back_100__1_;
            this.pbLeft.Location = new System.Drawing.Point(153, 2);
            this.pbLeft.Name = "pbLeft";
            this.pbLeft.Size = new System.Drawing.Size(48, 59);
            this.pbLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLeft.TabIndex = 1;
            this.pbLeft.TabStop = false;
            this.pbLeft.Click += new System.EventHandler(this.pbLeft_Click);
            this.pbLeft.MouseLeave += new System.EventHandler(this.pbLeft_MouseLeave);
            this.pbLeft.MouseHover += new System.EventHandler(this.pbLeft_MouseHover);
            // 
            // pbRight
            // 
            this.pbRight.BackColor = System.Drawing.Color.Transparent;
            this.pbRight.Image = global::PTLEnglish.Properties.Resources.Back_100__1__opt;
            this.pbRight.Location = new System.Drawing.Point(375, 2);
            this.pbRight.Name = "pbRight";
            this.pbRight.Size = new System.Drawing.Size(48, 59);
            this.pbRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRight.TabIndex = 0;
            this.pbRight.TabStop = false;
            this.pbRight.Click += new System.EventHandler(this.pbRight_Click);
            this.pbRight.MouseLeave += new System.EventHandler(this.pbRight_MouseLeave);
            this.pbRight.MouseHover += new System.EventHandler(this.pbRight_MouseHover);
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
            this.flipPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.flipPanel.Behind = null;
            this.flipPanel.CheckAnimation = true;
            this.flipPanel.Front = null;
            this.flipPanel.H_Behind = null;
            this.flipPanel.H_Front = null;
            this.flipPanel.Location = new System.Drawing.Point(25, 30);
            this.flipPanel.Name = "flipPanel";
            this.flipPanel.Size = new System.Drawing.Size(643, 339);
            this.flipPanel.TabIndex = 10;
            this.flipPanel.TimerInterval = 100;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.pnProgress);
            this.panel3.Controls.Add(this.lbProgress);
            this.panel3.Location = new System.Drawing.Point(25, 416);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(643, 45);
            this.panel3.TabIndex = 11;
            // 
            // btnSuffle
            // 
            this.btnSuffle.BackColor = System.Drawing.Color.White;
            this.btnSuffle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(222)))), ((int)(((byte)(224)))));
            this.btnSuffle.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.btnSuffle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSuffle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuffle.Location = new System.Drawing.Point(233, 485);
            this.btnSuffle.Name = "btnSuffle";
            this.btnSuffle.Size = new System.Drawing.Size(176, 43);
            this.btnSuffle.TabIndex = 17;
            this.btnSuffle.Text = "Shuffle";
            this.btnSuffle.UseVisualStyleBackColor = false;
            this.btnSuffle.Click += new System.EventHandler(this.btnSuffle_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.White;
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(222)))), ((int)(((byte)(224)))));
            this.btnPlay.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.btnPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnPlay.Location = new System.Drawing.Point(25, 485);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(176, 43);
            this.btnPlay.TabIndex = 18;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnBoth
            // 
            this.btnBoth.BackColor = System.Drawing.Color.White;
            this.btnBoth.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(222)))), ((int)(((byte)(224)))));
            this.btnBoth.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.btnBoth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnBoth.Location = new System.Drawing.Point(443, 485);
            this.btnBoth.Name = "btnBoth";
            this.btnBoth.Size = new System.Drawing.Size(176, 43);
            this.btnBoth.TabIndex = 19;
            this.btnBoth.Text = "Both";
            this.btnBoth.UseVisualStyleBackColor = false;
            this.btnBoth.Click += new System.EventHandler(this.btnBoth_Click);
            // 
            // pnQuickPress
            // 
            this.pnQuickPress.Location = new System.Drawing.Point(493, 3);
            this.pnQuickPress.Name = "pnQuickPress";
            this.pnQuickPress.Size = new System.Drawing.Size(174, 353);
            this.pnQuickPress.TabIndex = 20;
            this.pnQuickPress.Visible = false;
            // 
            // pbDown
            // 
            this.pbDown.BackColor = System.Drawing.Color.White;
            this.pbDown.Image = ((System.Drawing.Image)(resources.GetObject("pbDown.Image")));
            this.pbDown.Location = new System.Drawing.Point(601, 355);
            this.pbDown.Name = "pbDown";
            this.pbDown.Size = new System.Drawing.Size(36, 26);
            this.pbDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDown.TabIndex = 4;
            this.pbDown.TabStop = false;
            this.pbDown.Visible = false;
            // 
            // timerPlay
            // 
            this.timerPlay.Interval = 4000;
            this.timerPlay.Tick += new System.EventHandler(this.timerPlay_Tick);
            // 
            // uctrlFlashCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.pbDown);
            this.Controls.Add(this.pnQuickPress);
            this.Controls.Add(this.btnBoth);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnSuffle);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.flipPanel);
            this.Controls.Add(this.panel1);
            this.Name = "uctrlFlashCard";
            this.Size = new System.Drawing.Size(697, 561);
            this.Load += new System.EventHandler(this.uctrlFlashCard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbQuickKeyBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRight)).EndInit();
            this.pnProgress.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbLeft;
        private System.Windows.Forms.PictureBox pbRight;
        private System.Windows.Forms.Panel pnProgress;
        private System.Windows.Forms.Panel pnProgressRun;
        private System.Windows.Forms.Label lbProgress;
        private FlipPanel flipPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBoth;
        private System.Windows.Forms.Button btnSuffle;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.PictureBox pbQuickKeyBoard;
        private System.Windows.Forms.Panel pnQuickPress;
        private System.Windows.Forms.PictureBox pbDown;
        private System.Windows.Forms.Timer timerPlay;
    }
}
