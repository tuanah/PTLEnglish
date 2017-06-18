﻿using System;
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
		
		//private List<int> wrongWords;
		//private List<int> rightWords;
		//private int numLearnt = 0;

		public string TopicName { get => topicName; set => topicName = value; }
		public Learn Learnt { get => learnt; set => learnt = value; }

		public List<Word> WordList { get => wordList; set => wordList = value; }

		//public List<int> WrongWords { get => wrongWords; set => wrongWords = value; }
		//public List<int> RightWords { get => rightWords; set => rightWords = value; }
		//public int NumLearnt { get => numLearnt; set => numLearnt = value; }

		public Topic()
		{
			//wrongWords = new List<int>();
			//rightWords = new List<int>();
			//learnt = new Learn(WordList);
		}
	}
}
