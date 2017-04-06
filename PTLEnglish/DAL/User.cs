using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PTLEnglish.DAL
{
	public static class User
	{
		private static string userName;
		private static string userAvaPath;

		public static string UserName { get => userName; set => userName = value; }
		public static string UserAvaPath { get => userAvaPath; set => userAvaPath = value; }

		public static void Init()
		{
			using (FileStream fs = new FileStream(Cons.Path + @"\info.txt", FileMode.OpenOrCreate))
			{
				using (StreamReader sReader = new StreamReader(fs, Encoding.UTF8))
				{
					int i = 0;
					string line;
					while (!sReader.EndOfStream)
					{
						line = sReader.ReadLine();
						switch (i)
						{
							case 0: userName = line; break;
							case 1: userAvaPath = line; break;
							default:
								break;
						}
						i++;
					}
				}
			}
		}

		public static void Save()
		{
			using (FileStream fs = new FileStream(Cons.Path + @"\info.txt", FileMode.Create))
			{
				using (StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8))
				{
					sWriter.WriteLine(userName);
					sWriter.WriteLine(userAvaPath);
				}
			}
		}
	}
}
