using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTLEnglish.DAL
{
	[Serializable]
	public class Topic
	{
		private string topicName;
		private Learn learnt;
		private List<Word> wordList;
		
		public string TopicName { get => topicName; set => topicName = value; }
		public Learn Learnt { get => learnt; set => learnt = value; }

		public List<Word> WordList { get => wordList; set => wordList = value; }
	}
}
