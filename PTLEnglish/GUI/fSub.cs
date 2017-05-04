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

namespace PTLEnglish.GUI
{
	public partial class fSub : Form
	{
		public fSub()
		{
			InitializeComponent();
			Manage.ThisCourse = "Source\\Economic";
			Manage.ThisTopic= "\\Job";

			typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance |BindingFlags.NonPublic, null, pnl_SideBar, new object[] { true });

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

			for (int i = 0; i < Manage.TopicData.WordList.Count; i++)
			{
				WordItem item = new WordItem(i);
				if (Manage.TopicData.WordList[i].NumWrong == 0)
					pnl_Never.Controls.Add(item);
				else if (Manage.TopicData.WordList[i].NumWrong == 1)
					pnl_Rarely.Controls.Add(item);
				else pnl_Sometimes.Controls.Add(item);
			}

			foreach (Control ctl in pnl_WordItems.Controls)
			{
				ctl.Height = (ctl.Controls.Count) * 105 + 65;
			}

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

		private void fSub_FormClosed(object sender, FormClosedEventArgs e)
		{
			string filePath = Cons.Path + "\\" + Manage.TopicData.TopicName + ".xml";
			Manage.SerializeToXML(Manage.TopicData, filePath);
			Application.Exit();
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
			tlt_Info.SetToolTip(pnl_Learnt, Manage.TopicData.NumLearnt + "/" + Manage.TopicData.WordList.Count);
			tlt_Info.SetToolTip(pnl_LearntValue, Manage.TopicData.NumLearnt + "/" + Manage.TopicData.WordList.Count);

			tlt_Info.SetToolTip(pnl_Right, Manage.TopicData.RightWords.Count + "/" + Manage.TopicData.NumLearnt);
			tlt_Info.SetToolTip(pnl_RightValue, Manage.TopicData.RightWords.Count + "/" + Manage.TopicData.NumLearnt);

			tlt_Info.SetToolTip(pnl_Wrong, Manage.TopicData.WrongWords.Count + "/" + Manage.TopicData.NumLearnt);
			tlt_Info.SetToolTip(pnl_WrongValue, Manage.TopicData.WrongWords.Count + "/" + Manage.TopicData.NumLearnt);
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

		private void pnl_Learn_Click(object sender, EventArgs e)
		{

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

		}

		#endregion

		#region pnl_Content
		private void pnl_Learnt_MouseHover(object sender, EventArgs e)
		{
			tlt_Info.SetToolTip((Panel)sender, "3/25");
		}

		private void pnl_Info_Paint(object sender, PaintEventArgs e)
		{
			if (Manage.TopicData.NumLearnt != 0)
				pnl_LearntValue.Width = (pnl_LearntValue.MaximumSize.Width / Manage.TopicData.WordList.Count) * Manage.TopicData.NumLearnt;
			else pnl_LearntValue.Width = 2;

			if (Manage.TopicData.RightWords.Count != 0)
				pnl_RightValue.Width = (pnl_LearntValue.Width / Manage.TopicData.NumLearnt) * Manage.TopicData.RightWords.Count;
			else pnl_RightValue.Width = 2;

			if (Manage.TopicData.WrongWords.Count != 0)
				pnl_WrongValue.Width = (pnl_LearntValue.Width / Manage.TopicData.NumLearnt) * Manage.TopicData.WrongWords.Count;
			else pnl_WrongValue.Width = 2;
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
