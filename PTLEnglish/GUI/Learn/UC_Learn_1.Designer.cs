namespace PTLEnglish.GUI.Learn
{
	partial class UC_Learn_1
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
			this.lbl_Word = new System.Windows.Forms.Label();
			this.pic_Spell = new System.Windows.Forms.PictureBox();
			this.pic = new System.Windows.Forms.PictureBox();
			this.lbl_Pronun = new System.Windows.Forms.Label();
			this.txt_Ans = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pic_Spell)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
			this.SuspendLayout();
			// 
			// lbl_Word
			// 
			this.lbl_Word.Font = new System.Drawing.Font("Microsoft YaHei Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Word.Location = new System.Drawing.Point(222, 8);
			this.lbl_Word.Name = "lbl_Word";
			this.lbl_Word.Size = new System.Drawing.Size(250, 40);
			this.lbl_Word.TabIndex = 7;
			this.lbl_Word.Text = "R&D department";
			this.lbl_Word.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			// lbl_Pronun
			// 
			this.lbl_Pronun.Font = new System.Drawing.Font("Microsoft JhengHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Pronun.Location = new System.Drawing.Point(268, 48);
			this.lbl_Pronun.Name = "lbl_Pronun";
			this.lbl_Pronun.Size = new System.Drawing.Size(204, 63);
			this.lbl_Pronun.TabIndex = 14;
			this.lbl_Pronun.Text = "/ɑːr ænd diː dɪˈpɑːrtmənt/";
			// 
			// txt_Ans
			// 
			this.txt_Ans.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txt_Ans.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Ans.Location = new System.Drawing.Point(188, 114);
			this.txt_Ans.Name = "txt_Ans";
			this.txt_Ans.Size = new System.Drawing.Size(344, 23);
			this.txt_Ans.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.panel1.Location = new System.Drawing.Point(188, 142);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(344, 2);
			this.panel1.TabIndex = 15;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(189, 151);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(127, 14);
			this.label1.TabIndex = 16;
			this.label1.Text = "TYPE THE VIETNAMESE";
			// 
			// UC_Learn_1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.txt_Ans);
			this.Controls.Add(this.lbl_Pronun);
			this.Controls.Add(this.pic);
			this.Controls.Add(this.pic_Spell);
			this.Controls.Add(this.lbl_Word);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "UC_Learn_1";
			this.Size = new System.Drawing.Size(544, 178);
			((System.ComponentModel.ISupportInitialize)(this.pic_Spell)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_Word;
		private System.Windows.Forms.PictureBox pic_Spell;
		private System.Windows.Forms.PictureBox pic;
		private System.Windows.Forms.Label lbl_Pronun;
		private System.Windows.Forms.TextBox txt_Ans;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
	}
}
