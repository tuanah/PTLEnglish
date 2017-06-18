namespace PTLEnglish.GUI.Learn
{
	partial class UC_Learn
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Learn));
			this.lbl_Mean = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lbl_Pronun = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pic_Spell = new System.Windows.Forms.PictureBox();
			this.lbl_Word = new System.Windows.Forms.Label();
			this.pic = new System.Windows.Forms.PictureBox();
			this.pic_Next = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pic_Spell)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_Next)).BeginInit();
			this.SuspendLayout();
			// 
			// lbl_Mean
			// 
			this.lbl_Mean.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Mean.Location = new System.Drawing.Point(153, 117);
			this.lbl_Mean.Name = "lbl_Mean";
			this.lbl_Mean.Size = new System.Drawing.Size(204, 60);
			this.lbl_Mean.TabIndex = 11;
			this.lbl_Mean.Text = "Phòng nghiên cứu và phát triển thị trường";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(29, 112);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(118, 30);
			this.label3.TabIndex = 10;
			this.label3.Text = "Meaning:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_Pronun
			// 
			this.lbl_Pronun.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Pronun.Location = new System.Drawing.Point(153, 47);
			this.lbl_Pronun.Name = "lbl_Pronun";
			this.lbl_Pronun.Size = new System.Drawing.Size(204, 63);
			this.lbl_Pronun.TabIndex = 9;
			this.lbl_Pronun.Text = "/ɑːr ænd diː dɪˈpɑːrtmənt/";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(7, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(140, 40);
			this.label1.TabIndex = 8;
			this.label1.Text = "Pronunciation: ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pic_Spell
			// 
			this.pic_Spell.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pic_Spell.Image = global::PTLEnglish.Properties.Resources.volume_icon;
			this.pic_Spell.Location = new System.Drawing.Point(11, 0);
			this.pic_Spell.Name = "pic_Spell";
			this.pic_Spell.Size = new System.Drawing.Size(41, 40);
			this.pic_Spell.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pic_Spell.TabIndex = 7;
			this.pic_Spell.TabStop = false;
			this.pic_Spell.Click += new System.EventHandler(this.pic_Spell_Click);
			// 
			// lbl_Word
			// 
			this.lbl_Word.Font = new System.Drawing.Font("Microsoft YaHei Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Word.Location = new System.Drawing.Point(58, 0);
			this.lbl_Word.Name = "lbl_Word";
			this.lbl_Word.Size = new System.Drawing.Size(250, 40);
			this.lbl_Word.TabIndex = 6;
			this.lbl_Word.Text = "R&D department";
			this.lbl_Word.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pic
			// 
			this.pic.ErrorImage = global::PTLEnglish.Properties.Resources.error_image;
			this.pic.Location = new System.Drawing.Point(364, 13);
			this.pic.Name = "pic";
			this.pic.Size = new System.Drawing.Size(168, 159);
			this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pic.TabIndex = 12;
			this.pic.TabStop = false;
			// 
			// pic_Next
			// 
			this.pic_Next.BackColor = System.Drawing.Color.Transparent;
			this.pic_Next.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pic_Next.Image = ((System.Drawing.Image)(resources.GetObject("pic_Next.Image")));
			this.pic_Next.Location = new System.Drawing.Point(534, 65);
			this.pic_Next.Name = "pic_Next";
			this.pic_Next.Size = new System.Drawing.Size(43, 61);
			this.pic_Next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_Next.TabIndex = 23;
			this.pic_Next.TabStop = false;
			this.pic_Next.Click += new System.EventHandler(this.pic_Next_Click);
			// 
			// UC_Learn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Controls.Add(this.pic_Next);
			this.Controls.Add(this.pic);
			this.Controls.Add(this.lbl_Mean);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lbl_Pronun);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pic_Spell);
			this.Controls.Add(this.lbl_Word);
			this.Name = "UC_Learn";
			this.Size = new System.Drawing.Size(571, 184);
			this.Load += new System.EventHandler(this.UC_Learn_0_Load);
			((System.ComponentModel.ISupportInitialize)(this.pic_Spell)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_Next)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lbl_Mean;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lbl_Pronun;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pic_Spell;
		private System.Windows.Forms.Label lbl_Word;
		private System.Windows.Forms.PictureBox pic;
		private System.Windows.Forms.PictureBox pic_Next;
	}
}
