using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTLEnglish.DAL;


namespace PTLEnglish.GUI
{
	public partial class fMain : Form
	{
		public fMain()
		{
			InitializeComponent();

			lbl_Name.Text = User.UserName;

			#region Set Rounded Border for pic_Avatar
			CirclePictureBox pic_Avatar = new CirclePictureBox();
			try
			{
				pic_Avatar.Image = Image.FromFile(User.UserAvaPath);
			}
			catch
			{
				pic_Avatar.Image = global::PTLEnglish.Properties.Resources.avatar_default;
			}

			pic_Avatar.Location = new Point(22, 6);
			pic_Avatar.Size = new Size(100, 100);
			pic_Avatar.SizeMode = PictureBoxSizeMode.Zoom;
			pnl_Info_Content.Controls.Add(pic_Avatar);
			pic_Avatar.Click += Pic_Avatar_Click;
			#endregion

			#region Hide ScrollBar
			fpnl_Course_Content.AutoScroll = false;
			fpnl_Course_Content.HorizontalScroll.Enabled = false;
			fpnl_Course_Content.HorizontalScroll.Visible = false;
			fpnl_Course_Content.HorizontalScroll.Maximum = 0;

			fpnl_Course_Content.VerticalScroll.Enabled = false;
			fpnl_Course_Content.VerticalScroll.Visible = false;
			fpnl_Course_Content.VerticalScroll.Maximum = 0;
			fpnl_Course_Content.AutoScroll = true;
			#endregion


		}

		#region fMain
		private void fMain_Load(object sender, EventArgs e)
		{
			//for (int i = 0; i < Manage.ListCourses.Length; i++)
			//{
			//	Manage.ListCourses[i] = new FlowLayoutPanel();
			//	for (int j = 0; j < Cons.CourseDir[i / 2].GetDirectories().Length; j++)
			//	{
			//		Label lbl = new Label();
			//		lbl.ForeColor = SystemColors.ButtonFace;
			//		lbl.Font = new Font("Microsoft Yahei Light", 14F);
			//		lbl.AutoSize = false;
			//		lbl.TextAlign = ContentAlignment.MiddleLeft;
			//		lbl.Margin = new Padding(20, 0, 0, 0);
			//		lbl.Size = new Size(fpnl_Course_Content.Width - lbl.Margin.Left, 35);
			//		lbl.Tag = i + 1;

			//		lbl.MouseEnter += LblCourse_Enter;
			//		lbl.MouseLeave += LblCourse_Leave;

			//		if (j == 0 && i % 2 == 0)
			//		{
			//			lbl.Text = Cons.CourseDir[i / 2].Name;
			//			Manage.ListCourses[i].Controls.Add(lbl);
			//			lbl.Click += Course_Clk;
			//			break;
			//		}
			//		else
			//		{
			//			lbl.Text = Cons.CourseDir[i / 2].GetDirectories()[j].Name;
			//			lbl.Margin = new Padding(40, 0, 0, 0);
			//			lbl.Click += Topic_Clk;
			//			Manage.ListCourses[i].Controls.Add(lbl);
			//		}
			//	}

			//	//if (i % 2 == 0)
			//	//{
			//	//	Manage.ListCourses[i].Margin = new Padding(20, 0, 0, 0);
			//	//}
			//	//else
			//	//{
			//	//	Manage.ListCourses[i].Margin = new Padding(40, 0, 0, 0);
			//	//	Manage.ListCourses[i].Visible = false;
			//	//}

			//	if (i %2 != 0)
			//	{
			//		Manage.ListCourses[i].Visible = false;
			//	}

			//	//Set maxsize cho Manage.ListCourses[i] bằng số lượng phần tử * Height của mỗi phần tử
			//	Manage.ListCourses[i].MaximumSize = new Size(Manage.ListCourses[i].Width, Manage.ListCourses[i].Controls.Count * 35);
			//	//Set maxsize cho Manage.ListCourses[i] bằng Height của 1 phần tử
			//	Manage.ListCourses[i].MinimumSize = new Size(Manage.ListCourses[i].Width, 35);

			//	Manage.ListCourses[i].Size = new Size(Manage.ListCourses[i].Width, 35);
			//	fpnl_Course_Content.Controls.Add(Manage.ListCourses[i]);
			//}
		}

