namespace PTLEnglish.GUI.Gravity
{
    partial class State
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
            this.pnState = new System.Windows.Forms.Panel();
            this.pnHorizontal = new System.Windows.Forms.Panel();
            this.pnHorizontalRun = new System.Windows.Forms.Panel();
            this.lbCommand = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.timerPictureBox = new System.Windows.Forms.Timer(this.components);
            this.timerRun = new System.Windows.Forms.Timer(this.components);
            this.pnState.SuspendLayout();
            this.pnHorizontal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnState
            // 
            this.pnState.BackColor = System.Drawing.Color.Black;
            this.pnState.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnState.Controls.Add(this.pnHorizontal);
            this.pnState.Controls.Add(this.lbCommand);
            this.pnState.Controls.Add(this.label1);
            this.pnState.Controls.Add(this.lbScore);
            this.pnState.Controls.Add(this.tbAnswer);
            this.pnState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnState.Location = new System.Drawing.Point(0, 0);
            this.pnState.Name = "pnState";
            this.pnState.Size = new System.Drawing.Size(697, 561);
            this.pnState.TabIndex = 0;
            // 
            // pnHorizontal
            // 
            this.pnHorizontal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnHorizontal.Controls.Add(this.pnHorizontalRun);
            this.pnHorizontal.Location = new System.Drawing.Point(134, 539);
            this.pnHorizontal.Name = "pnHorizontal";
            this.pnHorizontal.Size = new System.Drawing.Size(419, 3);
            this.pnHorizontal.TabIndex = 12;
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
            // lbCommand
            // 
            this.lbCommand.AutoSize = true;
            this.lbCommand.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCommand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.lbCommand.Location = new System.Drawing.Point(131, 544);
            this.lbCommand.Name = "lbCommand";
            this.lbCommand.Size = new System.Drawing.Size(109, 17);
            this.lbCommand.TabIndex = 11;
            this.lbCommand.Text = "TYPE ANSWER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Score";
            // 
            // lbScore
            // 
            this.lbScore.Font = new System.Drawing.Font("Segoe UI", 41.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.ForeColor = System.Drawing.Color.White;
            this.lbScore.Location = new System.Drawing.Point(3, 28);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(100, 73);
            this.lbScore.TabIndex = 1;
            this.lbScore.Text = "0";
            // 
            // tbAnswer
            // 
            this.tbAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAnswer.Font = new System.Drawing.Font("Cambria", 22.25F);
            this.tbAnswer.Location = new System.Drawing.Point(134, 493);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(419, 42);
            this.tbAnswer.TabIndex = 0;
            this.tbAnswer.Click += new System.EventHandler(this.tbAnswer_Click);
            this.tbAnswer.TextChanged += new System.EventHandler(this.tbAnswer_TextChanged);
            this.tbAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAnswer_KeyPress);
            // 
            // timerPictureBox
            // 
            this.timerPictureBox.Tick += new System.EventHandler(this.timerPictureBox_Tick);
            // 
            // timerRun
            // 
            this.timerRun.Interval = 300;
            this.timerRun.Tick += new System.EventHandler(this.timerRun_Tick);
            // 
            // State
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnState);
            this.Name = "State";
            this.Size = new System.Drawing.Size(697, 561);
            this.Load += new System.EventHandler(this.State_Load);
            this.pnState.ResumeLayout(false);
            this.pnState.PerformLayout();
            this.pnHorizontal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnState;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.Timer timerPictureBox;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCommand;
        private System.Windows.Forms.Panel pnHorizontal;
        private System.Windows.Forms.Panel pnHorizontalRun;
        private System.Windows.Forms.Timer timerRun;
    }
}
