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
	public partial class UC_Learn_Shuffle : UserControl
	{
		//Biến index: Dùng để lưu giá trị (theo ListRandom) của từ khi truyền vào để tái sử dụng khi cần
		//Biến word: Dùng để lưu từ với vị trí (theo WordList) và xử lý trên nó cho tiện, không cần . .
		//Khi word thay đổi (Hàm Check được sử dụng) thì gán lại cho từ với vị trí Index trong WordList để lưu xuống file
		//Biến next: Dùng để lưu chỉ số của từ tiếp theo trong ListRandom, để xác định từ tiếp theo cần học 
		//Mảng btn: Chứa 4 cái Button để Click chọn
		//Biến pnl: Là biến pnl trong fSub, dùng khi chuyển User Control (pic_Next_Click)

		Word word;
		int index;
		int next;
		RoundBtn[] btn = new RoundBtn[4];
		public static Panel pnl = new Panel();

		public UC_Learn_Shuffle()
		{
			InitializeComponent();
		}
		public UC_Learn_Shuffle(int i)
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
				btn[j].Text = word.Key;
				this.Controls.Add(btn[j]);
			}
		}

		private void UC_Learn_Shuffle_Load(object sender, EventArgs e)
		{
			lbl_Key.Text = word.Mean;
			Manage.reader.SpeakAsync(lbl_Key.Text);

			btn[0].Location = new Point(37, 45);
			btn[1].Location = new Point(275, 45);
			btn[2].Location = new Point(37, 109);
			btn[3].Location = new Point(275, 109);
			//Gán text đúng cho vị trí đầu tiên
			btn[0].Text = word.Key;
			for (int i = 0; i < 4; i++)
			{
				btn[i].Click += UC_Learn_Shuffle_Click;
				//Gán đoạn text đã được trộn vào vị trí thứ i
				if (i != 0)
					btn[i].Text = Shuffle(btn[i].Text);
			}
			Shuffle();
		}

		private void UC_Learn_Shuffle_Click(object sender, EventArgs e)
		{
			//Ý tưởng
			//Hiển thị đáp án (Hàm ShowAnswer)
			//Kiểm tra xem Button được Click có phải là từ đúng hay không và tăng số lần đúng sai tương ứng
			//Enable cho PictureBox Next
			//Gán giá trị của biến word vào ListWord với vị trí tương ứng để lưu xuống file

			ShowAnswer();
			RoundBtn btn = sender as RoundBtn;
			if (btn.Text == word.Key)
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

		private void Swap(ref List<char> chars, int a,int b)
		{
			char temp;
			temp = chars[a];
			chars[a] = chars[b];
			chars[b] = temp;
		}

		/// <summary>
		/// Trộn chuỗi
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		private string Shuffle(string str)
		{
			//---- Ý tưởng
			// Khởi tạo 2 số random khác nhau, một mảng char chứa các từ trong chuỗi str
			// Hoán đổi giá trị của 2 vị trí random đó
			// return về 1 chuỗi được tạo sau khi hoán đổi
			int index, ind;
			List<char> chars = new List<char>(str);
			StringBuilder sb = new StringBuilder();

			index = Cons.rand.Next(1,chars.Count);
			do
			{
				ind = Cons.rand.Next(1,chars.Count);
			} while (index == ind);
			Swap(ref chars, index, ind);

			for (int i = 0; i < chars.Count; i++)
			{
				sb.Append(chars[i]);
			}
			chars.Clear();

			return sb.ToString();
		}

		/// <summary>
		/// Trộn mảng btn
		/// </summary>
		private void Shuffle()
		{
			int index;
			string temp;
			for (int i = 0; i < btn.Length; i++)
			{
				index = Cons.rand.Next(4);

				temp = btn[index].Text;
				btn[index].Text = btn[i].Text;
				btn[i].Text = temp;
			}
		}

		/// <summary>
		/// Hiển thị đáp án
		/// </summary>
		private void ShowAnswer()
		{
			//---- Ý tưởng
			//---- Duyệt từng phần tử trong mảng btn và so sánh btn[i].Text với word.Mean
			//---- Nếu đúng thì đổi BackColor của btn[i] thành màu xanh, ngược lại là màu đỏ
			//---- Disable từng phần tử trong mảng btn, mục đích là ngăn việc chọn nhiều lần 

			for (int i = 0; i < btn.Length; i++)
			{
				if (btn[i].Text == word.Key)
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
	}
}
