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
		private bool isLearnt;
		private string imgPath;

		public string Key { get => key; set => key = value; }
		public string Pronunciation { get => pronunciation; set => pronunciation = value; }
		public string Mean { get => mean; set => mean = value; }
		public bool IsLearnt { get => isLearnt; set => isLearnt = value; }
		public string ImgPath { get => imgPath; set => imgPath = value; }
	}
}
