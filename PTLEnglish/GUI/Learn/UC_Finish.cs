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
using System.IO;

namespace PTLEnglish.GUI.Learn
{
	public partial class UC_Finish : UserControl
	{
		RoundBtn btn_Start, btn_Show;
		public static Panel pnl = new Panel();


		public UC_Finish()
		{
			InitializeComponent();
		}

		private void UC_Finish_Load(object sender, EventArgs e)
		{
			btn_Show = new RoundBtn();
			btn_Show.Location = new Point(290, 90);
			btn_Show.Text = "Show Missed Words";
			btn_Show.Size = new Size(175, 40);
			btn_Show.Cursor = Cursors.Hand;
			btn_Show.Click += Btn_Show_Click;
			this.Controls.Add(btn_Show);

			btn_Start = new RoundBtn();
			btn_Start.Location = new Point(130, 90);
			btn_Start.Text = "Learn Again";
			btn_Start.Size = new Size(125, 40);
			btn_Start.Cursor = Cursors.Hand;
			btn_Start.Click += Btn_Start_Click;
			this.Controls.Add(btn_Start);
		}

		private void Btn_Show_Click(object sender, EventArgs e)
		{
			//Ý tưởng
			//Di chuyển User Control từ giữa lên cạnh trên
			//Tạo FlowLayoutPanel hiển thị danh sách các từ sai
			Animation.Move(this, new Point(70, 10), Animation.Duration.Normal);

			pnl.BackColor = SystemColors.ControlLight;

			Label lbl = new Label();
			lbl.Text = "Missed Words";
			lbl.Font = new Font("Microsoft Tai Le", 12);
			lbl.AutoSize = true;
			lbl.ForeColor = Color.IndianRed;
			lbl.Location = new Point(10, 20 + ClientSize.Height);
			pnl.Controls.Add(lbl);

			//Panel chứa các từ đã sai(lần đầu tiên) trong khi học
			FlowLayoutPanel fpnl = new FlowLayoutPanel();
			fpnl.Location = new Point(10, 20 + ClientSize.Height + lbl.Height + 5);
			fpnl.Width = pnl.Width - 20;
			
			pnl.Controls.Add(fpnl);

			foreach (int i in Manage.TopicData.Learnt.ListWrongWord)
			{
				WordItem item = new WordItem(i);
				fpnl.Controls.Add(item);
			}
			fpnl.Height = fpnl.Controls.Count * 105;
			//Khởi tạo Maximumsize để Scroll Panel
			fpnl.MaximumSize = new Size(pnl.Width, pnl.Height - 40 - this.Height - lbl.Height);

			//Disable các thanh Scroll dọc và ngang
			fpnl.HorizontalScroll.Enabled = false;
			fpnl.HorizontalScroll.Visible = false;
			fpnl.HorizontalScroll.Maximum = 0;

			fpnl.VerticalScroll.Enabled = false;
			fpnl.VerticalScroll.Visible = false;
			fpnl.VerticalScroll.Maximum = 0;
			fpnl.AutoScroll = true;

		}

		private void Btn_Start_Click(object sender, EventArgs e)
		{
			//Ý tưởng
			//Khởi tạo lại các thuộc tính
			//Serialize xuống 
			//Chạy Learn_Click trong fSub;

			Manage.TopicData.Learnt.CorrectWords = 0; // Từ đúng
			Manage.TopicData.Learnt.WrongWords = 0; // Từ sai
			Manage.TopicData.Learnt.Progress = 0; // Tiến trình học
			Manage.TopicData.Learnt.ListRandom = new List<int>(); // Danh sách Random
			Manage.TopicData.Learnt.RandomListWord();
			Manage.TopicData.Learnt.ListWrongWord = new List<int>(); // Danh sách từ sai

			Manage.SerializeToXML(Manage.TopicData, Cons.Path + Manage.ThisTopic + ".xml");
			// this.Parent --> pnl
			// pnl.parent --> fsub
			fSub Sub = this.Parent.Parent as fSub;
			Sub.pnl_Learn_Click(sender, e);
		}
	}
}
