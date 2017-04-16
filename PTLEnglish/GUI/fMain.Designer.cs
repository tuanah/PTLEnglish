namespace PTLEnglish.GUI
{
	partial class fMain
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
			this.pnl_Content = new System.Windows.Forms.Panel();
			this.pnl_Grid = new System.Windows.Forms.Panel();
			this.pnl_Panel = new System.Windows.Forms.Panel();
			this.lbl_Close = new System.Windows.Forms.Label();
			this.lbl_Minimize = new System.Windows.Forms.Label();
			this.pnl_SideBar = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pic_MenuBtn = new System.Windows.Forms.PictureBox();
			this.pnl_Course_Block = new System.Windows.Forms.Panel();
			this.fpnl_Course_Content = new System.Windows.Forms.FlowLayoutPanel();
			this.pnl_Course = new System.Windows.Forms.Panel();
			this.lbl_Course = new System.Windows.Forms.Label();
			this.pic_Course = new System.Windows.Forms.PictureBox();
			this.pnl_Info_Content = new System.Windows.Forms.Panel();
			this.txt_Rename = new System.Windows.Forms.TextBox();
			this.pic_RenameBtn = new System.Windows.Forms.PictureBox();
			this.lbl_Name = new System.Windows.Forms.Label();
			this.pnl_Info = new System.Windows.Forms.Panel();
			this.lbl_lnfo = new System.Windows.Forms.Label();
			this.pic_Account = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pnl_Content.SuspendLayout();
			this.pnl_Panel.SuspendLayout();
			this.pnl_SideBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_MenuBtn)).BeginInit();
			this.pnl_Course_Block.SuspendLayout();
			this.pnl_Course.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pic_Course)).BeginInit();
			this.pnl_Info_Content.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pic_RenameBtn)).BeginInit();
			this.pnl_Info.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pic_Account)).BeginInit();
			this.SuspendLayout();
			// 
			// pnl_Content
			// 
			this.pnl_Content.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.pnl_Content.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pnl_Content.Controls.Add(this.pnl_Grid);
			this.pnl_Content.Controls.Add(this.pnl_Panel);
			this.pnl_Content.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_Content.ForeColor = System.Drawing.Color.Black;
			this.pnl_Content.Location = new System.Drawing.Point(250, 0);
			this.pnl_Content.Margin = new System.Windows.Forms.Padding(0);
			this.pnl_Content.Name = "pnl_Content";
			this.pnl_Content.Size = new System.Drawing.Size(534, 561);
			this.pnl_Content.TabIndex = 1;
			// 
			// pnl_Grid
			// 
			this.pnl_Grid.AutoScroll = true;
			this.pnl_Grid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_Grid.Location = new System.Drawing.Point(0, 25);
			this.pnl_Grid.Name = "pnl_Grid";
			this.pnl_Grid.Size = new System.Drawing.Size(534, 536);
			this.pnl_Grid.TabIndex = 2;
			// 
			// pnl_Panel
			// 
			this.pnl_Panel.BackColor = System.Drawing.Color.Transparent;
			this.pnl_Panel.Controls.Add(this.lbl_Close);
			this.pnl_Panel.Controls.Add(this.lbl_Minimize);
			this.pnl_Panel.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_Panel.Location = new System.Drawing.Point(0, 0);
			this.pnl_Panel.Name = "pnl_Panel";
			this.pnl_Panel.Size = new System.Drawing.Size(534, 25);
			this.pnl_Panel.TabIndex = 1;
			// 
			// lbl_Close
			// 
			this.lbl_Close.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_Close.BackColor = System.Drawing.Color.Transparent;
			this.lbl_Close.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.lbl_Close.ForeColor = System.Drawing.Color.Black;
			this.lbl_Close.Location = new System.Drawing.Point(499, 0);
			this.lbl_Close.Name = "lbl_Close";
			this.lbl_Close.Size = new System.Drawing.Size(35, 25);
			this.lbl_Close.TabIndex = 2;
			this.lbl_Close.Text = "X";
			this.lbl_Close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl_Close.Click += new System.EventHandler(this.lbl_Close_Click);
			this.lbl_Close.MouseEnter += new System.EventHandler(this.lbl_Close_MouseEnter);
			this.lbl_Close.MouseLeave += new System.EventHandler(this.lbl_Close_MouseLeave);
			// 
			// lbl_Minimize
			// 
			this.lbl_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_Minimize.BackColor = System.Drawing.Color.Transparent;
			this.lbl_Minimize.Font = new System.Drawing.Font("Microsoft YaHei", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.lbl_Minimize.Location = new System.Drawing.Point(464, 0);
			this.lbl_Minimize.Name = "lbl_Minimize";
			this.lbl_Minimize.Size = new System.Drawing.Size(35, 25);
			this.lbl_Minimize.TabIndex = 1;
			this.lbl_Minimize.Text = "-";
			this.lbl_Minimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.lbl_Minimize.Click += new System.EventHandler(this.lbl_Minimize_Click);
			this.lbl_Minimize.MouseEnter += new System.EventHandler(this.lbl_Minimize_MouseEnter);
			this.lbl_Minimize.MouseLeave += new System.EventHandler(this.lbl_Minimize_MouseLeave);
			// 
			// pnl_SideBar
			// 
			this.pnl_SideBar.BackColor = System.Drawing.Color.SeaGreen;
			this.pnl_SideBar.Controls.Add(this.label1);
			this.pnl_SideBar.Controls.Add(this.pictureBox1);
			this.pnl_SideBar.Controls.Add(this.pic_MenuBtn);
			this.pnl_SideBar.Controls.Add(this.pnl_Course_Block);
			this.pnl_SideBar.Controls.Add(this.pnl_Info_Content);
			this.pnl_SideBar.Controls.Add(this.pnl_Info);
			this.pnl_SideBar.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnl_SideBar.Location = new System.Drawing.Point(0, 0);
			this.pnl_SideBar.Margin = new System.Windows.Forms.Padding(0);
			this.pnl_SideBar.MinimumSize = new System.Drawing.Size(50, 0);
			this.pnl_SideBar.Name = "pnl_SideBar";
			this.pnl_SideBar.Size = new System.Drawing.Size(250, 561);
			this.pnl_SideBar.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(9, 9);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Padding = new System.Windows.Forms.Padding(13, 16, 0, 0);
			this.pictureBox1.Size = new System.Drawing.Size(30, 30);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// pic_MenuBtn
			// 
			this.pic_MenuBtn.BackColor = System.Drawing.Color.Transparent;
			this.pic_MenuBtn.Image = global::PTLEnglish.Properties.Resources.menu_def;
			this.pic_MenuBtn.Location = new System.Drawing.Point(200, 0);
			this.pic_MenuBtn.Margin = new System.Windows.Forms.Padding(0);
			this.pic_MenuBtn.Name = "pic_MenuBtn";
			this.pic_MenuBtn.Padding = new System.Windows.Forms.Padding(13, 16, 0, 0);
			this.pic_MenuBtn.Size = new System.Drawing.Size(50, 45);
			this.pic_MenuBtn.TabIndex = 0;
			this.pic_MenuBtn.TabStop = false;
			this.pic_MenuBtn.Visible = false;
			this.pic_MenuBtn.Click += new System.EventHandler(this.picMenuBtn_Click);
			this.pic_MenuBtn.MouseEnter += new System.EventHandler(this.picMenuBtn_MouseEnter);
			this.pic_MenuBtn.MouseLeave += new System.EventHandler(this.picMenuBtn_MouseLeave);
			// 
			// pnl_Course_Block
			// 
			this.pnl_Course_Block.BackColor = System.Drawing.Color.Transparent;
			this.pnl_Course_Block.Controls.Add(this.fpnl_Course_Content);
			this.pnl_Course_Block.Controls.Add(this.pnl_Course);
			this.pnl_Course_Block.ForeColor = System.Drawing.SystemColors.MenuText;
			this.pnl_Course_Block.Location = new System.Drawing.Point(0, 230);
			this.pnl_Course_Block.Margin = new System.Windows.Forms.Padding(0);
			this.pnl_Course_Block.Name = "pnl_Course_Block";
			this.pnl_Course_Block.Size = new System.Drawing.Size(250, 332);
			this.pnl_Course_Block.TabIndex = 3;
			// 
			// fpnl_Course_Content
			// 
			this.fpnl_Course_Content.BackColor = System.Drawing.Color.Transparent;
			this.fpnl_Course_Content.Dock = System.Windows.Forms.DockStyle.Right;
			this.fpnl_Course_Content.Location = new System.Drawing.Point(50, 45);
			this.fpnl_Course_Content.Margin = new System.Windows.Forms.Padding(0);
			this.fpnl_Course_Content.Name = "fpnl_Course_Content";
			this.fpnl_Course_Content.Size = new System.Drawing.Size(200, 287);
			this.fpnl_Course_Content.TabIndex = 3;
			// 
			// pnl_Course
			// 
			this.pnl_Course.BackColor = System.Drawing.Color.Transparent;
			this.pnl_Course.Controls.Add(this.lbl_Course);
			this.pnl_Course.Controls.Add(this.pic_Course);
			this.pnl_Course.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_Course.Location = new System.Drawing.Point(0, 0);
			this.pnl_Course.Name = "pnl_Course";
			this.pnl_Course.Size = new System.Drawing.Size(250, 45);
			this.pnl_Course.TabIndex = 2;
			this.pnl_Course.Click += new System.EventHandler(this.pnl_Course_Click);
			// 
			// lbl_Course
			// 
			this.lbl_Course.Font = new System.Drawing.Font("Microsoft YaHei Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.lbl_Course.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lbl_Course.Location = new System.Drawing.Point(50, 0);
			this.lbl_Course.Name = "lbl_Course";
			this.lbl_Course.Size = new System.Drawing.Size(200, 45);
			this.lbl_Course.TabIndex = 1;
			this.lbl_Course.Text = "Courses";
			this.lbl_Course.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl_Course.Click += new System.EventHandler(this.pnl_Course_Click);
			this.lbl_Course.MouseEnter += new System.EventHandler(this.picCourse_MouseEnter);
			this.lbl_Course.MouseLeave += new System.EventHandler(this.picCourse_MouseLeave);
			// 
			// pic_Course
			// 
			this.pic_Course.Image = global::PTLEnglish.Properties.Resources.course_def;
			this.pic_Course.Location = new System.Drawing.Point(0, 0);
			this.pic_Course.Name = "pic_Course";
			this.pic_Course.Padding = new System.Windows.Forms.Padding(13, 10, 0, 0);
			this.pic_Course.Size = new System.Drawing.Size(50, 45);
			this.pic_Course.TabIndex = 0;
			this.pic_Course.TabStop = false;
			this.pic_Course.MouseEnter += new System.EventHandler(this.picCourse_MouseEnter);
			this.pic_Course.MouseLeave += new System.EventHandler(this.picCourse_MouseLeave);
			// 
			// pnl_Info_Content
			// 
			this.pnl_Info_Content.BackColor = System.Drawing.Color.Transparent;
			this.pnl_Info_Content.Controls.Add(this.txt_Rename);
			this.pnl_Info_Content.Controls.Add(this.pic_RenameBtn);
			this.pnl_Info_Content.Controls.Add(this.lbl_Name);
			this.pnl_Info_Content.Location = new System.Drawing.Point(50, 90);
			this.pnl_Info_Content.Name = "pnl_Info_Content";
			this.pnl_Info_Content.Size = new System.Drawing.Size(200, 140);
			this.pnl_Info_Content.TabIndex = 2;
			// 
			// txt_Rename
			// 
			this.txt_Rename.BackColor = System.Drawing.Color.SeaGreen;
			this.txt_Rename.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txt_Rename.Font = new System.Drawing.Font("Microsoft YaHei Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.txt_Rename.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.txt_Rename.Location = new System.Drawing.Point(18, 113);
			this.txt_Rename.Name = "txt_Rename";
			this.txt_Rename.Size = new System.Drawing.Size(101, 24);
			this.txt_Rename.TabIndex = 0;
			this.txt_Rename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txt_Rename.Visible = false;
			this.txt_Rename.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRename_KeyPress);
			// 
			// pic_RenameBtn
			// 
			this.pic_RenameBtn.Image = global::PTLEnglish.Properties.Resources.pencil;
			this.pic_RenameBtn.Location = new System.Drawing.Point(122, 110);
			this.pic_RenameBtn.Name = "pic_RenameBtn";
			this.pic_RenameBtn.Size = new System.Drawing.Size(23, 23);
			this.pic_RenameBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_RenameBtn.TabIndex = 3;
			this.pic_RenameBtn.TabStop = false;
			this.pic_RenameBtn.Click += new System.EventHandler(this.picRenameBtn_Click);
			// 
			// lbl_Name
			// 
			this.lbl_Name.Font = new System.Drawing.Font("Microsoft YaHei Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.lbl_Name.ForeColor = System.Drawing.Color.White;
			this.lbl_Name.Location = new System.Drawing.Point(0, 113);
			this.lbl_Name.Name = "lbl_Name";
			this.lbl_Name.Size = new System.Drawing.Size(142, 26);
			this.lbl_Name.TabIndex = 1;
			this.lbl_Name.Text = "Name";
			this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnl_Info
			// 
			this.pnl_Info.BackColor = System.Drawing.Color.Transparent;
			this.pnl_Info.Controls.Add(this.lbl_lnfo);
			this.pnl_Info.Controls.Add(this.pic_Account);
			this.pnl_Info.Location = new System.Drawing.Point(0, 45);
			this.pnl_Info.Name = "pnl_Info";
			this.pnl_Info.Size = new System.Drawing.Size(250, 45);
			this.pnl_Info.TabIndex = 1;
			this.pnl_Info.Click += new System.EventHandler(this.pnlInfo_Click);
			// 
			// lbl_lnfo
			// 
			this.lbl_lnfo.Font = new System.Drawing.Font("Microsoft YaHei Light", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_lnfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lbl_lnfo.Location = new System.Drawing.Point(50, 0);
			this.lbl_lnfo.Name = "lbl_lnfo";
			this.lbl_lnfo.Size = new System.Drawing.Size(200, 45);
			this.lbl_lnfo.TabIndex = 1;
			this.lbl_lnfo.Text = "Infomation";
			this.lbl_lnfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl_lnfo.Click += new System.EventHandler(this.pnlInfo_Click);
			this.lbl_lnfo.MouseEnter += new System.EventHandler(this.picAccount_MouseEnter);
			this.lbl_lnfo.MouseLeave += new System.EventHandler(this.picAccount_MouseLeave);
			// 
			// pic_Account
			// 
			this.pic_Account.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pic_Account.Image = global::PTLEnglish.Properties.Resources.account_def;
			this.pic_Account.Location = new System.Drawing.Point(0, 0);
			this.pic_Account.Name = "pic_Account";
			this.pic_Account.Padding = new System.Windows.Forms.Padding(13, 10, 0, 0);
			this.pic_Account.Size = new System.Drawing.Size(250, 45);
			this.pic_Account.TabIndex = 0;
			this.pic_Account.TabStop = false;
			this.pic_Account.Click += new System.EventHandler(this.pnlInfo_Click);
			this.pic_Account.MouseEnter += new System.EventHandler(this.picAccount_MouseEnter);
			this.pic_Account.MouseLeave += new System.EventHandler(this.picAccount_MouseLeave);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new System.Drawing.Point(42, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(200, 45);
			this.label1.TabIndex = 2;
			this.label1.Text = "PTLEnglish";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// fMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 10F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Highlight;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.pnl_Content);
			this.Controls.Add(this.pnl_SideBar);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
			this.MaximumSize = new System.Drawing.Size(800, 600);
			this.Name = "fMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PTLPTLEnglish";
			this.TransparencyKey = System.Drawing.SystemColors.Highlight;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fMain_FormClosed);
			this.Load += new System.EventHandler(this.fMain_Load);
			this.pnl_Content.ResumeLayout(false);
			this.pnl_Panel.ResumeLayout(false);
			this.pnl_SideBar.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_MenuBtn)).EndInit();
			this.pnl_Course_Block.ResumeLayout(false);
			this.pnl_Course.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pic_Course)).EndInit();
			this.pnl_Info_Content.ResumeLayout(false);
			this.pnl_Info_Content.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pic_RenameBtn)).EndInit();
			this.pnl_Info.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pic_Account)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnl_SideBar;
		private System.Windows.Forms.Panel pnl_Content;
		private System.Windows.Forms.PictureBox pic_MenuBtn;
		private System.Windows.Forms.Panel pnl_Info;
		private System.Windows.Forms.PictureBox pic_Account;
		private System.Windows.Forms.Label lbl_lnfo;
		private System.Windows.Forms.Panel pnl_Info_Content;
		private System.Windows.Forms.Label lbl_Name;
		private System.Windows.Forms.Panel pnl_Course;
		private System.Windows.Forms.Label lbl_Course;
		private System.Windows.Forms.PictureBox pic_Course;
		private System.Windows.Forms.PictureBox pic_RenameBtn;
		private System.Windows.Forms.TextBox txt_Rename;
		private System.Windows.Forms.Panel pnl_Course_Block;
		private System.Windows.Forms.FlowLayoutPanel fpnl_Course_Content;
		private System.Windows.Forms.Panel pnl_Panel;
		private System.Windows.Forms.Label lbl_Close;
		private System.Windows.Forms.Label lbl_Minimize;
		private System.Windows.Forms.Panel pnl_Grid;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
	}
}