namespace PTLEnglish.GUI.Learn
{
	partial class UC_Learn_Type
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Learn_Type));
			this.lbl_Word = new System.Windows.Forms.Label();
			this.lbl_Pronun = new System.Windows.Forms.Label();
			this.txt_Ans = new System.Windows.Forms.TextBox();
			this.pnl_Underline = new System.Windows.Forms.Panel();
			this.lbl_Type = new System.Windows.Forms.Label();
			this.lbl_Correct = new System.Windows.Forms.Label();
			this.lbl_Mean = new System.Windows.Forms.Label();
			this.lbl_Wrong = new System.Windows.Forms.Label();
			this.pic_Next = new System.Windows.Forms.PictureBox();
			this.pic_Check = new System.Windows.Forms.PictureBox();
			this.pic = new System.Windows.Forms.PictureBox();
			this.pic_Spell = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pic_Next)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_Check)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_Spell)).BeginInit();
			this.SuspendLayout();
			// 
			// lbl_Word
			// 
			this.lbl_Word.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Word.Location = new System.Drawing.Point(198, 8);
			this.lbl_Word.Name = "lbl_Word";
			this.lbl_Word.Size = new System.Drawing.Size(250, 40);
			this.lbl_Word.TabIndex = 7;
			this.lbl_Word.Text = "R&D department";
			this.lbl_Word.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Pronun
			// 
			this.lbl_Pronun.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Pronun.Location = new System.Drawing.Point(199, 48);
			this.lbl_Pronun.Name = "lbl_Pronun";
			this.lbl_Pronun.Size = new System.Drawing.Size(234, 31);
			this.lbl_Pronun.TabIndex = 14;
			this.lbl_Pronun.Text = "/ɑːr ænd diː dɪˈpɑːrtmənt/";
			// 
			// txt_Ans
			// 
			this.txt_Ans.AcceptsReturn = true;
			this.txt_Ans.BackColor = System.Drawing.SystemColors.Window;
			this.txt_Ans.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txt_Ans.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Ans.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txt_Ans.Location = new System.Drawing.Point(203, 82);
			this.txt_Ans.Name = "txt_Ans";
			this.txt_Ans.Size = new System.Drawing.Size(287, 24);
			this.txt_Ans.TabIndex = 0;
			this.txt_Ans.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Ans_KeyPress);
			// 
			// pnl_Underline
			// 
			this.pnl_Underline.BackColor = System.Drawing.Color.Gold;
			this.pnl_Underline.Location = new System.Drawing.Point(203, 107);
			this.pnl_Underline.Name = "pnl_Underline";
			this.pnl_Underline.Size = new System.Drawing.Size(287, 2);
			this.pnl_Underline.TabIndex = 15;
			// 
			// lbl_Type
			// 
			this.lbl_Type.AutoSize = true;
			this.lbl_Type.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Type.Location = new System.Drawing.Point(200, 110);
			this.lbl_Type.Name = "lbl_Type";
			this.lbl_Type.Size = new System.Drawing.Size(118, 14);
			this.lbl_Type.TabIndex = 16;
			this.lbl_Type.Text = "TYPE THE VIETNAMESE";
			// 
			// lbl_Correct
			// 
			this.lbl_Correct.AutoSize = true;
			this.lbl_Correct.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Correct.ForeColor = System.Drawing.Color.Green;
			this.lbl_Correct.Location = new System.Drawing.Point(199, 124);
			this.lbl_Correct.Name = "lbl_Correct";
			this.lbl_Correct.Size = new System.Drawing.Size(61, 21);
			this.lbl_Correct.TabIndex = 18;
			this.lbl_Correct.Text = "Correct";
			this.lbl_Correct.Visible = false;
			// 
			// lbl_Mean
			// 
			this.lbl_Mean.AutoSize = true;
			this.lbl_Mean.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Mean.ForeColor = System.Drawing.Color.Green;
			this.lbl_Mean.Location = new System.Drawing.Point(199, 145);
			this.lbl_Mean.Name = "lbl_Mean";
			this.lbl_Mean.Size = new System.Drawing.Size(334, 21);
			this.lbl_Mean.TabIndex = 20;
			this.lbl_Mean.Text = "Phòng nghiên cứu và phát triển thị trường";
			this.lbl_Mean.Visible = false;
			// 
			// lbl_Wrong
			// 
			this.lbl_Wrong.AutoSize = true;
			this.lbl_Wrong.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Wrong.ForeColor = System.Drawing.Color.DarkGray;
			this.lbl_Wrong.Location = new System.Drawing.Point(202, 124);
			this.lbl_Wrong.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.lbl_Wrong.Name = "lbl_Wrong";
			this.lbl_Wrong.Size = new System.Drawing.Size(214, 21);
			this.lbl_Wrong.TabIndex = 21;
			this.lbl_Wrong.Text = "Wrong. The correct answer is:";
			this.lbl_Wrong.Visible = false;
			// 
			// pic_Next
			// 
			this.pic_Next.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pic_Next.Image = ((System.Drawing.Image)(resources.GetObject("pic_Next.Image")));
			this.pic_Next.Location = new System.Drawing.Point(538, 63);
			this.pic_Next.Name = "pic_Next";
			this.pic_Next.Size = new System.Drawing.Size(49, 61);
			this.pic_Next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_Next.TabIndex = 22;
			this.pic_Next.TabStop = false;
			this.pic_Next.Click += new System.EventHandler(this.pic_Next_Click_1);
			// 
			// pic_Check
			// 
			this.pic_Check.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pic_Check.Image = global::PTLEnglish.Properties.Resources._1497710814_Tick;
			this.pic_Check.Location = new System.Drawing.Point(497, 73);
			this.pic_Check.Name = "pic_Check";
			this.pic_Check.Size = new System.Drawing.Size(35, 36);
			this.pic_Check.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pic_Check.TabIndex = 19;
			this.pic_Check.TabStop = false;
			this.pic_Check.Click += new System.EventHandler(this.pic_Check_Click);
			// 
			// pic
			// 
			this.pic.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.pic.ErrorImage = global::PTLEnglish.Properties.Resources.error_image;
			this.pic.Location = new System.Drawing.Point(14, 8);
			this.pic.Name = "pic";
			this.pic.Size = new System.Drawing.Size(168, 159);
			this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pic.TabIndex = 13;
			this.pic.TabStop = false;
			// 
			// pic_Spell
			// 
			this.pic_Spell.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pic_Spell.Image = global::PTLEnglish.Properties.Resources.volume_icon;
			this.pic_Spell.Location = new System.Drawing.Point(491, 8);
			this.pic_Spell.Name = "pic_Spell";
			this.pic_Spell.Size = new System.Drawing.Size(41, 40);
			this.pic_Spell.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pic_Spell.TabIndex = 8;
			this.pic_Spell.TabStop = false;
			this.pic_Spell.Click += new System.EventHandler(this.pic_Spell_Click);
			// 
			// UC_Learn_Type
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Controls.Add(this.pic_Next);
			this.Controls.Add(this.lbl_Wrong);
			this.Controls.Add(this.lbl_Mean);
			this.Controls.Add(this.pic_Check);
			this.Controls.Add(this.lbl_Correct);
			this.Controls.Add(this.lbl_Type);
			this.Controls.Add(this.pnl_Underline);
			this.Controls.Add(this.txt_Ans);
			this.Controls.Add(this.lbl_Pronun);
			this.Controls.Add(this.pic);
			this.Controls.Add(this.pic_Spell);
			this.Controls.Add(this.lbl_Word);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "UC_Learn_Type";
			this.Size = new System.Drawing.Size(576, 178);
			this.Load += new System.EventHandler(this.UC_Learn_1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pic_Next)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_Check)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_Spell)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_Word;
		private System.Windows.Forms.PictureBox pic_Spell;
		private System.Windows.Forms.PictureBox pic;
		private System.Windows.Forms.Label lbl_Pronun;
		private System.Windows.Forms.TextBox txt_Ans;
		private System.Windows.Forms.Panel pnl_Underline;
		private System.Windows.Forms.Label lbl_Type;
		private System.Windows.Forms.Label lbl_Correct;
		private System.Windows.Forms.PictureBox pic_Check;
		private System.Windows.Forms.Label lbl_Mean;
		private System.Windows.Forms.Label lbl_Wrong;
		private System.Windows.Forms.PictureBox pic_Next;
	}
}
