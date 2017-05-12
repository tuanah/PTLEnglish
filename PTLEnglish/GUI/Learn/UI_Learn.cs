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
	public partial class UI_Learn : UserControl
	{
		Word word;
		public UI_Learn()
		{
			InitializeComponent();
		}

		public UI_Learn(int i)
		{
			word = new Word();
			word = Manage.TopicData.WordList[i];
		}
	}
}
