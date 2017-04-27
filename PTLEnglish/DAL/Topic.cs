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
		private List<Word> wordList;
		private List<string> wrongWords;
		private List<string> rightWords;
		private List<string> learntWords;

		public string TopicName { get => topicName; set => topicName = value; }
		public List<Word> WordList { get => wordList; set => wordList = value; }
		public List<string> WrongWords { get => wrongWords; set => wrongWords = value; }
		public List<string> RightWords { get => rightWords; set => rightWords = value; }
		public List<string> LearntWords { get => learntWords; set => learntWords = value; }
	}
}
