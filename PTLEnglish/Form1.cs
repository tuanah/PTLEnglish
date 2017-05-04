using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PTLEnglish.DAL;

namespace PTLEnglish
{
	public partial class Form1 : Form
	{
		//Manage Data = new Manage();
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//cbCourse.DataSource = Cons.CourseDir;
			try
			{
				Manage.TopicData = (Topic)Manage.DeserializeFromXML(Cons.Path + "\\" + Manage.TopicData.TopicName + ".xml");
			}
			catch
			{
				Manage.LoadData(Manage.ThisCourse + Manage.ThisTopic);
			}
			lbl_Topic_Name.Text = Manage.TopicData.TopicName;
			LoadListView(lvWord, Manage.TopicData);
			Manage.SerializeToXML(Manage.TopicData, Cons.Path + "\\" + Manage.TopicData.TopicName + ".xml");
		}

		private void cbCourse_SelectedIndexChanged(object sender, EventArgs e)
		{
			//ComboBox cb = sender as ComboBox;
			//if (cb.SelectedItem != null)
			//{
			//	DirectoryInfo topic = cb.SelectedItem as DirectoryInfo;
			//	Cons.LoadTopicDir(topic);
			//	cbTopic.DataSource = Cons.TopicDir;
			//}
		}

		private void LoadListView(ListView listView, Topic topic)
		{
			listView.Clear();
			listView.View = View.Details;
			listView.Columns.Add("Word");
			listView.Columns.Add("Pronunciation");
			listView.Columns.Add("Mean");
			listView.Columns.Add("PicturePath");

			for (int i = 0; i < topic.WordList.Count; i++)
			{
				ListViewItem item = new ListViewItem();
				item.Text = topic.WordList[i].Key;
				item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = topic.WordList[i].Pronunciation });
				item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = topic.WordList[i].Mean });
				item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = topic.WordList[i].ImgPath });
				listView.Items.Add(item);
			}
		}


		private void cbTopic_SelectedIndexChanged(object sender, EventArgs e)
		{
			//ComboBox cb = sender as ComboBox;
			//if (cb.SelectedItem != null)
			//{
			//	DirectoryInfo dir = cb.SelectedItem as DirectoryInfo;
			//	try
			//	{
			//		Manage.TopicData= (Topic)Manage.DeserializeFromXML(Cons.Path + "\\" + dir.Name + ".xml");
			//	}
			//	catch
			//	{
			//		Manage.LoadData(dir);
			//	}
			//	LoadListView(lvWord, Manage.TopicData);
			//	Manage.SerializeToXML(Manage.TopicData, Cons.Path + "\\" + dir.Name + ".xml");
			//}
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			string filePath = Cons.Path + "\\" + Manage.TopicData.TopicName + ".xml";
			Manage.SerializeToXML(Manage.TopicData, filePath);
			Application.Exit();
		}

	}
}
