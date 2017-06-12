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
	public partial class UC_Learn_0 : UserControl
	{
		int index;
		Word word;
		public UC_Learn_0()
		{
			InitializeComponent();
		}

		public UC_Learn_0(int i)
		{
			InitializeComponent();
			word = new Word();
			index = i;
			word = Manage.TopicData.WordList[i];
		}

		private void UC_Learn_0_Load(object sender, EventArgs e)
		{
			lbl_Word.Text = word.Key;
			lbl_Pronun.Text = "/"+word.Pronunciation+"/";
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
		}

		private void pic_Spell_Click(object sender, EventArgs e)
		{
			Manage.reader.SpeakAsync(lbl_Word.Text);
		}
	}
}
