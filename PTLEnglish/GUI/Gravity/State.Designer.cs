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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(State));
            this.pnState = new System.Windows.Forms.Panel();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.timerPictureBox = new System.Windows.Forms.Timer(this.components);
            this.pnState.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnState
            // 
            this.pnState.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnState.BackgroundImage")));
            this.pnState.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            // 
            // timerPictureBox
            // 
            this.timerPictureBox.Tick += new System.EventHandler(this.timerPictureBox_Tick);
            // 
            // State
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnState);
            this.Name = "State";
            this.Size = new System.Drawing.Size(697, 561);
            this.pnState.ResumeLayout(false);
            this.pnState.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnState;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.Timer timerPictureBox;
    }
}
