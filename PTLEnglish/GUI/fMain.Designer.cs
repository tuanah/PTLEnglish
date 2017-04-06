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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
			this.pnlContent = new System.Windows.Forms.Panel();
			this.pnlSideBar = new System.Windows.Forms.Panel();
			this.pnlCourse = new System.Windows.Forms.Panel();
			this.lblCourse = new System.Windows.Forms.Label();
			this.picCourse = new System.Windows.Forms.PictureBox();
			this.pnlInfoContent = new System.Windows.Forms.Panel();
			this.txtRename = new ZBobb.AlphaBlendTextBox();
			this.picRenameBtn = new System.Windows.Forms.PictureBox();
			this.lblName = new System.Windows.Forms.Label();
			this.pnlInfo = new System.Windows.Forms.Panel();
			this.lbllnfo = new System.Windows.Forms.Label();
			this.picAccount = new System.Windows.Forms.PictureBox();
			this.picMenuBtn = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.pnlSideBar.SuspendLayout();
			this.pnlCourse.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picCourse)).BeginInit();
			this.pnlInfoContent.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picRenameBtn)).BeginInit();
			this.pnlInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picAccount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picMenuBtn)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlContent
			// 
			this.pnlContent.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.pnlContent.ForeColor = System.Drawing.Color.Black;
			this.pnlContent.Location = new System.Drawing.Point(250, 0);
			this.pnlContent.Margin = new System.Windows.Forms.Padding(0);
			this.pnlContent.Name = "pnlContent";
			this.pnlContent.Size = new System.Drawing.Size(534, 561);
			this.pnlContent.TabIndex = 1;
			// 
			// pnlSideBar
			// 
			this.pnlSideBar.BackgroundImage = global::PTLEnglish.Properties.Resources.bg_sidebar;
			this.pnlSideBar.Controls.Add(this.pnlCourse);
			this.pnlSideBar.Controls.Add(this.pnlInfoContent);
			this.pnlSideBar.Controls.Add(this.pnlInfo);
			this.pnlSideBar.Controls.Add(this.picMenuBtn);
			this.pnlSideBar.Location = new System.Drawing.Point(0, 0);
			this.pnlSideBar.Margin = new System.Windows.Forms.Padding(0);
			this.pnlSideBar.Name = "pnlSideBar";
			this.pnlSideBar.Size = new System.Drawing.Size(250, 561);
			this.pnlSideBar.TabIndex = 0;
			// 
			// pnlCourse
			// 
			this.pnlCourse.BackColor = System.Drawing.Color.Transparent;
			this.pnlCourse.Controls.Add(this.lblCourse);
			this.pnlCourse.Controls.Add(this.picCourse);
			this.pnlCourse.Location = new System.Drawing.Point(0, 230);
			this.pnlCourse.Name = "pnlCourse";
			this.pnlCourse.Size = new System.Drawing.Size(250, 45);
			this.pnlCourse.TabIndex = 2;
			// 
			// lblCourse
			// 
			this.lblCourse.Font = new System.Drawing.Font("Comic Sans MS", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.lblCourse.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblCourse.Location = new System.Drawing.Point(50, 0);
			this.lblCourse.Name = "lblCourse";
			this.lblCourse.Size = new System.Drawing.Size(200, 45);
			this.lblCourse.TabIndex = 1;
			this.lblCourse.Text = "Courses";
			this.lblCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblCourse.MouseEnter += new System.EventHandler(this.picCourse_MouseEnter);
			this.lblCourse.MouseLeave += new System.EventHandler(this.picCourse_MouseLeave);
			// 
			// picCourse
			// 
			this.picCourse.Location = new System.Drawing.Point(0, 0);
			this.picCourse.Name = "picCourse";
			this.picCourse.Padding = new System.Windows.Forms.Padding(13, 10, 0, 0);
			this.picCourse.Size = new System.Drawing.Size(50, 45);
			this.picCourse.TabIndex = 0;
			this.picCourse.TabStop = false;
			this.picCourse.MouseEnter += new System.EventHandler(this.picCourse_MouseEnter);
			this.picCourse.MouseLeave += new System.EventHandler(this.picCourse_MouseLeave);
			// 
			// pnlInfoContent
			// 
			this.pnlInfoContent.BackColor = System.Drawing.Color.Transparent;
			this.pnlInfoContent.Controls.Add(this.txtRename);
			this.pnlInfoContent.Controls.Add(this.picRenameBtn);
			this.pnlInfoContent.Controls.Add(this.lblName);
			this.pnlInfoContent.Location = new System.Drawing.Point(50, 90);
			this.pnlInfoContent.Name = "pnlInfoContent";
			this.pnlInfoContent.Size = new System.Drawing.Size(200, 140);
			this.pnlInfoContent.TabIndex = 2;
			// 
			// txtRename
			// 
			this.txtRename.BackAlpha = 0;
			this.txtRename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.txtRename.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtRename.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.txtRename.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.txtRename.Location = new System.Drawing.Point(0, 114);
			this.txtRename.Name = "txtRename";
			this.txtRename.Size = new System.Drawing.Size(120, 23);
			this.txtRename.TabIndex = 4;
			this.txtRename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtRename.Visible = false;
			this.txtRename.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRename_KeyPress);
			// 
			// picRenameBtn
			// 
			this.picRenameBtn.BackgroundImage = global::PTLEnglish.Properties.Resources.pencil_icon_614x460;
			this.picRenameBtn.Location = new System.Drawing.Point(117, 110);
			this.picRenameBtn.Name = "picRenameBtn";
			this.picRenameBtn.Size = new System.Drawing.Size(23, 23);
			this.picRenameBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picRenameBtn.TabIndex = 3;
			this.picRenameBtn.TabStop = false;
			this.picRenameBtn.Click += new System.EventHandler(this.picRenameBtn_Click);
			// 
			// lblName
			// 
			this.lblName.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.lblName.ForeColor = System.Drawing.Color.White;
			this.lblName.Location = new System.Drawing.Point(0, 113);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(142, 26);
			this.lblName.TabIndex = 1;
			this.lblName.Text = "Name";
			this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnlInfo
			// 
			this.pnlInfo.BackColor = System.Drawing.Color.Transparent;
			this.pnlInfo.Controls.Add(this.lbllnfo);
			this.pnlInfo.Controls.Add(this.picAccount);
			this.pnlInfo.Location = new System.Drawing.Point(0, 45);
			this.pnlInfo.Name = "pnlInfo";
			this.pnlInfo.Size = new System.Drawing.Size(250, 45);
			this.pnlInfo.TabIndex = 1;
			// 
			// lbllnfo
			// 
			this.lbllnfo.Font = new System.Drawing.Font("Comic Sans MS", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.lbllnfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lbllnfo.Location = new System.Drawing.Point(50, 0);
			this.lbllnfo.Name = "lbllnfo";
			this.lbllnfo.Size = new System.Drawing.Size(200, 45);
			this.lbllnfo.TabIndex = 1;
			this.lbllnfo.Text = "Infomation";
			this.lbllnfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbllnfo.MouseEnter += new System.EventHandler(this.picAccount_MouseEnter);
			this.lbllnfo.MouseLeave += new System.EventHandler(this.picAccount_MouseLeave);
			// 
			// picAccount
			// 
			this.picAccount.Location = new System.Drawing.Point(0, 0);
			this.picAccount.Name = "picAccount";
			this.picAccount.Padding = new System.Windows.Forms.Padding(13, 10, 0, 0);
			this.picAccount.Size = new System.Drawing.Size(50, 45);
			this.picAccount.TabIndex = 0;
			this.picAccount.TabStop = false;
			this.picAccount.MouseEnter += new System.EventHandler(this.picAccount_MouseEnter);
			this.picAccount.MouseLeave += new System.EventHandler(this.picAccount_MouseLeave);
			// 
			// picMenuBtn
			// 
			this.picMenuBtn.BackColor = System.Drawing.Color.Transparent;
			this.picMenuBtn.Location = new System.Drawing.Point(0, 0);
			this.picMenuBtn.Name = "picMenuBtn";
			this.picMenuBtn.Padding = new System.Windows.Forms.Padding(13, 16, 0, 0);
			this.picMenuBtn.Size = new System.Drawing.Size(50, 45);
			this.picMenuBtn.TabIndex = 0;
			this.picMenuBtn.TabStop = false;
			this.picMenuBtn.MouseEnter += new System.EventHandler(this.picMenuBtn_MouseEnter);
			this.picMenuBtn.MouseLeave += new System.EventHandler(this.picMenuBtn_MouseLeave);
			// 
			// fMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 10F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.pnlContent);
			this.Controls.Add(this.pnlSideBar);
			this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
			this.MaximumSize = new System.Drawing.Size(800, 600);
			this.Name = "fMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PTLPTLEnglish";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fMain_FormClosed);
			this.pnlSideBar.ResumeLayout(false);
			this.pnlCourse.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picCourse)).EndInit();
			this.pnlInfoContent.ResumeLayout(false);
			this.pnlInfoContent.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picRenameBtn)).EndInit();
			this.pnlInfo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picAccount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picMenuBtn)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlSideBar;
		private System.Windows.Forms.Panel pnlContent;
		private System.Windows.Forms.PictureBox picMenuBtn;
		private System.Windows.Forms.Panel pnlInfo;
		private System.Windows.Forms.PictureBox picAccount;
		private System.Windows.Forms.Label lbllnfo;
		private System.Windows.Forms.Panel pnlInfoContent;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Panel pnlCourse;
		private System.Windows.Forms.Label lblCourse;
		private System.Windows.Forms.PictureBox picCourse;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.PictureBox picRenameBtn;
		private ZBobb.AlphaBlendTextBox txtRename;
	}
}