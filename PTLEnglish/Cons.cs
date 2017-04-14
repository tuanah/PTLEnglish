﻿using System;
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
		/// Path of directory saved data
		/// </summary>
		public static string Path = "Data";

		public static Color Hover = Color.FromArgb(222, 237, 255);
		public static Color _Gray = Color.FromArgb(174, 174, 174);

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
