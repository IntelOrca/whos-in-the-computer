using System;
using System.Collections;
using System.Collections.Generic;

namespace WITC
{
	class Bag : IEnumerable<string>
	{
		private CardBank mBank;
		private List<string> mCards = new List<string>();

		public Bag(CardBank bank)
		{
			mBank = bank;
		}

		public void AddCard(string card)
		{
			mCards.Add(card);
		}

		public void AddCategory(string category)
		{
			Category c = mBank[category];
			for (int i = 0; i < c.mCards.Count; i++) {
				AddCard(c.mCards[i]);
			}
		}

		public string GetRandomCard()
		{
			Random r = new Random();
			int i = r.Next(0, mCards.Count);
			return mCards[i];
		}

		public void RemoveCard(string card)
		{
			mCards.Remove(card);
		}

		public bool ContainsCard(string card)
		{
			return mCards.Contains(card);
		}

		public IEnumerator<string> GetEnumerator()
		{
			return mCards.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return mCards.GetEnumerator();
		}

		public override string ToString()
		{
			return String.Format("Cards = {0}", mCards.Count);
		}

		public int CardCount
		{
			get
			{
				return mCards.Count;
			}
		}
	}
}
