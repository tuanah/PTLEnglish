using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTLEnglish.DAL
{
	public class Learn
	{
		private int progress = 0;
		private int correctWords = 0;
		private int wrongWords = 0;
		private List<int> listRandom = new List<int>();
		private List<int> listWrongWord = new List<int>();
		public int Progress { get => progress; set => progress = value; }
		public int CorrectWords { get => correctWords; set => correctWords = value; }
		public List<int> ListRandom { get => listRandom; set => listRandom = value; }
		public List<int> ListWrongWord { get => listWrongWord; set => listWrongWord = value; }
		public int WrongWords { get => wrongWords; set => wrongWords = value; }

		public List<int> AddNumberIntoList()
		{
			List<int> lInt = new List<int>();
			for (int i = 0; i < Manage.TopicData.WordList.Count; i++)
				lInt.Add(i);
			return lInt;
		}

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
