namespace PTLEnglish.GUI.Learn
{
	partial class UI_Learn
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Pronun = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Mean = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Spell)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Word
            // 
            this.lbl_Word.Font = new System.Drawing.Font("Microsoft YaHei Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Word.Location = new System.Drawing.Point(24, 10);
            this.lbl_Word.Name = "lbl_Word";
            this.lbl_Word.Size = new System.Drawing.Size(250, 40);
            this.lbl_Word.TabIndex = 0;
            this.lbl_Word.Text = "R&D department";
            this.lbl_Word.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_Spell
            // 
            this.pic_Spell.Image = global::PTLEnglish.Properties.Resources.volume_icon;
            this.pic_Spell.Location = new System.Drawing.Point(312, 10);
            this.pic_Spell.Name = "pic_Spell";
            this.pic_Spell.Size = new System.Drawing.Size(41, 40);
            this.pic_Spell.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Spell.TabIndex = 1;
            this.pic_Spell.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pronunciation: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Pronun
            // 
            this.lbl_Pronun.Font = new System.Drawing.Font("Microsoft YaHei Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pronun.Location = new System.Drawing.Point(150, 50);
            this.lbl_Pronun.Name = "lbl_Pronun";
            this.lbl_Pronun.Size = new System.Drawing.Size(204, 63);
            this.lbl_Pronun.TabIndex = 3;
            this.lbl_Pronun.Text = "/ɑːr ænd diː dɪˈpɑːrtmənt/";
            this.lbl_Pronun.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei Light", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Meaning:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Mean
            // 
            this.lbl_Mean.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mean.Location = new System.Drawing.Point(150, 122);
            this.lbl_Mean.Name = "lbl_Mean";
            this.lbl_Mean.Size = new System.Drawing.Size(204, 60);
            this.lbl_Mean.TabIndex = 5;
            this.lbl_Mean.Text = "Phòng nghiên cứu và phát triển thị trường";
            this.lbl_Mean.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UI_Learn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_Mean);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Pronun);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_Spell);
            this.Controls.Add(this.lbl_Word);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UI_Learn";
            this.Size = new System.Drawing.Size(691, 430);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Spell)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lbl_Word;
		private System.Windows.Forms.PictureBox pic_Spell;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbl_Pronun;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lbl_Mean;
	}
}
