using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTLEnglish.DAL
{
	public class Word
	{
		private string key;
		private string pronunciation;
		private string mean;
		//private bool isLearnt;
		private string imgPath;
		private byte numWrong;
		private byte numRight;
		private bool isHard;

		public string Key { get => key; set => key = value; }
		public string Pronunciation { get => pronunciation; set => pronunciation = value; }
		public string Mean { get => mean; set => mean = value; }
		//public bool IsLearnt { get => isLearnt; set => isLearnt = value; }
		public string ImgPath { get => imgPath; set => imgPath = value; }
		public byte NumWrong { get => numWrong; set => numWrong = value; }
		public byte NumRight { get => numRight; set => numRight = value; }
		public bool IsHard { get => isHard; set => isHard = value; }
	}
}