		private void fMain_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		#endregion

		#region Method for pnl_SideBar

		private void picMenuBtn_MouseEnter(object sender, EventArgs e)
		{
			pic_MenuBtn.BackColor = Cons.Hover;
			pic_MenuBtn.Image = global::PTLEnglish.Properties.Resources.menu;
		}

		private void picMenuBtn_MouseLeave(object sender, EventArgs e)
		{
			pic_MenuBtn.BackColor = Color.Transparent;
			pic_MenuBtn.Image = global::PTLEnglish.Properties.Resources.menu_def;
		}

		private void picMenuBtn_Click(object sender, EventArgs e)
		{
			if (pnl_SideBar.Width == 50)
			{
				Animation.Transition(pnl_SideBar, 200, Animation.Duration.Immediately, Animation.Direction.Vertical);
			}
			else if (pnl_SideBar.Width == 250)
			{
				Animation.Transition(pnl_SideBar, -200, Animation.Duration.Immediately, Animation.Direction.Vertical);
			}
		}

		#region pnl_Info
		private void pnlInfo_Click(object sender, EventArgs e)
		{
			if (pnl_SideBar.Width == 50)
				return;
			if (pnl_Info_Content.Height == 0)
			{
				Animation.Transition(pnl_Info_Content, 140, Animation.Duration.Fast, Animation.Direction.Horizontal);
				Animation.Move(pnl_Course_Block, new Point(pnl_Course_Block.Location.X, pnl_Course_Block.Location.Y + 140), Animation.Duration.Normal);
				
				Animation.Transition(pnl_Course_Block, -140, Animation.Duration.Fast, Animation.Direction.Horizontal);
			}
			else
			{
				Animation.Transition(pnl_Info_Content, -140, Animation.Duration.Fast, Animation.Direction.Horizontal);
				Animation.Move(pnl_Course_Block, new Point(pnl_Course_Block.Location.X, pnl_Course_Block.Location.Y - 140), Animation.Duration.Normal);
				Animation.Transition(pnl_Course_Block, 140, Animation.Duration.Fast, Animation.Direction.Horizontal);
			}
		}

		private void picAccount_MouseEnter(object sender, EventArgs e)
		{
			pnl_Info.BackColor = Cons.Hover;
			pic_Account.Image = global::PTLEnglish.Properties.Resources.account_icon;
			lbl_lnfo.ForeColor = Cons._Gray;
		}

		private void picAccount_MouseLeave(object sender, EventArgs e)
		{
			pnl_Info.BackColor = Color.Transparent;
			pic_Account.Image = global::PTLEnglish.Properties.Resources.account_def;
			lbl_lnfo.ForeColor = SystemColors.ButtonFace;
		}
		#endregion

		#region pnl_Info_Content
		private void Pic_Avatar_Click(object sender, EventArgs e)
		{
			OpenFileDialog open = new OpenFileDialog();
			open.Filter = "JPG (*.jpg)|*.jpg| PNG (*.png)|*.png";
			if (open.ShowDialog() == DialogResult.OK)
			{
				CirclePictureBox cp = sender as CirclePictureBox;
				cp.Image = Image.FromFile(open.FileName);
				User.UserAvaPath = open.FileName;
			}
		}

		private void picRenameBtn_Click(object sender, EventArgs e)
		{
			txt_Rename.Text = "";
			txt_Rename.Visible = true;
			txt_Rename.Focus();
		}

		private bool TestKeyValid(char keyPress)
		{
			if ((keyPress >= '1' && keyPress <= '9') ||
				(keyPress >= 'a' && keyPress <= 'z') ||
				(keyPress >= 'A' && keyPress <= 'Z') ||
				keyPress == (char)Keys.Back ||
				keyPress == (char)Keys.Enter)
			{
				return true;
			}
			return false;
		}

