using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace PTLEnglish
{
	public static class Cons
	{
		private static DirectoryInfo Dir;
		public static DirectoryInfo[] CourseDir;
		private static DirectoryInfo[] topicDir;

		/// <summary>
		/// Đường dẫn của thư mục Dữ liệu
		/// </summary>
		public static string Path = "Data";

		public static Color ColorHov = Color.FromArgb(222, 237, 255);
		public static Color ColorGray = Color.FromArgb(174, 174, 174);

		/// <summary>
		/// Hexagon size
		/// </summary>
		public static int Size = 125;
		public static int numOfCol = 5;
		public static int numOfRow = 4;

		public static Random rand = new Random();

		public static DirectoryInfo[] TopicDir { get => topicDir; set => topicDir = value; }

		public static void LoadTopicDir(DirectoryInfo courseDir)
		{
			TopicDir = courseDir.GetDirectories();
		}

		public static void LoadDir()
		{
			if(!Directory.Exists("Source"))
			{
				Directory.CreateDirectory("Source");
			}
			Dir = new DirectoryInfo("Source");
			CourseDir = Dir.GetDirectories();
		}
	}
}
