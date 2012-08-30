////////////////////////////////////
// Who's in the Computer          //
// Copyright (C) Ted John 2012    //
// http://intelorca.co.uk         //
////////////////////////////////////

using System;
using System.Collections;
using System.Collections.Generic;

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
