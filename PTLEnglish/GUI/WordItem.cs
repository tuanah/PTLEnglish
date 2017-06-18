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
using System.Reflection;

namespace PTLEnglish.GUI
{
	public partial class WordItem : UserControl
	{
		Word word;
		int index;

		public WordItem()
		{
			InitializeComponent();
		}

		public WordItem(int i)
		{
			InitializeComponent();
			index = i;
			word = new Word();
			word = Manage.TopicData.WordList[i];

			this.Load += WordItem_Load;
		}

		private void WordItem_Load(object sender, EventArgs e)
		{
			lbl_Score.Text = (word.NumRight - word.NumWrong).ToString();
			if (word.NumWrong == 0)
			{
				lbl_Score.ForeColor = Color.Green;
			}
			else if ( word.NumWrong == 1)
			{
				lbl_Score.ForeColor = Color.Goldenrod;
			}
			else
				lbl_Score.ForeColor = Color.OrangeRed;

			lbl_Key.Text = word.Key + '\n' + '/' + word.Pronunciation + '/';

			try
			{
				pic_Key.Image = Image.FromFile(word.ImgPath);
			}
			catch
			{
				pic_Key.Image = pic_Key.ErrorImage;
			}
			lbl_Mean.Text = word.Mean;

			if (word.IsHard)
			{
				pic_Hard.Image = global::PTLEnglish.Properties.Resources.flash_clk;
			}
			else
			{
				pic_Hard.Image = global::PTLEnglish.Properties.Resources.flash;
			}
			SetTooltipScore();
		}

		private void AutoFontSize(Control ctrl)
		{
			SizeF stringSize = new SizeF();
			//Get Size của tất cả các chữ
			stringSize = TextRenderer.MeasureText(ctrl.Text, ctrl.Font);
			if (stringSize.Width > ctrl.Width - 10)
			{
				while (stringSize.Width > ctrl.Width - 10)
				{
					float emSize = ctrl.Font.Size;
					emSize--;
					ctrl.Font = new Font(ctrl.Font.Name, emSize);
					stringSize = TextRenderer.MeasureText(ctrl.Text, ctrl.Font);
				}
			}
			else while (stringSize.Width < ctrl.Width-20)
				{
					float emSize = ctrl.Font.Size;
					if (emSize > 25)
					{
						return;
					}
					emSize++;
					ctrl.Font = new Font(ctrl.Font.Name, emSize);
					stringSize = TextRenderer.MeasureText(ctrl.Text, ctrl.Font);
				}

		}

		private void lbl_Score_ClientSizeChanged(object sender, EventArgs e)
		{
			AutoFontSize((Label)sender);
		}

		private void pic_Hard_Click(object sender, EventArgs e)
		{
			PictureBox pic = sender as PictureBox;
			Manage.TopicData.WordList[index].IsHard = !Manage.TopicData.WordList[index].IsHard;
			if (word.IsHard)
			{
				pic.Image = global::PTLEnglish.Properties.Resources.flash_clk;
			}
			else
			{
				pic.Image = global::PTLEnglish.Properties.Resources.flash;
			}
		}

		private void pic_Spell_Click(object sender, EventArgs e)
		{
			Manage.reader.SelectVoiceByHints(System.Speech.Synthesis.VoiceGender.Female);
			Manage.reader.SpeakAsync(word.Key);
		}

		private void SetTooltipScore()
		{
			ToolTip tlt = new ToolTip();
			tlt.SetToolTip(lbl_Score, "Correct: " + word.NumRight + " times\nMissed: "+word.NumWrong + " times");
		}
	}
}
