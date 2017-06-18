using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTLEnglish.DAL;


namespace PTLEnglish.GUI.Learn
{
	public partial class UC_Learn_Type : UserControl
	{
		int index;
		Word word;

		public UC_Learn_Type()
		{
			InitializeComponent();
		}

		public UC_Learn_Type(int i)
		{
			InitializeComponent();
			word = new Word();
			index = Manage.TopicData.Learnt.ListRandom[i];
			word = Manage.TopicData.WordList[index];
		}

		private void UC_Learn_1_Load(object sender, EventArgs e)
		{
			lbl_Word.Text = word.Key;
			lbl_Pronun.Text = "/" + word.Pronunciation + "/";
			lbl_Mean.Text = word.Mean;
			try
			{
				pic.Image = Image.FromFile(word.ImgPath);
			}
			catch
			{
				pic.Image = pic.ErrorImage;
			}
			Manage.reader.SpeakAsync(lbl_Word.Text);
			txt_Ans.Focus();
		}

		private void pic_Spell_Click(object sender, EventArgs e)
		{
			Manage.reader.SpeakAsync(lbl_Word.Text);
		}

		private void txt_Ans_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13)
			{
				pic_Check_Click(txt_Ans, e);
			}
		}

		public static Panel pnl = new Panel();

		private void pic_Check_Click(object sender, EventArgs e)
		{
			if (txt_Ans.Text.ToLower() == word.Mean.ToLower())
			{
				txt_Ans.ForeColor = Color.Green;
				pnl_Underline.BackColor = Color.Green;
				lbl_Type.ForeColor = Color.Green;
				lbl_Correct.Visible = true;
				lbl_Mean.Visible = false;
				lbl_Wrong.Visible = false;
				word.NumRight++;
				if (index == Manage.TopicData.Learnt.ListRandom[Manage.TopicData.Learnt.Progress - 1])
					Manage.TopicData.Learnt.CorrectWords++;
			}
			else
			{
				txt_Ans.ForeColor = Color.Red;
				pnl_Underline.BackColor = Color.Red;
				lbl_Type.ForeColor = Color.Red;
				lbl_Correct.Visible = false;
				lbl_Wrong.Visible = true;
				lbl_Mean.Visible = true;
				word.NumWrong++;
				if (index == Manage.TopicData.Learnt.ListRandom[Manage.TopicData.Learnt.Progress - 1])
				{
					Manage.TopicData.Learnt.WrongWords++;
					Manage.TopicData.Learnt.ListWrongWord.Add(index);
				}
			}
			txt_Ans.ReadOnly = true;
			Manage.TopicData.WordList[index] = word;
		}

		private void pic_Next_Click_1(object sender, EventArgs e)
		{
			if (Manage.CheckUseTest)
			{
				Manage.ShowUC(pnl, Manage.UC.UC_Learn_Choose, ++index, 60, 170);
			}
			else
			{
				Manage.Times++;
				if (Manage.Times < 2)
				{
					int ran;
					ran = Cons.rand.Next(Manage.TopicData.Learnt.Progress - 1);
					Manage.ShowUC(pnl, Manage.UC.UC_Learn_Type, Manage.TopicData.Learnt.ListRandom[ran], 70, 190);
				}
				else
				{
					Manage.ShowUC(pnl, Manage.UC.UC_Learn, Manage.TopicData.Learnt.Progress, 70, 190);
				}
			}
		}
	}
}
