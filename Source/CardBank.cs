////////////////////////////////////
// Who's in the Computer          //
// Copyright (C) Ted John 2012    //
// http://intelorca.co.uk         //
////////////////////////////////////

using System;

namespace IntelOrca.WITC
{
	class CardBank
	{
		private CategoryCollection mCategories = new CategoryCollection();
		private CategoryCollection mUsedCards = new CategoryCollection();

		public void Load()
		{
			LoadCategoriesFromSheet(mCategories, new CSVSheet("cards.csv"));

			try {
				LoadCategoriesFromSheet(mUsedCards, new CSVSheet("used.csv"));
			} catch { }
		}

		public void Save()
		{
			// SaveCategoriesToSheet(mUsedCards).Save("cards.csv");
			SaveCategoriesToSheet(mUsedCards).Save("used.csv");
		}

		private void LoadCategoriesFromSheet(CategoryCollection categories, CSVSheet sheet)
		{
			categories.Clear();
			for (int x = 0; x < sheet.Columns; x++) {
				string category = sheet[x, 0];
				if (String.IsNullOrEmpty(category))
					continue;

				for (int y = 1; y < sheet.Rows; y++)
					if (!String.IsNullOrEmpty(sheet[x, y]))
						categories.AddCard(category, sheet[x, y]);
			}
		}

		private CSVSheet SaveCategoriesToSheet(CategoryCollection categories)
		{
			CSVSheet sheet = new CSVSheet();
			for (int x = 0; x < categories.Count; x++) {
				sheet[x, 0] = categories[x].Name;
				for (int y = 0; y < categories[x].Cards.Count; y++)
					sheet[x, y + 1] = categories[x].Cards[y];
			}
			return sheet;
		}

		public void ResetUsedCards(string category)
		{
			mUsedCards[category].Clear();
		}

		public CategoryCollection Categories
		{
			get
			{
				return mCategories;
			}
		}

		public CategoryCollection UsedCards
		{
			get
			{
				return mUsedCards;
			}
		}
	}
}
