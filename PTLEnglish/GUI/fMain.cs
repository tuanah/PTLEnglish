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
			lblName.Text = User.UserName;

			CirclePictureBox cp = new CirclePictureBox();
			try
			{
				cp.Image = Image.FromFile(User.UserAvaPath);
			}
			catch
			{
				cp.Image = global::PTLEnglish.Properties.Resources.avatar_default;
			}
			cp.Location = new Point(22, 6);
			cp.Size = new Size(100, 100);
			cp.SizeMode = PictureBoxSizeMode.Zoom;
			pnlInfoContent.Controls.Add(cp);
			cp.Click += Cp_Click;
			txtRename.LostFocus += TxtRename_LostFocus;
		}

		private void TxtRename_LostFocus(object sender, EventArgs e)
		{
			txtRename.Visible = false;
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

		private void Cp_Click(object sender, EventArgs e)
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

		private void fMain_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void picMenuBtn_MouseEnter(object sender, EventArgs e)
		{
			picMenuBtn.BackColor = Cons.Hover;
			picMenuBtn.Image = global::PTLEnglish.Properties.Resources.menu;
		}

		private void picMenuBtn_MouseLeave(object sender, EventArgs e)
		{
			picMenuBtn.BackColor = Color.Transparent;
			picMenuBtn.Image = global::PTLEnglish.Properties.Resources.menu_def;
		}

		private void picAccount_MouseEnter(object sender, EventArgs e)
		{
			pnlInfo.BackColor = Cons.Hover;
			picAccount.Image = global::PTLEnglish.Properties.Resources.account_icon;
			lbllnfo.ForeColor = Cons.Text;
		}

		private void picAccount_MouseLeave(object sender, EventArgs e)
		{
			pnlInfo.BackColor = Color.Transparent;
			picAccount.Image = global::PTLEnglish.Properties.Resources.account_def;
			lbllnfo.ForeColor = SystemColors.ButtonFace;
		}

		private void picCourse_MouseEnter(object sender, EventArgs e)
		{
			pnlCourse.BackColor = Cons.Hover;
			picCourse.Image = global::PTLEnglish.Properties.Resources.course;
			lblCourse.ForeColor = Cons.Text;
		}

		private void picCourse_MouseLeave(object sender, EventArgs e)
		{
			pnlCourse.BackColor = Color.Transparent;
			picCourse.Image = global::PTLEnglish.Properties.Resources.course_def;
			lblCourse.ForeColor = SystemColors.ButtonFace;
		}

		private void picRenameBtn_Click(object sender, EventArgs e)
		{
			txtRename.Text = "";
			txtRename.Visible = true;
			txtRename.Focus();
		}

		private void txtRename_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (TestKeyValid(e.KeyChar) && txtRename.Text.Length <= 8)
			{
				if (e.KeyChar == (char)Keys.Enter)
				{
					if (txtRename.Text != "")
					{
						User.UserName = txtRename.Text;
						lblName.Text = txtRename.Text;
					}

					txtRename.Visible = false;
				}
			}
			else if (e.KeyChar == (char)Keys.Back && txtRename.Text != "")
				txtRename.Text = txtRename.Text.Remove(txtRename.Text.Length - 1, 1);
			else e.Handled = true;
		}
	}
}
