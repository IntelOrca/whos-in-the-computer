using System;
using System.Collections;

namespace IntelOrca.WITC
{
	class CategoryCollection : CollectionBase
	{
		public void Add(Category category)
		{
			this.List.Add(category);
		}

		public void AddCard(string categoryName, string card)
		{
			Category category = this[categoryName];
			if (category == null) {
				category = new Category(categoryName);
				Add(category);
			}

			category.Add(card);
		}

		public void Remove(Category category)
		{
			this.List.Remove(category);
		}

		public void Remove(string name)
		{
			Category category = this[name];
			if (category != null)
				this.List.Remove(category);
		}

		public bool Exists(string name)
		{
			return (this[name] != null);
		}

		public Category this[string name]
		{
			get
			{
				foreach (Category category in this)
					if (String.Compare(category.Name, name, true) == 0)
						return category;
				return null;
			}
		}

		public Category this[int index]
		{
			get
			{
				return (Category)this.List[index];
			}
		}
	}
}