		private void txtRename_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (TestKeyValid(e.KeyChar) && txt_Rename.Text.Length <= 8)
			{
				if (e.KeyChar == (char)Keys.Enter)
				{
					if (txt_Rename.Text != "")
					{
						User.UserName = txt_Rename.Text;
						lbl_Name.Text = txt_Rename.Text;
					}

					txt_Rename.Visible = false;
				}
			}
			else if (e.KeyChar == (char)Keys.Back && txt_Rename.Text != "")
				txt_Rename.Text = txt_Rename.Text.Remove(txt_Rename.Text.Length - 1, 1);
			else e.Handled = true;
		}
		#endregion

		#region pnl_Course

		private void picCourse_MouseEnter(object sender, EventArgs e)
		{
			pnl_Course.BackColor = Cons.Hover;
			pic_Course.Image = global::PTLEnglish.Properties.Resources.course;
			lbl_Course.ForeColor = Cons._Gray;
		}

		private void picCourse_MouseLeave(object sender, EventArgs e)
		{
			pnl_Course.BackColor = Color.Transparent;
			pic_Course.Image = global::PTLEnglish.Properties.Resources.course_def;
			lbl_Course.ForeColor = SystemColors.ButtonFace;
		}
		#endregion

		#region fpnl_Course_Content
		private void LblCourse_Leave(object sender, EventArgs e)
		{
			Label lbl = sender as Label;
			lbl.BackColor = Color.Transparent;
			lbl.ForeColor = SystemColors.ButtonFace;
		}

		private void LblCourse_Enter(object sender, EventArgs e)
		{
			Label lbl = sender as Label;
			lbl.BackColor = Cons.Hover;
			lbl.ForeColor = Cons._Gray;
		}

		private void Course_Clk(object sender, EventArgs e)
		{
			Label lbl = sender as Label;

			if(Manage.ListCourses[(int)(lbl.Tag)].Height == 35 )
			{
				Manage.ListCourses[(int)(lbl.Tag)].Visible = true;
				Animation.Transition(Manage.ListCourses[(int)(lbl.Tag)], Manage.ListCourses[(int)(lbl.Tag)].MaximumSize.Height, Animation.Duration.Fast, Animation.Direction.Horizontal);
			}
			else
			{
				Manage.ListCourses[(int)(lbl.Tag)].Size = new Size(Manage.ListCourses[(int)(lbl.Tag)].Width, 35);
				Manage.ListCourses[(int)(lbl.Tag)].Visible = false;
			}

			for (int i = 0; i < Manage.ListCourses.Length; i++)
			{
				if (i % 2 != 0 && i != (int)lbl.Tag)
				{
					if(Manage.ListCourses[i].Visible)
					{
						Animation.Transition(Manage.ListCourses[i], -Manage.ListCourses[i].Height, Animation.Duration.Fast, Animation.Direction.Horizontal);
						Manage.ListCourses[i].Visible = false;
						break;
					}
					
				}
			}
		}

		private void Topic_Clk(object sender, EventArgs e)
		{
			//throw new NotImplementedException();
		}


		#endregion
		#endregion

		#region Method for pnl_Content
		#region pnl_Panel
		private void lbl_Close_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void lbl_Close_MouseEnter(object sender, EventArgs e)
		{
			Label lbl = sender as Label;
			lbl.BackColor = Color.DarkRed;
			lbl.ForeColor = SystemColors.ButtonFace;
		}

		private void lbl_Close_MouseLeave(object sender, EventArgs e)
		{
			Label lbl = sender as Label;
			lbl.BackColor = Color.Transparent;
			lbl.ForeColor = Color.Black;

		}

		private void lbl_Minimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void lbl_Minimize_MouseEnter(object sender, EventArgs e)
		{
			Label lbl = sender as Label;
			lbl.BackColor = Color.LightGray;
		}

		private void lbl_Minimize_MouseLeave(object sender, EventArgs e)
		{
			Label lbl = sender as Label;
			lbl.BackColor = Color.Transparent;
		}
		#endregion

		#endregion
	}
}
