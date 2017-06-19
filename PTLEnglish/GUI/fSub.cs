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
using System.Reflection;
using PTLEnglish.GUI.Learn;

namespace PTLEnglish.GUI
{
	public partial class fSub : Form
	{
		//Panel được tạo khi Nhấn Learn
		Panel pnl = new Panel();

		public static fSub Current;
		public fSub()
		{
			InitializeComponent();
			Current = this;
			this.Controls.Add(pnl);

			UC_Learn_Type.pnl = UC_Learn.pnl = UC_Learn_Choose.pnl = UC_Learn_Shuffle.pnl = UC_Finish.pnl = pnl;

			//Set Double Buffer 
			typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, pnl, new object[] { true });
			typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, pnl_SideBar, new object[] { true });

			#region Hide ScrollBar
			pnl_WordItems.AutoScroll = false;
			pnl_WordItems.HorizontalScroll.Enabled = false;
			pnl_WordItems.HorizontalScroll.Visible = false;
			pnl_WordItems.HorizontalScroll.Maximum = 0;

			pnl_WordItems.VerticalScroll.Enabled = false;
			pnl_WordItems.VerticalScroll.Visible = false;
			pnl_WordItems.VerticalScroll.Maximum = 0;
			pnl_WordItems.AutoScroll = true;
			#endregion
		}

		#region fSub
		private void fSub_Load(object sender, EventArgs e)
		{
			//Thực hiện Load dữ liệu từ file lên chương trình 
			try
			{
				Manage.TopicData = (Topic)Manage.DeserializeFromXML(Cons.Path + Manage.ThisTopic + ".xml");
			}
			catch
			{
				Manage.LoadData(Manage.ThisCourse + Manage.ThisTopic);
			}

			this.Text = Manage.TopicData.TopicName;
			SetToolTipfSub();

			//Thêm các WordItem vào trong các panel 
			for (int i = 0; i < Manage.TopicData.WordList.Count; i++)
			{
				WordItem item = new WordItem(i);
				if (Manage.TopicData.WordList[i].NumWrong == 0)
					pnl_Never.Controls.Add(item);
				else if (Manage.TopicData.WordList[i].NumWrong == 1)
					pnl_Rarely.Controls.Add(item);
				else pnl_Sometimes.Controls.Add(item);
			}

			//Resize các panel mới vừa được thêm vào
			foreach (Control ctl in pnl_WordItems.Controls)
			{
				ctl.Height = (ctl.Controls.Count - 1) * 105 + 42;
			}

			//Nếu các panel đó trống, thì ẩn nó đi
			if (pnl_Sometimes.Controls.Count == 1)
			{
				pnl_Sometimes.Visible = false;
			}
			else pnl_Sometimes.Visible = true;
			if (pnl_Rarely.Controls.Count == 1)
			{
				pnl_Rarely.Visible = false;
			}
			else pnl_Rarely.Visible = true;
			if (pnl_Never.Controls.Count == 1)
				pnl_Never.Visible = false;
			else pnl_Never.Visible = true;
		}

		private void fSub_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (MessageBox.Show("Are you want to quit???", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
			{
				string filePath = Cons.Path + "\\" + Manage.TopicData.TopicName + ".xml";
				Manage.SerializeToXML(Manage.TopicData, filePath);
				//fMain.Current.Show();
				Application.Exit();
			}
			else e.Cancel = true;
		}

		private void SetToolTipfSub()
		{
			tlt_Info.SetToolTip(pic_Fcard, "Flash Card");
			tlt_Info.SetToolTip(pic_Game, "Game");
			tlt_Info.SetToolTip(pic_Gravity, "Gravity");
			tlt_Info.SetToolTip(pic_Learn, "Learn");
			tlt_Info.SetToolTip(pic_Listen, "Listen");
			tlt_Info.SetToolTip(pic_Match, "Match");
			tlt_Info.SetToolTip(pic_Shooter, "Shooter");
			tlt_Info.SetToolTip(pic_Test, "Test");

			tlt_Info.SetToolTip(pnl_Learnt, Manage.TopicData.Learnt.Progress + "/" + Manage.TopicData.WordList.Count);
			tlt_Info.SetToolTip(pnl_LearntValue, Manage.TopicData.Learnt.Progress + "/" + Manage.TopicData.WordList.Count);

			tlt_Info.SetToolTip(pnl_Right, Manage.TopicData.Learnt.CorrectWords + "/" + Manage.TopicData.Learnt.Progress);
			tlt_Info.SetToolTip(pnl_RightValue, Manage.TopicData.Learnt.CorrectWords + "/" + Manage.TopicData.Learnt.Progress);

			tlt_Info.SetToolTip(pnl_Wrong, Manage.TopicData.Learnt.WrongWords+ "/" + Manage.TopicData.Learnt.Progress);
			tlt_Info.SetToolTip(pnl_WrongValue, Manage.TopicData.Learnt.WrongWords + "/" + Manage.TopicData.Learnt.Progress);
		}
		#endregion

		#region pnl_SideBar
		//
		//	pnl_Menu
		//
		private void pnl_Menu_MouseEnter(object sender, EventArgs e)
		{
			pnl_Menu.BackColor = Cons.ColorHov;
			pic_Menu.Image = global::PTLEnglish.Properties.Resources.menu;
		}

		private void pnl_Menu_MouseLeave(object sender, EventArgs e)
		{
			pnl_Menu.BackColor = Color.Transparent;
			pic_Menu.Image = global::PTLEnglish.Properties.Resources.menu_def;
		}

		private void pnl_Menu_Click(object sender, EventArgs e)
		{
			if (pnl_SideBar.Width == 45)
			{
				pnl_SideBar.Width = 187;
			}
			else
			{
				pnl_SideBar.Width = 45;
			}
		}

		//
		//	pnl_Fcard
		//
		private void pnl_Fcard_MouseEnter(object sender, EventArgs e)
		{
			pnl_Fcard.BackColor = Cons.ColorHov;
			pic_Fcard.Image = global::PTLEnglish.Properties.Resources.flashcard_hover;
			lbl_Fcard.ForeColor = Cons.ColorGray;
		}

		private void pnl_Fcard_MouseLeave(object sender, EventArgs e)
		{
			pnl_Fcard.BackColor = Color.Transparent;
			pic_Fcard.Image = global::PTLEnglish.Properties.Resources.flashcard;
			lbl_Fcard.ForeColor = SystemColors.ButtonFace;
		}

		private void pic_Fcard_Click(object sender, EventArgs e)
		{

		}
		//
		//	pnl_Learn
		//
		private void pnl_Learn_MouseEnter(object sender, EventArgs e)
		{
			pnl_Learn.BackColor = Cons.ColorHov;
			pic_Learn.Image = global::PTLEnglish.Properties.Resources.learn_hover;
			lbl_Learn.ForeColor = Cons.ColorGray;
		}

		private void pnl_Learn_MouseLeave(object sender, EventArgs e)
		{
			pnl_Learn.BackColor = Color.Transparent;
			pic_Learn.Image = global::PTLEnglish.Properties.Resources.learn;
			lbl_Learn.ForeColor = SystemColors.ButtonFace;
		}

		public void pnl_Learn_Click(object sender, EventArgs e)
		{
			pnl.Size = new Size(697, 561);
			pnl.Location = new Point(187, 0);
			pnl.Anchor = AnchorStyles.Left;
			pnl.BackColor = SystemColors.ControlDarkDark;

			pnl_Menu.Enabled = false;
			pnl_Content.Visible = false;
			Manage.CheckUseTest = false;
			if (Manage.TopicData.Learnt.Progress == 25)
			{
				Manage.ShowUC(pnl, Manage.UC.UC_Finish, Manage.TopicData.Learnt.Progress, 70, 190);
			}
			else
			{
				Manage.ShowUC(pnl, Manage.UC.UC_Learn, Manage.TopicData.Learnt.Progress, 70, 190);
			}
		}
		//
		//	pnl_Listen
		//
		private void pnl_Listen_MouseEnter(object sender, EventArgs e)
		{
			pnl_Listen.BackColor = Cons.ColorHov;
			pic_Listen.Image = global::PTLEnglish.Properties.Resources.spell_hover;
			lbl_Listen.ForeColor = Cons.ColorGray;
		}

		private void pnl_Listen_MouseLeave(object sender, EventArgs e)
		{
			pnl_Listen.BackColor = Color.Transparent;
			pic_Listen.Image = global::PTLEnglish.Properties.Resources.spell;
			lbl_Listen.ForeColor = SystemColors.ButtonFace;
		}

		private void pnl_Listen_Click(object sender, EventArgs e)
		{

		}

		//
		//	pnl_Test
		//
		private void pnl_Test_MouseEnter(object sender, EventArgs e)
		{
			pnl_Test.BackColor = Cons.ColorHov;
			pic_Test.Image = global::PTLEnglish.Properties.Resources.test_hover;
			lbl_Test.ForeColor = Cons.ColorGray;

		}

		private void pnl_Test_MouseLeave(object sender, EventArgs e)
		{
			pnl_Test.BackColor = Color.Transparent;
			pic_Test.Image = global::PTLEnglish.Properties.Resources.test;
			lbl_Test.ForeColor = SystemColors.ButtonFace;
		}

		private void pnl_Test_Click(object sender, EventArgs e)
		{
			Manage.CheckUseTest = true;
		}

		//
		//	pnl_Game
		//
		private void pnl_Game_MouseEnter(object sender, EventArgs e)
		{
			pnl_Game.BackColor = Cons.ColorHov;
			pic_Game.Image = global::PTLEnglish.Properties.Resources.game_hover;
			lbl_Game.ForeColor = Cons.ColorGray;

		}

		private void pnl_Game_MouseLeave(object sender, EventArgs e)
		{
			pnl_Game.BackColor = Color.Transparent;
			pic_Game.Image = global::PTLEnglish.Properties.Resources.game;
			lbl_Game.ForeColor = SystemColors.ButtonFace;

		}

		private void pnl_Game_Click(object sender, EventArgs e)
		{
			pnl_GameBlk.Visible = !pnl_GameBlk.Visible;
		}

		//
		//	pnl_Match
		//
		private void pnl_Match_MouseEnter(object sender, EventArgs e)
		{
			pnl_Match.BackColor = Cons.ColorHov;
			pic_Match.Image = global::PTLEnglish.Properties.Resources.match_hover;
			lbl_Match.ForeColor = Cons.ColorGray;

		}

		private void pnl_Match_MouseLeave(object sender, EventArgs e)
		{
			pnl_Match.BackColor = Color.Transparent;
			pic_Match.Image = global::PTLEnglish.Properties.Resources.match;
			lbl_Match.ForeColor = SystemColors.ButtonFace;

		}

		private void pnl_Match_Click(object sender, EventArgs e)
		{

		}

		//
		//	pnl_Gravity
		//
		private void pnl_Gravity_MouseEnter(object sender, EventArgs e)
		{
			pnl_Gravity.BackColor = Cons.ColorHov;
			pic_Gravity.Image = global::PTLEnglish.Properties.Resources.falling_star_hover;
			lbl_Gravity.ForeColor = Cons.ColorGray;

		}

		private void pnl_Gravity_MouseLeave(object sender, EventArgs e)
		{
			pnl_Gravity.BackColor = Color.Transparent;
			pic_Gravity.Image = global::PTLEnglish.Properties.Resources.falling_star;
			lbl_Gravity.ForeColor = SystemColors.ButtonFace;

		}

		private void pnl_Gravity_Click(object sender, EventArgs e)
		{

		}

		//
		//	pnl_Shooter
		//
		private void pnl_Shooter_MouseEnter(object sender, EventArgs e)
		{
			pnl_Shooter.BackColor = Cons.ColorHov;
			pic_Shooter.Image = global::PTLEnglish.Properties.Resources.hammer_hover;
			lbl_Shooter.ForeColor = Cons.ColorGray;
		}

		private void pnl_Shooter_MouseLeave(object sender, EventArgs e)
		{
			pnl_Shooter.BackColor = Color.Transparent;
			pic_Shooter.Image = global::PTLEnglish.Properties.Resources.hammer;
			lbl_Shooter.ForeColor = SystemColors.ButtonFace;
		}

		private void pnl_Shooter_Click(object sender, EventArgs e)
		{

		}

		//
		//	pnl_Back
		//
		private void pnl_Back_MouseEnter(object sender, EventArgs e)
		{
			pic_Back.Image = global::PTLEnglish.Properties.Resources.Arrow_hover;
		}

		private void pnl_Back_MouseLeave(object sender, EventArgs e)
		{
			pic_Back.Image = global::PTLEnglish.Properties.Resources.arrow_back;
		}

		private void pnl_Back_Click(object sender, EventArgs e)
		{
			if (!pnl_Content.Visible)
			{
				pnl_Content.Visible = true;
				pnl_Content.Refresh();
			}
			else
			{
				this.Close();
			}
		}

		#endregion

		#region pnl_Content
		private void pnl_Info_Paint(object sender, PaintEventArgs e)
		{
			if (Manage.TopicData.Learnt.Progress == Manage.TopicData.WordList.Count)
				pnl_LearntValue.Width = pnl_Learnt.Width;
			else if (Manage.TopicData.Learnt.Progress == 0)
				pnl_LearntValue.Width = 2;
			else
				pnl_LearntValue.Width = (pnl_Learnt.Width / Manage.TopicData.WordList.Count) * (Manage.TopicData.Learnt.Progress + 1);

			if (Manage.TopicData.Learnt.CorrectWords == Manage.TopicData.WordList.Count)
				pnl_RightValue.Width = pnl_Right.Width;
			else if (Manage.TopicData.Learnt.CorrectWords == 0)
				pnl_RightValue.Width = 2;
			else
				pnl_RightValue.Width = (pnl_Learnt.Width / Manage.TopicData.Learnt.Progress) * Manage.TopicData.Learnt.CorrectWords;

			if (Manage.TopicData.Learnt.WrongWords == Manage.TopicData.WordList.Count)
				pnl_WrongValue.Width = pnl_Wrong.Width;
			else if (Manage.TopicData.Learnt.WrongWords == 0)
				pnl_WrongValue.Width = 2;
			else
				pnl_WrongValue.Width = (pnl_Learnt.Width / Manage.TopicData.Learnt.Progress) * Manage.TopicData.Learnt.WrongWords;
		}

		private void pnl_WordItems_SizeChanged(object sender, EventArgs e)
		{
			foreach (Control ctl in pnl_WordItems.Controls)
			{
				ctl.Width = pnl_WordItems.Width;
				foreach (Control ctrl in ctl.Controls)
				{
					ctrl.Width = ctl.Width;
				}
			}
		}

		#endregion

	}
}
