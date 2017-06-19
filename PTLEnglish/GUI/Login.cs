using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using PTLEnglish.DAL;

namespace PTLEnglish.GUI
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
			myFonts.LoadFonts();
		}

		private bool TestKeyValid(char keyPress)
		{
			if ((keyPress >= '1' && keyPress <= '9') ||
				(keyPress >= 'a' && keyPress <= 'z') ||
				(keyPress >= 'A' && keyPress <= 'Z') ||
				keyPress == (char)Keys.Back || keyPress == (char)Keys.Enter)
			{
				return true;
			}
			return false;
		}

		private void Login_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (TestKeyValid(e.KeyChar) && (lblName.Text.Length <= 8 ||
				(lblName.Text.Length > 8 && e.KeyChar == (char)Keys.Back)) ||
				(lblName.Text == "Default" || lblName.Text == "Enter your name") && e.KeyChar != (char)Keys.Escape)
			{
				//Xóa kí tự cuối cùng khi nhấn phím BackSpace
				if (e.KeyChar == (char)Keys.Back)
				{
					if (lblName.Text != "")
						lblName.Text = lblName.Text.Remove(lblName.Text.Length - 1, 1);
				}
				//Nếu nhấn Enter đầu tiên và text khác Enter your name thì chạy cái lbContinue_Click
				else if (e.KeyChar == (char)Keys.Enter && lblName.Text != "Enter your name")
				{
					lbContinue_Click(sender, e);
				}
				else if (lblName.Text == "Default" || lblName.Text == "Enter your name")
					//gán text bằng kí tự vừa nhấn
					lblName.Text = e.KeyChar.ToString();
				else lblName.Text += e.KeyChar;
			}
		}

		private void lbName_Click(object sender, EventArgs e)
		{
			if (lblName.Text == "Default" || lblName.Text == "Enter your name" || lblName.Text[0] == ' ')
			{
				lblName.Text = "";
			}
		}

		private void LoadForm()
		{
			lblName.Visible = false;
			pnlContinue.Visible = false;

			Thread.Sleep(500);
			picLoad_1.Visible = true;
			this.Refresh();

			Thread.Sleep(400);
			picLoad_2.Visible = true;
			this.Refresh();

			Thread.Sleep(300);
			picLoad_3.Visible = true;
			this.Refresh();

			Thread.Sleep(300);
			picLoad_4.Visible = true;
			this.Refresh();

			Thread.Sleep(300);
			picLoad_5.Visible = true;
			this.Refresh();
			Thread.Sleep(200);

		}

		private void lbContinue_Click(object sender, EventArgs e)
		{
			if (User.UserName == "")
			{
				lblName.Text = lblName.Text.Trim();
				if (lblName.Text == "" || lblName.Text == "Enter your name")
				{
					pnlBackground_Click(pnlBackground, e);
					return;
				}
				else User.UserName = lblName.Text;
			}
			LoadForm();
			this.Hide();
			fMain f = new fMain();
			f.Show();
		}

		private void lbContinue_MouseHover(object sender, EventArgs e)
		{
			pnlUnderline.Visible = true;
		}

		private void lbContinue_MouseLeave(object sender, EventArgs e)
		{
			pnlUnderline.Visible = false;
		}

		private void pnlBackground_Click(object sender, EventArgs e)
		{
			if (lblName.Text == "" || lblName.Text == " ")
				lblName.Text = "Enter your name";
		}

		private void Login_Load(object sender, EventArgs e)
		{
			//PrivateFontCollection pfc = new PrivateFontCollection();
			//pfc.AddFontFile("Daisy's_Delights.ttf");
			//lbName.Font = new Font(pfc.Families[0], 30);
			//lbContinue.Font = new Font(pfc.Families[0], 30);

			lblName.Font = new Font(myFonts.f, 30);
			lblContinue.Font = new Font(myFonts.f, 30);
		}

		private void Login_Activated(object sender, EventArgs e)
		{
			if (User.UserName != "")
			{
				LoadForm();
				this.Hide();
				fMain PTLE = new fMain();
				PTLE.Show();
			}
			else this.Show();

		}
	}
}
