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
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.timerPictureBox = new System.Windows.Forms.Timer(this.components);
            this.lbScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnState.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnState
            // 
            this.pnState.BackColor = System.Drawing.Color.Black;
            this.pnState.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnState.Controls.Add(this.label1);
            this.pnState.Controls.Add(this.lbScore);
            this.pnState.Controls.Add(this.tbAnswer);
            this.pnState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnState.Location = new System.Drawing.Point(0, 0);
            this.pnState.Name = "pnState";
            this.pnState.Size = new System.Drawing.Size(697, 561);
            this.pnState.TabIndex = 0;
            // 
            // tbAnswer
            // 
            this.tbAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAnswer.Font = new System.Drawing.Font("Cambria", 22.25F);
            this.tbAnswer.Location = new System.Drawing.Point(136, 497);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(419, 42);
            this.tbAnswer.TabIndex = 0;
            this.tbAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAnswer_KeyPress);
            // 
            // timerPictureBox
            // 
            this.timerPictureBox.Tick += new System.EventHandler(this.timerPictureBox_Tick);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnState;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.Timer timerPictureBox;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label label1;
    }
}
