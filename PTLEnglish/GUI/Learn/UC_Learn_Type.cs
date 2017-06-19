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
		//Biến index: Dùng để lưu giá trị (theo ListRandom) của từ khi truyền vào để tái sử dụng khi cần
		//Biến word: Dùng để lưu từ với vị trí (theo WordList) và xử lý trên nó cho tiện, không cần . .
		//Khi word thay đổi (Hàm Check được sử dụng) thì gán lại cho từ với vị trí Index trong WordList để lưu xuống file
		//Biến next: Dùng để lưu chỉ số của từ tiếp theo trong ListRandom, để xác định từ tiếp theo cần học 
		//Biến pnl: Là biến pnl trong fSub, dùng khi chuyển User Control (pic_Next_Click)

		int index;
		int next;
		Word word;
		public static Panel pnl = new Panel();

		public UC_Learn_Type()
		{
			InitializeComponent();
		}

		public UC_Learn_Type(int i)
		{
			InitializeComponent();
			word = new Word();
			index = Manage.TopicData.Learnt.ListRandom[i];
			next = i++;
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
			//Bắt sự kiện nhấn Enter
			if (e.KeyChar == (char)13)
			{
				pic_Check_Click(txt_Ans, e);
			}
		}

		private void pic_Check_Click(object sender, EventArgs e)
		{
			//--- Ý tưởng
			// pic_Check.Enabled kiểm tra xem nó có phải là lần đầu tiên Check hay không, nếu không thì return
			// nếu có thì chuẩn hóa chuỗi, và kiểm tra với đáp án và cập nhật các giá trị đúng sai tương ứng cho từ
			// Set thuộc tính ReadOnly cho cái textbox, để không nhận sự kiện Press Enter nữa
			// Disable cho PictureBox Check
			// Gán word vào WordList với vị trí tương ứng để lưu xuống file
			if (pic_Check.Enabled)
			{
				txt_Ans.Text = txt_Ans.Text.Trim();
				while(txt_Ans.Text.Contains("  "))
				{
					txt_Ans.Text = txt_Ans.Text.Replace("  ", " ");
				}
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
				pic_Next.Enabled = true;
				pic_Check.Enabled = false;
				Manage.TopicData.WordList[index] = word;
			}
		}

		private void pic_Next_Click_1(object sender, EventArgs e)
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
				if (Manage.Times <= 2)
				{
					if(Manage.Times == 1)
					{
						Manage.ShowUC(pnl, Manage.UC.UC_Learn_Type , Manage.TopicData.Learnt.ListRandom[Manage.TopicData.Learnt.Progress - 1], 70, 190);
					}
					else
					{
						if(Manage.TopicData.Learnt.Progress >= 3)
						{
							int ran;
							ran = Cons.rand.Next(Manage.TopicData.Learnt.Progress - 1);
							Manage.ShowUC(pnl, (Manage.UC)randomUC, ran, 70, 190);
						}
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
