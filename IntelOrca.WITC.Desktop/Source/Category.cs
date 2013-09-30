////////////////////////////////////
// Who's in the Computer          //
// Copyright (C) Ted John 2012    //
// http://intelorca.co.uk         //
////////////////////////////////////

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IntelOrca.WITC
{
	class Category : IEnumerable<string>
	{
		private string mName;
		private List<string> mCards = new List<string>();

		public Category(string name)
		{
			mName = name;
		}

		public void Add(string card)
		{
			mCards.Add(card);
		}

		public void Clear()
		{
			mCards.Clear();
		}

		public string CheckForDuplicates()
		{
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < mCards.Count; i++) {
				for (int j = i + 1; j < mCards.Count; j++) {
					int score = GetDuplicateScore(mCards[i], mCards[j]);
					if (score < 2)
						sb.AppendFormat("[{4}]: {0}:{2} ~ {1}:{3}\n", i, j, mCards[i], mCards[j], score);
				}
			}
			return sb.ToString();
		}

		private int GetDuplicateScore(string s, string t)
		{
			if (s.ToLower() == t.ToLower())
				return 0;
			else
				return 4;

			// int score = LevenshteinDistance(s.ToLower(), t.ToLower());
			// return score;

			/*
			if (a == b)
				return 0;

			Dictionary<char, int> aLetterCount = new Dictionary<char, int>();
			Dictionary<char, int> bLetterCount = new Dictionary<char, int>();

			foreach (char c in a) {
				if (aLetterCount.ContainsKey(c))
					aLetterCount[c]++;
				else
					aLetterCount.Add(c, 1);
			}
			foreach (char c in b) {
				if (bLetterCount.ContainsKey(c))
					bLetterCount[c]++;
				else
					bLetterCount.Add(c, 1);
			}
			*/
		}

		int LevenshteinDistance(string s, string t)
		{
			if (s.Length == 0)
				return t.Length;
			else if (t.Length == 0)
				return s.Length;
			else
				return Math.Min(Math.Min(
					LevenshteinDistance(s.Substring(1), t),
					LevenshteinDistance(s, t.Substring(1))),
					LevenshteinDistance(s.Substring(1), t.Substring(1)));
		}

		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return mCards.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return mCards.GetEnumerator();
		}

		public override string ToString()
		{
			return String.Format("{0}, Cards = {1}", mName, mCards.Count);
		}

		public string Name
		{
			get
			{
				return mName;
			}
		}

		public List<string> Cards
		{
			get
			{
				return mCards;
			}
		}
	}
}
