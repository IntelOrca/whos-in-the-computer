using System;
using System.Windows.Forms;
using WITC.Classes;

namespace WITC.Forms
{
	partial class CardManager : Form
	{
		const string SZ_NUMBER_OF_CARDS = "Number of Cards: {0}";
		const string SZ_REMOVE_CATEGORY	= "Are you sure you want to remove the category {0}?";
		const string SZ_CATEGORY_ALREADY_EXISTS = "This category already exists!";
		const string SZ_CARD_ALREADY_EXISTS = "This card already exists!";
		const string SZ_COMBIND_STATS = "{0} Categories and {1} Cards have been added to the bank.";

		CardBank cb = new CardBank();

		public CardManager()
		{
			InitializeComponent();
			cb.Open(WITC.PATH_CARD_BANK);
			RefreshTree();
		}

		private void RefreshTree()
		{
			trvCards.Nodes.Clear();
			for (int i = 0; i < cb.NumberOfCatergories; i++) {
				TreeNode Node = new TreeNode(cb[i].mName);
				for (int j = 0; j < cb[i].mCards.Count; j++) {
					Node.Nodes.Add(cb[i].mCards[j]);
				}
				trvCards.Nodes.Add(Node);
			}
			trvCards.Sort();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			cb.Save(WITC.PATH_CARD_BANK);
			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void trvCards_AfterSelect(object sender, TreeViewEventArgs e)
		{
			RefreshCardCount();
		}

		private void trvCards_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			trvCards.SelectedNode = e.Node;
		}

		private void trvCards_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
		{
			if (e.Label == null || e.Label.Length == 0) {
				e.CancelEdit = true;
				return;
			}
			if (e.Node.Level == 0) {
				e.CancelEdit = !cb.EditCategory(e.Node.Text, e.Label);
				if (e.CancelEdit)
					MessageBox.Show(SZ_CATEGORY_ALREADY_EXISTS, "Cannot rename category!", MessageBoxButtons.OK, MessageBoxIcon.Information);
			} else {
				e.CancelEdit = !cb.EditCard(e.Node.Parent.Text, e.Node.Text, e.Label);
				if (e.CancelEdit)
					MessageBox.Show(SZ_CARD_ALREADY_EXISTS, "Cannot rename card!", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void addCategoryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string name = GetUniqueCategoryName();
			TreeNode node = new TreeNode(name);
			trvCards.Nodes.Add(node);
			cb.AddCategory(name);
			trvCards.SelectedNode = node;
			node.BeginEdit();
		}

		private void addCardToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TreeNode parent;
			if (trvCards.SelectedNode.Level == 0)
				parent = trvCards.SelectedNode;
			else
				parent = trvCards.SelectedNode.Parent;
			int c = cb.GetCategoryID(parent.Text);
			string name = GetUniqueCardName(c);
			TreeNode node = new TreeNode(name);
			parent.Nodes.Add(node);
			cb.AddCard(c, name);
			trvCards.SelectedNode = node;
			node.BeginEdit();
		}

		private void editToolStripMenuItem_Click(object sender, EventArgs e)
		{
			trvCards.SelectedNode.BeginEdit();
		}

		private void removeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TreeNode category;
			if (trvCards.SelectedNode.Level == 0) {
				category = trvCards.SelectedNode;

				//Prompt user first
				if (MessageBox.Show(String.Format(SZ_REMOVE_CATEGORY, category.Text),
					"Remove Category", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
					== DialogResult.OK) {
					cb.RemoveCategory(category.Text);
					category.Remove();
				}
			}  else {
				category = trvCards.SelectedNode.Parent;
				cb.RemoveCard(category.Text, trvCards.SelectedNode.Text);
				trvCards.SelectedNode.Remove();
			}
		}

		private string GetUniqueCategoryName()
		{
			int j = 0;
			bool foundone = false;
			while (!foundone) {
				++j;
				for (int i = 0; i < cb.NumberOfCatergories; i++) {
					if (cb[i].mName.ToLower() == String.Format("new category {0}", j))
						break;
					else if (i == cb.NumberOfCatergories - 1)
						foundone = true;
				}
			}
			return String.Format("New Category {0}", j);
		}

		private string GetUniqueCardName(int c)
		{
			int j = 0;
			bool foundone = false;
			while (!foundone) {
				++j;
				if (cb[c].mCards.Count == 0)
					break;
				for (int i = 0; i < cb[c].mCards.Count; i++) {
					if (cb[c].mCards[i].ToLower() == String.Format("new card {0}", j))
						break;
					else if (i == cb[c].mCards.Count - 1)
						foundone = true;
				}
			}
			return String.Format("New Card {0}", j);
		}

		private void RefreshCardCount()
		{
			TreeNode parent;
			if (trvCards.SelectedNode.Level == 0)
				parent = trvCards.SelectedNode;
			else
				parent = trvCards.SelectedNode.Parent;
			int cards = parent.Nodes.Count;
			lblCards.Text = String.Format(SZ_NUMBER_OF_CARDS, cards);
		}

		private void btnMerge_Click(object sender, EventArgs e)
		{
			OpenFileDialog opendialog = new OpenFileDialog();
			opendialog.Filter = "Card Bank Files (*csv)|*.csv";
			if (opendialog.ShowDialog() == DialogResult.OK) {
				CardBank extracb = new CardBank(opendialog.FileName);
				CardBank.MergeStats stats = cb.Merge(extracb);
				RefreshTree();
				MessageBox.Show(String.Format(SZ_COMBIND_STATS,
					stats.mNewCategories, stats.mNewCards),
					"Merge Card Bank", MessageBoxButtons.OK,
					MessageBoxIcon.Information);
			}
		}
	}
}
