namespace PTLEnglish.GUI.Learn
{
	partial class UC_Learn_Choose
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Learn_Choose));
			this.lbl_Key = new System.Windows.Forms.Label();
			this.pic_Next = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pic_Next)).BeginInit();
			this.SuspendLayout();
			// 
			// lbl_Key
			// 
			this.lbl_Key.AutoSize = true;
			this.lbl_Key.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Key.Location = new System.Drawing.Point(11, 9);
			this.lbl_Key.Name = "lbl_Key";
			this.lbl_Key.Size = new System.Drawing.Size(70, 26);
			this.lbl_Key.TabIndex = 1;
			this.lbl_Key.Text = "label1";
			// 
			// pic_Next
			// 
			this.pic_Next.BackColor = System.Drawing.Color.Transparent;
			this.pic_Next.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pic_Next.Image = ((System.Drawing.Image)(resources.GetObject("pic_Next.Image")));
			this.pic_Next.Location = new System.Drawing.Point(508, 75);
			this.pic_Next.Name = "pic_Next";
			this.pic_Next.Size = new System.Drawing.Size(49, 61);
			this.pic_Next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_Next.TabIndex = 23;
			this.pic_Next.TabStop = false;
			this.pic_Next.Click += new System.EventHandler(this.pic_Next_Click);
			// 
			// UC_Learn_Choose
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Controls.Add(this.pic_Next);
			this.Controls.Add(this.lbl_Key);
			this.Name = "UC_Learn_Choose";
			this.Size = new System.Drawing.Size(548, 184);
			this.Load += new System.EventHandler(this.UC_Learn_Choose_Load);
			((System.ComponentModel.ISupportInitialize)(this.pic_Next)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lbl_Key;
		private System.Windows.Forms.PictureBox pic_Next;
	}
}
