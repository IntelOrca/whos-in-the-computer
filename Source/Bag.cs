////////////////////////////////////
// Who's in the Computer          //
// Copyright (C) Ted John 2012    //
// http://intelorca.co.uk         //
////////////////////////////////////

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace IntelOrca.WITC
{
	class Bag
	{
		private Random mRandom;
		private string mCategory;
		private List<string> mCards;

		public Bag(string category)
		{
			mRandom = new Random();
			mCategory = category;
			mCards = new List<string>();
		}

		public void FillBag()
		{
			Category allCards = Program.CardBank.Categories[mCategory];
			Category usedCards = Program.CardBank.UsedCards[mCategory];

			if (allCards == null)
				throw new Exception();

			IEnumerable<string> cards = allCards;

			// Remove any cards that have been used before
			if (usedCards != null)
				cards = cards.Except(usedCards);

			// Remove any cards we already have in our bag
			cards = cards.Except(mCards);

			// Check if there are any cards left
			if (cards.Count() == 0) {
				// Clear used cards
				if (usedCards.Count() > 0)
					usedCards.Clear();
			}

			mCards.AddRange(cards);
		}

		public string PopCard()
		{
			if (mCards.Count == 0)
				FillBag();
			if (mCards.Count == 0)
				throw new Exception();

			int ridx = mRandom.Next(0, mCards.Count);
			string card = mCards[ridx];
			mCards.RemoveAt(ridx);
			return card;
		}

		public void PushCard(string card)
		{
			mCards.Add(card);
		}

		public string Category
		{
			get
			{
				return mCategory;
			}
		}
	}
}
