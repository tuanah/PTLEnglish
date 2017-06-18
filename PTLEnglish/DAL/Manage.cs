using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.Drawing;
using PTLEnglish.GUI;
using System.Speech.Synthesis;
using PTLEnglish.GUI.Learn;
using System.Threading;

namespace PTLEnglish.DAL
{
	public static class Manage
	{
		private static Topic topicData;

		private static string thisCourse = "Source";

		private static string thisTopic = "\\";

		private static bool checkUseTest;
		private static int times;
		public enum UC
		{
			UC_Learn,
			UC_Learn_Type,
			UC_Learn_Choose
		}

		public static SpeechSynthesizer reader = new SpeechSynthesizer();

		public static Topic TopicData { get => topicData; set => topicData = value; }
		public static string ThisCourse { get => thisCourse; set => thisCourse = value; }
		public static string ThisTopic { get => thisTopic; set => thisTopic = value; }
		public static bool CheckUseTest { get => checkUseTest; set => checkUseTest = value; }
		public static int Times { get => times; set => times = value; }

		private static Word stringHandling(string line)
		{
			Word word = new Word();
			string[] wordInfo = new string[3];
			line = line.Replace('\t', ' ');
			wordInfo = line.Split('/');
			word.Key = wordInfo[0].TrimEnd();
			word.Pronunciation = wordInfo[1];
			word.Mean = wordInfo[2].TrimStart();

			return word;
		}

		public static void LoadData(DirectoryInfo Dir)
		{
			Word word = new Word();
			TopicData = new Topic();
			TopicData.WordList = new List<Word>();
			string line;
			FileInfo[] file = Dir.GetFiles();
			FileStream fStream = new FileStream(file[0].FullName, FileMode.Open);
			StreamReader sRead = new StreamReader(fStream, Encoding.UTF8);

			TopicData.TopicName = Dir.Name;

			while (!sRead.EndOfStream)
			{
				line = sRead.ReadLine();
				if (line != "" && line[0] != ' ' && line[0] != '\t')
				{
					word = stringHandling(line);
					word.ImgPath = Dir.FullName + "\\Image\\" + word.Key.Replace(' ', '_') + ".jpg";
					TopicData.WordList.Add(word);
				}
			}
			sRead.Close();
			fStream.Close();
		}

		public static void LoadData(string path)
		{
			Word word = new Word();
			TopicData = new Topic();
			TopicData.WordList = new List<Word>();
			TopicData.Learnt = new Learn();
			string line;
			DirectoryInfo Dir = new DirectoryInfo(path);
			FileInfo[] file = Dir.GetFiles();
			using (FileStream fstream = new FileStream(file[0].FullName, FileMode.Open))
			{
				using (StreamReader sRead = new StreamReader(fstream, Encoding.UTF8))
				{
					TopicData.TopicName = Dir.Name;

					while (!sRead.EndOfStream)
					{
						line = sRead.ReadLine();
						if (line != "" && line[0] != ' ' && line[0] != '\t')
						{
							word = stringHandling(line);
							word.ImgPath = Dir.FullName + "\\Image\\" + word.Key.Replace(' ', '_') + ".jpg";
							TopicData.WordList.Add(word);
						}
					}
				}
			}
		}

		public static void SerializeToXML(object data, string filePath)
		{
			FileStream fstream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
			XmlSerializer sr = new XmlSerializer(typeof(Topic));
			sr.Serialize(fstream, data);
			fstream.Close();
		}

		public static object DeserializeFromXML(string filePath)
		{
			FileStream fstream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
			XmlSerializer sr = new XmlSerializer(typeof(Topic));
			object obj = sr.Deserialize(fstream);
			fstream.Close();
			return obj;
		}

		public static void ShowUC(Control Ctrl, UC uc, int index, int X, int Y)
		{
			Ctrl.Controls.Clear();
			switch (uc)
			{
				case UC.UC_Learn:
					UC_Learn LearnCtrl = new UC_Learn(index);
					LearnCtrl.Location = new Point(X, Y);
					Ctrl.Controls.Add(LearnCtrl);
					break;
				case UC.UC_Learn_Type:
					UC_Learn_Type TypeCtrl = new UC_Learn_Type(index);
					TypeCtrl.Location = new Point(X, Y);
					Ctrl.Controls.Add(TypeCtrl);
					break;
				case UC.UC_Learn_Choose:
					UC_Learn_Choose ChooseCtrl = new UC_Learn_Choose(index);
					ChooseCtrl.Location = new Point(X, Y);
					Ctrl.Controls.Add(ChooseCtrl);
					break;
			}
		}

	}
}
