﻿namespace PTLEnglish.GUI.Listen
{
    partial class uctrlMain
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
            this.fpnMain = new System.Windows.Forms.FlowLayoutPanel();
            this.pnMainListen = new System.Windows.Forms.Panel();
            this.pnProgress = new System.Windows.Forms.Panel();
            this.fpnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // fpnMain
            // 
            this.fpnMain.AutoScroll = true;
            this.fpnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(110)))), ((int)(((byte)(109)))));
            this.fpnMain.Controls.Add(this.pnMainListen);
            this.fpnMain.Controls.Add(this.pnProgress);
            this.fpnMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fpnMain.Location = new System.Drawing.Point(26, 5);
            this.fpnMain.Name = "fpnMain";
            this.fpnMain.Size = new System.Drawing.Size(658, 544);
            this.fpnMain.TabIndex = 1;
            // 
            // pnMainListen
            // 
            this.pnMainListen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(110)))), ((int)(((byte)(109)))));
            this.pnMainListen.Location = new System.Drawing.Point(3, 3);
            this.pnMainListen.Name = "pnMainListen";
            this.pnMainListen.Size = new System.Drawing.Size(651, 397);
            this.pnMainListen.TabIndex = 9;
            // 
            // pnProgress
            // 
            this.pnProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(110)))), ((int)(((byte)(109)))));
            this.pnProgress.Location = new System.Drawing.Point(3, 406);
            this.pnProgress.Name = "pnProgress";
            this.pnProgress.Size = new System.Drawing.Size(651, 134);
            this.pnProgress.TabIndex = 8;
            // 
            // uctrlMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fpnMain);
            this.Name = "uctrlMain";
            this.Size = new System.Drawing.Size(697, 561);
            this.fpnMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel fpnMain;
        private System.Windows.Forms.Panel pnProgress;
        private System.Windows.Forms.Panel pnMainListen;
    }
}