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
	public partial class UC_Learn : UserControl
	{
		//Biến index dùng để lưu giá trị (theo ListRandom) của từ khi truyền vào để tái sử dụng khi cần
		//word dùng để lưu từ với vị trí (theo WordList) và xử lý trên nó cho tiện, không cần . .
		int index;
		Word word;
		public static Panel pnl = new Panel();
		public UC_Learn()
		{
			InitializeComponent();
		}

		public UC_Learn(int i)
		{
			InitializeComponent();
			word = new Word();
			index = Manage.TopicData.Learnt.ListRandom[i];
			word = Manage.TopicData.WordList[index];
			Manage.Times = 0;
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

		private void pic_Next_Click(object sender, EventArgs e)
		{

			Manage.Times++;
			Manage.ShowUC(pnl, Manage.UC.UC_Learn_Type, Manage.TopicData.Learnt.Progress, 70, 190);
			// tăng số từ đã được học lên (tính theo ListRandom)
			Manage.TopicData.Learnt.Progress++;
		}
	}
}
