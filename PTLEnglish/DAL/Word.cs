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
		private string imgPath;
		private byte numWrong;
		private byte numRight;
		private bool isHard;

		/// <summary>
		/// String Tiếng Anh
		/// </summary>
		public string Key { get => key; set => key = value; }
		/// <summary>
		/// String Phiên âm
		/// </summary>
		public string Pronunciation { get => pronunciation; set => pronunciation = value; }
		/// <summary>
		/// String nghĩa Tiếng Việt
		/// </summary>
		public string Mean { get => mean; set => mean = value; }
		/// <summary>
		/// Địa chỉ hình ảnh
		/// </summary>
		public string ImgPath { get => imgPath; set => imgPath = value; }
		/// <summary>
		/// Số lần sai của từ
		/// </summary>
		public byte NumWrong { get => numWrong; set => numWrong = value; }
		/// <summary>
		/// Số lần đúng của từ
		/// </summary>
		public byte NumRight { get => numRight; set => numRight = value; }
		public bool IsHard { get => isHard; set => isHard = value; }
	}
}
