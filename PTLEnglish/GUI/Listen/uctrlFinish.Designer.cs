namespace PTLEnglish.GUI.Listen
{
    partial class uctrlFinish
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
            this.lbMean = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartOver = new System.Windows.Forms.Button();
            this.pnHorizontal = new System.Windows.Forms.Panel();
            this.pnHorizontalRun = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnHorizontal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMean
            // 
            this.lbMean.AutoSize = true;
            this.lbMean.Font = new System.Drawing.Font("Cambria", 24.25F, System.Drawing.FontStyle.Bold);
            this.lbMean.ForeColor = System.Drawing.Color.Red;
            this.lbMean.Location = new System.Drawing.Point(186, 5);
            this.lbMean.Name = "lbMean";
            this.lbMean.Size = new System.Drawing.Size(274, 38);
            this.lbMean.TabIndex = 14;
            this.lbMean.Text = "Congratulation !!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(4, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "Finally You\'ve Finished this lesson";
            // 
            // btnStartOver
            // 
            this.btnStartOver.BackColor = System.Drawing.Color.SeaGreen;
            this.btnStartOver.FlatAppearance.BorderSize = 0;
            this.btnStartOver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartOver.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.btnStartOver.ForeColor = System.Drawing.Color.White;
            this.btnStartOver.Location = new System.Drawing.Point(448, 50);
            this.btnStartOver.Name = "btnStartOver";
            this.btnStartOver.Size = new System.Drawing.Size(176, 43);
            this.btnStartOver.TabIndex = 16;
            this.btnStartOver.Text = "Start over";
            this.btnStartOver.UseVisualStyleBackColor = false;
            this.btnStartOver.MouseLeave += new System.EventHandler(this.btnStartOver_MouseLeave);
            this.btnStartOver.MouseHover += new System.EventHandler(this.btnStartOver_MouseHover);
            // 
            // pnHorizontal
            // 
            this.pnHorizontal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnHorizontal.Controls.Add(this.pnHorizontalRun);
            this.pnHorizontal.Location = new System.Drawing.Point(89, 106);
            this.pnHorizontal.Name = "pnHorizontal";
            this.pnHorizontal.Size = new System.Drawing.Size(490, 3);
            this.pnHorizontal.TabIndex = 17;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(10, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Missed In Your Lesson";
            // 
            // uctrlFinish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnHorizontal);
            this.Controls.Add(this.btnStartOver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMean);
            this.Name = "uctrlFinish";
            this.Size = new System.Drawing.Size(640, 145);
            this.pnHorizontal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMean;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnHorizontal;
        private System.Windows.Forms.Panel pnHorizontalRun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStartOver;
    }
}
