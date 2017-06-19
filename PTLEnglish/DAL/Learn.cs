using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTLEnglish.DAL
{
	public class Learn
	{
		private int progress;
		private int correctWords;
		private int wrongWords;
		private List<int> listRandom;
		private List<int> listWrongWord;
		/// <summary>
		/// Số từ đã được học. Tính theo danh sách Random trong ListRandom
		/// </summary>
		public int Progress { get => progress; set => progress = value; }
		public int CorrectWords { get => correctWords; set => correctWords = value; }
		public List<int> ListRandom { get => listRandom; set => listRandom = value; }
		public List<int> ListWrongWord { get => listWrongWord; set => listWrongWord = value; }
		public int WrongWords { get => wrongWords; set => wrongWords = value; }

		public Learn()
		{
			progress = 0;
			correctWords = 0;
			wrongWords = 0;
			listRandom = new List<int>();
			listWrongWord = new List<int>();
		}

		public List<int> AddNumberIntoList()
		{
			List<int> lInt = new List<int>();
			for (int i = 0; i < Manage.TopicData.WordList.Count; i++)
				lInt.Add(i);
			return lInt;
		}

		/// <summary>
		/// Tạo danh sách random chứa vị trí các từ trong WordList dùng để học
		/// </summary>
		public void RandomListWord()
		{
			List<int> lInt = AddNumberIntoList();
			Random rand = new Random();
			listRandom = new List<int>();
			while (listRandom.Count != Manage.TopicData.WordList.Count)
			{
				// Chọn ngẫu nhiên 1 phần tử 
				int temp = rand.Next(0, lInt.Count);
				// Lấy giá trị 
				int index = lInt[temp];
				// Xóa phần tử đã được random ra khỏi lInt
				lInt.Remove(index);
				// Lưu giá trị random vào listRandom
				listRandom.Add(index);
			}
		}

	}
}
