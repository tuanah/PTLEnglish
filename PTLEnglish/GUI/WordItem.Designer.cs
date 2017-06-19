namespace PTLEnglish.GUI
{
	partial class WordItem
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordItem));
			this.tpnl_Content = new System.Windows.Forms.TableLayoutPanel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.tpnl_Right = new System.Windows.Forms.TableLayoutPanel();
			this.pic_Spell = new System.Windows.Forms.PictureBox();
			this.pic_Hard = new System.Windows.Forms.PictureBox();
			this.lbl_Mean = new System.Windows.Forms.Label();
			this.tpnl_Left = new System.Windows.Forms.TableLayoutPanel();
			this.pic_Key = new System.Windows.Forms.PictureBox();
			this.lbl_Key = new System.Windows.Forms.Label();
			this.lbl_Score = new System.Windows.Forms.Label();
			this.tpnl_Content.SuspendLayout();
			this.tpnl_Right.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pic_Spell)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_Hard)).BeginInit();
			this.tpnl_Left.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pic_Key)).BeginInit();
			this.SuspendLayout();
			// 
			// tpnl_Content
			// 
			this.tpnl_Content.BackColor = System.Drawing.Color.Transparent;
			this.tpnl_Content.ColumnCount = 3;
			this.tpnl_Content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.03744F));
			this.tpnl_Content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2F));
			this.tpnl_Content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.96256F));
			this.tpnl_Content.Controls.Add(this.panel5, 1, 0);
			this.tpnl_Content.Controls.Add(this.tpnl_Right, 2, 0);
			this.tpnl_Content.Controls.Add(this.tpnl_Left, 0, 0);
			this.tpnl_Content.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tpnl_Content.Location = new System.Drawing.Point(0, 0);
			this.tpnl_Content.Margin = new System.Windows.Forms.Padding(0);
			this.tpnl_Content.Name = "tpnl_Content";
			this.tpnl_Content.RowCount = 1;
			this.tpnl_Content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tpnl_Content.Size = new System.Drawing.Size(678, 100);
			this.tpnl_Content.TabIndex = 14;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.panel5.Location = new System.Drawing.Point(392, 5);
			this.panel5.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(2, 88);
			this.panel5.TabIndex = 0;
			// 
			// tpnl_Right
			// 
			this.tpnl_Right.ColumnCount = 3;
			this.tpnl_Right.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.6473F));
			this.tpnl_Right.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.3527F));
			this.tpnl_Right.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
			this.tpnl_Right.Controls.Add(this.pic_Spell, 0, 0);
			this.tpnl_Right.Controls.Add(this.pic_Hard, 0, 0);
			this.tpnl_Right.Controls.Add(this.lbl_Mean, 0, 0);
			this.tpnl_Right.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tpnl_Right.Location = new System.Drawing.Point(397, 3);
			this.tpnl_Right.Name = "tpnl_Right";
			this.tpnl_Right.RowCount = 1;
			this.tpnl_Right.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tpnl_Right.Size = new System.Drawing.Size(278, 94);
			this.tpnl_Right.TabIndex = 12;
			// 
			// pic_Spell
			// 
			this.pic_Spell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pic_Spell.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pic_Spell.Image = global::PTLEnglish.Properties.Resources.volume_icon;
			this.pic_Spell.Location = new System.Drawing.Point(245, 10);
			this.pic_Spell.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.pic_Spell.Name = "pic_Spell";
			this.pic_Spell.Size = new System.Drawing.Size(30, 27);
			this.pic_Spell.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pic_Spell.TabIndex = 9;
			this.pic_Spell.TabStop = false;
			this.pic_Spell.Click += new System.EventHandler(this.pic_Spell_Click);
			// 
			// pic_Hard
			// 
			this.pic_Hard.BackColor = System.Drawing.Color.Transparent;
			this.pic_Hard.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pic_Hard.Image = ((System.Drawing.Image)(resources.GetObject("pic_Hard.Image")));
			this.pic_Hard.Location = new System.Drawing.Point(199, 10);
			this.pic_Hard.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.pic_Hard.Name = "pic_Hard";
			this.pic_Hard.Size = new System.Drawing.Size(29, 27);
			this.pic_Hard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pic_Hard.TabIndex = 8;
			this.pic_Hard.TabStop = false;
			this.pic_Hard.Click += new System.EventHandler(this.pic_Hard_Click);
			// 
			// lbl_Mean
			// 
			this.lbl_Mean.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbl_Mean.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Mean.Location = new System.Drawing.Point(3, 0);
			this.lbl_Mean.Name = "lbl_Mean";
			this.lbl_Mean.Size = new System.Drawing.Size(190, 94);
			this.lbl_Mean.TabIndex = 6;
			this.lbl_Mean.Text = "Phòng nghiên cứu và phát triển thị trường";
			this.lbl_Mean.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tpnl_Left
			// 
			this.tpnl_Left.ColumnCount = 3;
			this.tpnl_Left.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.84806F));
			this.tpnl_Left.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.15195F));
			this.tpnl_Left.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
			this.tpnl_Left.Controls.Add(this.pic_Key, 0, 0);
			this.tpnl_Left.Controls.Add(this.lbl_Key, 0, 0);
			this.tpnl_Left.Controls.Add(this.lbl_Score, 0, 0);
			this.tpnl_Left.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tpnl_Left.Location = new System.Drawing.Point(0, 0);
			this.tpnl_Left.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
			this.tpnl_Left.Name = "tpnl_Left";
			this.tpnl_Left.RowCount = 1;
			this.tpnl_Left.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tpnl_Left.Size = new System.Drawing.Size(387, 100);
			this.tpnl_Left.TabIndex = 13;
			// 
			// pic_Key
			// 
			this.pic_Key.BackColor = System.Drawing.Color.Transparent;
			this.pic_Key.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pic_Key.ErrorImage = global::PTLEnglish.Properties.Resources.error_image;
			this.pic_Key.Image = global::PTLEnglish.Properties.Resources.background;
			this.pic_Key.Location = new System.Drawing.Point(273, 3);
			this.pic_Key.Name = "pic_Key";
			this.pic_Key.Size = new System.Drawing.Size(111, 94);
			this.pic_Key.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pic_Key.TabIndex = 17;
			this.pic_Key.TabStop = false;
			// 
			// lbl_Key
			// 
			this.lbl_Key.AutoEllipsis = true;
			this.lbl_Key.BackColor = System.Drawing.Color.Transparent;
			this.lbl_Key.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbl_Key.Font = new System.Drawing.Font("Microsoft YaHei Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Key.Location = new System.Drawing.Point(59, 0);
			this.lbl_Key.MaximumSize = new System.Drawing.Size(250, 100);
			this.lbl_Key.Name = "lbl_Key";
			this.lbl_Key.Size = new System.Drawing.Size(208, 100);
			this.lbl_Key.TabIndex = 16;
			this.lbl_Key.Text = "personel department\r\n/ɑːr ænd diː dɪˈpɑːrtmənt/";
			this.lbl_Key.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_Score
			// 
			this.lbl_Score.BackColor = System.Drawing.Color.Transparent;
			this.lbl_Score.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbl_Score.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Score.ForeColor = System.Drawing.Color.OrangeRed;
			this.lbl_Score.Location = new System.Drawing.Point(0, 0);
			this.lbl_Score.Margin = new System.Windows.Forms.Padding(0);
			this.lbl_Score.MaximumSize = new System.Drawing.Size(78, 100);
			this.lbl_Score.Name = "lbl_Score";
			this.lbl_Score.Size = new System.Drawing.Size(56, 100);
			this.lbl_Score.TabIndex = 5;
			this.lbl_Score.Text = "-225";
			this.lbl_Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl_Score.TextChanged += new System.EventHandler(this.lbl_Score_TextChanged);
			// 
			// WordItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Controls.Add(this.tpnl_Content);
			this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.Name = "WordItem";
			this.Size = new System.Drawing.Size(678, 100);
			this.tpnl_Content.ResumeLayout(false);
			this.tpnl_Right.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pic_Spell)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_Hard)).EndInit();
			this.tpnl_Left.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pic_Key)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TableLayoutPanel tpnl_Content;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.TableLayoutPanel tpnl_Right;
		private System.Windows.Forms.PictureBox pic_Spell;
		private System.Windows.Forms.PictureBox pic_Hard;
		private System.Windows.Forms.Label lbl_Mean;
		private System.Windows.Forms.TableLayoutPanel tpnl_Left;
		private System.Windows.Forms.PictureBox pic_Key;
		private System.Windows.Forms.Label lbl_Key;
		private System.Windows.Forms.Label lbl_Score;
	}
}
