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

namespace PTLEnglish.DAL
{
	public static class Manage
	{
		private static Topic topicData;

		public static Topic TopicData { get => topicData; set => topicData = value; }

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

		public static void SerializeToXML(object data, string filePath)
		{
			FileStream fstream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
			XmlSerializer sr = new XmlSerializer(typeof(Topic));
			sr.Serialize(fstream, data);
			fstream.Close();
		}

		public static object DeserializeFromXML(string filePath)
		{
			FileStream fstream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite);
			XmlSerializer sr = new XmlSerializer(typeof(Topic));
			object obj = sr.Deserialize(fstream);
			fstream.Close();
			return obj;
		}

	}
}
