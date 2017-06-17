namespace PTLEnglish.GUI.Listen
{
    partial class uctrlListen3
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
            this.pnMain = new System.Windows.Forms.Panel();
            this.lbCommand = new System.Windows.Forms.Label();
            this.pnHorizontal = new System.Windows.Forms.Panel();
            this.pnHorizontalRun = new System.Windows.Forms.Panel();
            this.tbText = new System.Windows.Forms.TextBox();
            this.pbSpeakSlowly = new System.Windows.Forms.PictureBox();
            this.pbSpeakNormal = new System.Windows.Forms.PictureBox();
            this.lbWrong = new System.Windows.Forms.Label();
            this.pnMain.SuspendLayout();
            this.pnHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpeakSlowly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpeakNormal)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.White;
            this.pnMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnMain.Controls.Add(this.lbWrong);
            this.pnMain.Controls.Add(this.lbCommand);
            this.pnMain.Controls.Add(this.pnHorizontal);
            this.pnMain.Controls.Add(this.tbText);
            this.pnMain.Controls.Add(this.pbSpeakSlowly);
            this.pnMain.Controls.Add(this.pbSpeakNormal);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(489, 226);
            this.pnMain.TabIndex = 0;
            // 
            // lbCommand
            // 
            this.lbCommand.AutoSize = true;
            this.lbCommand.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCommand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.lbCommand.Location = new System.Drawing.Point(46, 172);
            this.lbCommand.Name = "lbCommand";
            this.lbCommand.Size = new System.Drawing.Size(148, 17);
            this.lbCommand.TabIndex = 16;
            this.lbCommand.Text = "TYPE THE MEANING";
            // 
            // pnHorizontal
            // 
            this.pnHorizontal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnHorizontal.Controls.Add(this.pnHorizontalRun);
            this.pnHorizontal.Location = new System.Drawing.Point(49, 165);
            this.pnHorizontal.Name = "pnHorizontal";
            this.pnHorizontal.Size = new System.Drawing.Size(391, 3);
            this.pnHorizontal.TabIndex = 14;
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
            this.tbText.Location = new System.Drawing.Point(47, 130);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(393, 31);
            this.tbText.TabIndex = 15;
            this.tbText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbText_KeyPress);
            // 
            // pbSpeakSlowly
            // 
            this.pbSpeakSlowly.Image = global::PTLEnglish.Properties.Resources.normal;
            this.pbSpeakSlowly.Location = new System.Drawing.Point(277, 25);
            this.pbSpeakSlowly.Name = "pbSpeakSlowly";
            this.pbSpeakSlowly.Size = new System.Drawing.Size(51, 51);
            this.pbSpeakSlowly.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSpeakSlowly.TabIndex = 13;
            this.pbSpeakSlowly.TabStop = false;
            this.pbSpeakSlowly.Click += new System.EventHandler(this.pbSpeakSlowly_Click);
            this.pbSpeakSlowly.MouseLeave += new System.EventHandler(this.pbSpeakSlowly_MouseLeave);
            this.pbSpeakSlowly.MouseHover += new System.EventHandler(this.pbSpeakSlowly_MouseHover);
            // 
            // pbSpeakNormal
            // 
            this.pbSpeakNormal.Image = global::PTLEnglish.Properties.Resources.normal;
            this.pbSpeakNormal.Location = new System.Drawing.Point(152, 25);
            this.pbSpeakNormal.Name = "pbSpeakNormal";
            this.pbSpeakNormal.Size = new System.Drawing.Size(51, 51);
            this.pbSpeakNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSpeakNormal.TabIndex = 12;
            this.pbSpeakNormal.TabStop = false;
            this.pbSpeakNormal.Click += new System.EventHandler(this.pbSpeakNormal_Click);
            this.pbSpeakNormal.MouseLeave += new System.EventHandler(this.pbSpeakNormal_MouseLeave);
            this.pbSpeakNormal.MouseHover += new System.EventHandler(this.pbSpeakNormal_MouseHover);
            // 
            // lbWrong
            // 
            this.lbWrong.Font = new System.Drawing.Font("Cambria", 18.75F, System.Drawing.FontStyle.Bold);
            this.lbWrong.Location = new System.Drawing.Point(3, 95);
            this.lbWrong.Name = "lbWrong";
            this.lbWrong.Size = new System.Drawing.Size(483, 32);
            this.lbWrong.TabIndex = 17;
            this.lbWrong.Text = "Vietnamese\r\n";
            this.lbWrong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbWrong.Visible = false;
            // 
            // uctrlListen3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnMain);
            this.Name = "uctrlListen3";
            this.Size = new System.Drawing.Size(489, 226);
            this.Load += new System.EventHandler(this.uctrlListen3_Load);
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            this.pnHorizontal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSpeakSlowly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpeakNormal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.PictureBox pbSpeakSlowly;
        private System.Windows.Forms.PictureBox pbSpeakNormal;
        private System.Windows.Forms.Label lbCommand;
        private System.Windows.Forms.Panel pnHorizontal;
        private System.Windows.Forms.Panel pnHorizontalRun;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Label lbWrong;
    }
}
