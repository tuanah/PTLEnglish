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
		//Biến index: Dùng để lưu giá trị (theo ListRandom) của từ khi truyền vào để tái sử dụng khi cần
		//Biến word: Dùng để lưu từ với vị trí (theo WordList) và xử lý trên nó cho tiện, không cần . .
		//Khi word thay đổi (Hàm Check được sử dụng) thì gán lại cho từ với vị trí Index trong WordList để lưu xuống file
		//Biến next: Dùng để lưu chỉ số của từ tiếp theo trong ListRandom, để xác định từ tiếp theo cần học 
		//Mảng btn: Chứa 4 cái Button để Click chọn
		//Mảng random: Chứa vị trí các từ (theo WordList) trong đó có vị trí 1 từ là đúng
		//Biến pnl: Là biến pnl trong fSub, dùng khi chuyển User Control (pic_Next_Click)
		Word word;
		int index;
		int next;
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
			next = i++;

			for (int j = 0; j < 4; j++)
			{
				btn[j] = new RoundBtn();
				btn[j].Cursor = Cursors.Hand;
				this.Controls.Add(btn[j]);
			}
		}
		private void UC_Learn_Choose_Load(object sender, EventArgs e)
		{
			lbl_Key.Text = word.Key;
			Manage.reader.SpeakAsync(lbl_Key.Text);

			btn[0].Location = new Point(37, 45);
			btn[1].Location = new Point(275, 45);
			btn[2].Location = new Point(37, 109);
			btn[3].Location = new Point(275, 109);

			random[0] = index;
			for (int i = 0; i < 3; i++)
			{
				do
				{
					random[i + 1] = Cons.rand.Next(25);
				} while (CheckExist(random[i + 1], i + 1));
			}

			Shuffle();
			for (int i = 0; i < 4; i++)
			{
				btn[i].Text = Manage.TopicData.WordList[random[i]].Mean;
				btn[i].Click += UC_Learn_Choose_Click;
			}
		}

		private void UC_Learn_Choose_Click(object sender, EventArgs e)
		{
			//Ý tưởng
			//Hiển thị đáp án (Hàm ShowAnswer)
			//Kiểm tra xem Button được Click có phải là từ đúng hay không và tăng số lần đúng sai tương ứng
			//Enable cho PictureBox Next
			//Gán giá trị của biến word vào ListWord với vị trí tương ứng để lưu xuống file

			ShowAnswer();
			RoundBtn btn = sender as RoundBtn;
			if (btn.Text == word.Mean)
			{
				word.NumRight++;
			}
			else
			{
				word.NumWrong++;
			}
			pic_Next.Enabled = true;
			Manage.TopicData.WordList[index] = word;
		}

		private void pic_Next_Click(object sender, EventArgs e)
		{
			//Ý tưởng 
			//Biến randomUC: chứa giá trị enum của Manage.UC
			//Đầu tiên kiểm tra xem User Control này có đang sử dụng cho phần Check hay không
			//Nếu có thì Show User Control (enum randomUC vừa mới tạo) với giá trị trị truyền vào là vị trí của từ tiếp theo trong danh sách
			//Nếu không thì tăng biến Time để xác định số lần xuất hiện của User Control trong Learnt
			//---------Ý tưởng thứ tự Show User Control trong phần Learn
			//----Đầu tiên sẽ hiển thị Khung học UC_Learn, sau đó là sẽ Show UC_Learn_Type để học từ mới vừa được học
			//----Lặp 3 lần như thế, Khi từ đã học được 3 rồi, thì Sau khi show UC_Learn_Type sẽ có thêm User Control được random
			//---------với giá trị truyền vào là vị trí trong listRandom với từ 0 --> Progress - 1 
			int randomUC;
			randomUC = Cons.rand.Next(1, 4);
			if (Manage.CheckUseTest)
			{
				Manage.ShowUC(pnl, (Manage.UC)randomUC, Manage.TopicData.Learnt.ListRandom[next], 60, 170);
			}
			else
			{
				Manage.Times++;
				if (Manage.Times <= 2 && Manage.TopicData.Learnt.Progress >= 3)
				{
					if (Manage.Times == 1)
					{
						Manage.ShowUC(pnl, Manage.UC.UC_Learn_Type, Manage.TopicData.Learnt.ListRandom[Manage.TopicData.Learnt.Progress - 1], 70, 190);
					}
					else
					{
						int ran;
						ran = Cons.rand.Next(Manage.TopicData.Learnt.Progress - 1);
						Manage.ShowUC(pnl, (Manage.UC)randomUC, ran, 70, 190);
					}
				}
				else
				{
					Manage.ShowUC(pnl, Manage.UC.UC_Learn, Manage.TopicData.Learnt.Progress, 70, 190);
				}
			}
		}

		/// <summary>
		/// Kiểm tra trùng trong Mảng random
		/// </summary>
		/// <param name="para">giá trị cần kiểm tra</param>
		/// <param name="present">vị trí hiện tại của giá trị đang kiểm tra</param>
		/// <returns></returns>
		private bool CheckExist(int para, int present)
		{
			for (int i = 0; i < present; i++)
			{
				if (random[i] == para)
					return true;
			}
			return false;
		}

		/// <summary>
		/// Trộn mảng random
		/// </summary>
		private void Shuffle()
		{
			int index;
			int temp;
			for (int i = 0; i < btn.Length; i++)
			{
				index = Cons.rand.Next(4);

				temp = random[index];
				random[index] = random[i];
				random[i] = temp;
			}
		}

		/// <summary>
		/// Hàm hiển thị đáp án
		/// </summary>
		private void ShowAnswer()
		{
			//---- Ý tưởng
			//---- Duyệt từng phần tử trong mảng btn và so sánh btn[i].Text với word.Mean
			//---- Nếu đúng thì đổi BackColor của btn[i] thành màu xanh, ngược lại là màu đỏ
			//---- Disable từng phần tử trong mảng btn, mục đích là ngăn việc chọn nhiều lần 
			for (int i = 0; i < btn.Length; i++)
			{
				if(btn[i].Text == word.Mean)
				{
					btn[i].BackColor = Color.ForestGreen;
				}
				else
				{
					btn[i].BackColor = Color.IndianRed;
				}
				btn[i].Enabled = false;
			}
		}

	}
}
