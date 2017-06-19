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
		private static string thisCourse = "Source\\Economic";
		private static string thisTopic = "\\Job";
		private static bool checkUseTest;
		private static int times;
		public enum UC
		{
			UC_Learn,
			UC_Learn_Type,
			UC_Learn_Choose, 
			UC_Learn_Shuffle,
			UC_Finish
		}

		public static SpeechSynthesizer reader = new SpeechSynthesizer();

		public static Topic TopicData { get => topicData; set => topicData = value; }
		public static string ThisCourse { get => thisCourse; set => thisCourse = value; }
		public static string ThisTopic { get => thisTopic; set => thisTopic = value; }
		/// <summary>
		/// Dùng để Check xem các User Control trong Learn có xài cho phần Test hay không
		/// </summary>
		public static bool CheckUseTest { get => checkUseTest; set => checkUseTest = value; }
		/// <summary>
		/// Số lần hiển thị User Control trong Learn
		/// </summary>
		public static int Times { get => times; set => times = value; }


		private static Word stringHandling(string line)
		{
			Word word = new Word();
			string[] wordInfo = new string[3];
			line = line.Replace('\t', ' ');
			wordInfo = line.Split('/');
			word.Key = wordInfo[0].TrimEnd().ToLower();
			word.Pronunciation = wordInfo[1];
			word.Mean = wordInfo[2].TrimStart();

			return word;
		}

		/// <summary>
		/// Đọc dữ liệu từ file .txt và lưu hình ảnh
		/// </summary>
		/// <param name="path">Địa chỉ của thư mục chứa file .txt và Image của Khóa học(ThisTopic)</param>
		public static void LoadData(string path)
		{
			Word word = new Word();
			TopicData = new Topic();
			TopicData.WordList = new List<Word>();
			string line;
			DirectoryInfo Dir = new DirectoryInfo(path);
			//Lấy danh sách các file có trong thư mục Chủ đề
			//Do trong thư mục chỉ có duy nhất 1 file nên vị trí đầu tiên là file .txt
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
			TopicData.Learnt = new Learn();
			TopicData.Learnt.RandomListWord();
		}

		/// <summary>
		/// Lưu dữ liệu cần Serialize của chương trình xuống dạng .xml
		/// </summary>
		/// <param name="data">Class cần Serialize xuống</param>
		/// <param name="filePath">Đường dẫn địa chỉ cần lưu</param>
		public static void SerializeToXML(object data, string filePath)
		{
			FileStream fstream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
			XmlSerializer sr = new XmlSerializer(typeof(Topic));
			sr.Serialize(fstream, data);
			fstream.Close();
		}

		/// <summary>
		/// Đọc dữ liệu dưới dạng .xml lên và cập nhật vào chương trình
		/// </summary>
		/// <param name="filePath">Đường dẫn địa chỉ cần lưu</param>
		/// <returns></returns>
		public static object DeserializeFromXML(string filePath)
		{
			FileStream fstream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
			XmlSerializer sr = new XmlSerializer(typeof(Topic));
			object obj = sr.Deserialize(fstream);
			fstream.Close();
			return obj;
		}

		/// <summary>
		/// Hàm hiển thị User Control vào trong Ctrl
		/// </summary>
		/// <param name="Ctrl">Control chứa User Control muốn add vào</param>
		/// <param name="uc">User Control muốn hiển thị(Tên Class)</param>
		/// <param name="index">Vị trí của Word trong WordList muốn Load vào User Control</param>
		/// <param name="X">Tọa độ X</param>
		/// <param name="Y">Tọa độ Y</param>
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
				case UC.UC_Learn_Shuffle:
					UC_Learn_Shuffle ShuffleCtrl = new UC_Learn_Shuffle(index);
					ShuffleCtrl.Location = new Point(X, Y);
					Ctrl.Controls.Add(ShuffleCtrl);
					break;
				case UC.UC_Finish:
					UC_Finish FinishCtrl = new UC_Finish();
					FinishCtrl.Location = new Point(X, Y);
					Ctrl.Controls.Add(FinishCtrl);
					break;
			}
		}

	}
}
