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
	public partial class UC_Learn_Choose : UserControl
	{
		Word word;
		int index;
		RoundBtn[] btn = new RoundBtn[4];
		int[] random = new int[4];
		public static Panel pnl = new Panel();
		public UC_Learn_Choose()
		{
			InitializeComponent();
		}

		public UC_Learn_Choose(int i)
		{
			InitializeComponent();
			word = new Word();
			index = Manage.TopicData.Learnt.ListRandom[i];
			word = Manage.TopicData.WordList[index];

			for (int j = 0; j < 4; j++)
			{
				btn[j] = new RoundBtn();
				this.Controls.Add(btn[j]);
			}

			btn[0].Location = new Point(37, 45);
			btn[1].Location = new Point(275, 45);
			btn[2].Location = new Point(37, 109);
			btn[3].Location = new Point(275, 109);

		}
		private void UC_Learn_Choose_Load(object sender, EventArgs e)
		{
			lbl_Key.Text = word.Key;
			Manage.reader.SpeakAsync(lbl_Key.Text);
			Random rand = new Random();
			random[0] = rand.Next(4);
		}

		private void pic_Next_Click(object sender, EventArgs e)
		{
			Manage.ShowUC(pnl, Manage.UC.UC_Learn_Choose, ++index, 60, 170);
		}
	}
}
