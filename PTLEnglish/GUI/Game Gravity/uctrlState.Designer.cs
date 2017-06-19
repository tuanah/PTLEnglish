namespace PTLEnglish.GUI.Game_Gravity
{
    partial class uctrlState
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            this.timerPictureBox = new System.Windows.Forms.Timer(this.components);
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.pnHorizontal = new System.Windows.Forms.Panel();
            this.lbCommand = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lbEnglish = new System.Windows.Forms.Label();
            this.lbVietnamese = new System.Windows.Forms.Label();
            this.lbPrompt = new System.Windows.Forms.Label();
            this.lbCorrectAnswer = new System.Windows.Forms.Label();
            this.lbDontKnow = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Score";
            // 
            // lbScore
            // 
            this.lbScore.Font = new System.Drawing.Font("Segoe UI", 28F);
            this.lbScore.ForeColor = System.Drawing.Color.White;
            this.lbScore.Location = new System.Drawing.Point(5, 19);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(65, 54);
            this.lbScore.TabIndex = 3;
            this.lbScore.Text = "0";
            // 
            // timerPictureBox
            // 
            this.timerPictureBox.Interval = 60;
            this.timerPictureBox.Tick += new System.EventHandler(this.timerPictureBox_Tick);
            // 
            // tbAnswer
            // 
            this.tbAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAnswer.Font = new System.Drawing.Font("Cambria", 22.25F);
            this.tbAnswer.Location = new System.Drawing.Point(145, 494);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(419, 35);
            this.tbAnswer.TabIndex = 5;
            this.tbAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAnswer_KeyPress);
            // 
            // pnHorizontal
            // 
            this.pnHorizontal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnHorizontal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnHorizontal.Location = new System.Drawing.Point(145, 532);
            this.pnHorizontal.Name = "pnHorizontal";
            this.pnHorizontal.Size = new System.Drawing.Size(419, 2);
            this.pnHorizontal.TabIndex = 6;
            // 
            // lbCommand
            // 
            this.lbCommand.AutoSize = true;
            this.lbCommand.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCommand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lbCommand.Location = new System.Drawing.Point(143, 536);
            this.lbCommand.Name = "lbCommand";
            this.lbCommand.Size = new System.Drawing.Size(162, 19);
            this.lbCommand.TabIndex = 7;
            this.lbCommand.Text = "TYPE YOUR ANSWER\r\n";
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(245, 183);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(207, 138);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 8;
            this.pbImage.TabStop = false;
            this.pbImage.Visible = false;
            // 
            // lbEnglish
            // 
            this.lbEnglish.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.lbEnglish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.lbEnglish.Location = new System.Drawing.Point(179, 363);
            this.lbEnglish.Name = "lbEnglish";
            this.lbEnglish.Size = new System.Drawing.Size(334, 26);
            this.lbEnglish.TabIndex = 9;
            this.lbEnglish.Text = "English";
            this.lbEnglish.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbEnglish.Visible = false;
            // 
            // lbVietnamese
            // 
            this.lbVietnamese.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.lbVietnamese.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lbVietnamese.Location = new System.Drawing.Point(146, 147);
            this.lbVietnamese.Name = "lbVietnamese";
            this.lbVietnamese.Size = new System.Drawing.Size(406, 26);
            this.lbVietnamese.TabIndex = 10;
            this.lbVietnamese.Text = "VietNamese";
            this.lbVietnamese.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbVietnamese.Visible = false;
            // 
            // lbPrompt
            // 
            this.lbPrompt.AutoSize = true;
            this.lbPrompt.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.lbPrompt.ForeColor = System.Drawing.Color.White;
            this.lbPrompt.Location = new System.Drawing.Point(311, 121);
            this.lbPrompt.Name = "lbPrompt";
            this.lbPrompt.Size = new System.Drawing.Size(75, 19);
            this.lbPrompt.TabIndex = 12;
            this.lbPrompt.Text = "PROMPT";
            this.lbPrompt.Visible = false;
            // 
            // lbCorrectAnswer
            // 
            this.lbCorrectAnswer.AutoSize = true;
            this.lbCorrectAnswer.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.lbCorrectAnswer.ForeColor = System.Drawing.Color.White;
            this.lbCorrectAnswer.Location = new System.Drawing.Point(273, 334);
            this.lbCorrectAnswer.Name = "lbCorrectAnswer";
            this.lbCorrectAnswer.Size = new System.Drawing.Size(147, 19);
            this.lbCorrectAnswer.TabIndex = 13;
            this.lbCorrectAnswer.Text = "CORRECT ANSWER";
            this.lbCorrectAnswer.Visible = false;
            // 
            // lbDontKnow
            // 
            this.lbDontKnow.AutoSize = true;
            this.lbDontKnow.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.lbDontKnow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lbDontKnow.Location = new System.Drawing.Point(587, 6);
            this.lbDontKnow.Name = "lbDontKnow";
            this.lbDontKnow.Size = new System.Drawing.Size(103, 19);
            this.lbDontKnow.TabIndex = 14;
            this.lbDontKnow.Text = "Don\'t Knows";
            this.lbDontKnow.Click += new System.EventHandler(this.lbDontKnow_Click);
            // 
            // uctrlState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.Controls.Add(this.lbDontKnow);
            this.Controls.Add(this.lbCorrectAnswer);
            this.Controls.Add(this.lbPrompt);
            this.Controls.Add(this.lbVietnamese);
            this.Controls.Add(this.lbEnglish);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.lbCommand);
            this.Controls.Add(this.pnHorizontal);
            this.Controls.Add(this.tbAnswer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbScore);
            this.Name = "uctrlState";
            this.Size = new System.Drawing.Size(697, 561);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Timer timerPictureBox;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.Panel pnHorizontal;
        private System.Windows.Forms.Label lbCommand;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lbEnglish;
        private System.Windows.Forms.Label lbVietnamese;
        private System.Windows.Forms.Label lbPrompt;
        private System.Windows.Forms.Label lbCorrectAnswer;
        private System.Windows.Forms.Label lbDontKnow;
    }
}
