////////////////////////////////////
// Who's in the Computer          //
// Copyright (C) Ted John 2012    //
// http://intelorca.co.uk         //
////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace IntelOrca.WITC
{
	partial class GameSetupForm : Form
	{
		public enum Result
		{
			Back,
			Continue,
		}

		private Result mResult;
		private int mRoundDuration;
		private int mMaximumPasses;
		private string[] mCategories;
		private bool mResetReleventCards;

		public GameSetupForm()
		{
			InitializeComponent();

			this.Icon = Program.AppIcon;
			this.Text = Program.AppName;

			foreach (Category category in Program.CardBank.Categories.Cast<Category>().OrderBy(c => c.Name))
				clbCategories.Items.Add(category.Name);
		}

		protected override void OnShown(EventArgs e)
		{
			base.OnShown(e);

			// Reset checked items
			for (int i = 0; i < clbCategories.Items.Count; i++)
				clbCategories.SetItemChecked(i, false);

			// Set checked items
			foreach (string category in mCategories)
				clbCategories.SetItemChecked(clbCategories.Items.IndexOf(category), true);
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			mResult = Result.Back;
			this.DialogResult = DialogResult.OK;
			Close();
		}

		private void btnContinue_Click(object sender, EventArgs e)
		{
			if (clbCategories.CheckedItems.Count == 0) {
				MessageBox.Show("You must select at least one category.", Program.AppName);
				return;
			}

			mRoundDuration = (int)nudRoundDuration.Value;
			mMaximumPasses = (int)nudMaxPasses.Value;
			mResetReleventCards = chkResetReleventCards.Checked;

			// Get categories
			mCategories = new string[clbCategories.CheckedItems.Count];
			for (int i = 0; i < clbCategories.CheckedItems.Count; i++)
				mCategories[i] = (string)clbCategories.CheckedItems[i];

			mResult = Result.Continue;
			this.DialogResult = DialogResult.OK;
			Close();
		}

		private void clbCategories_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			int count = clbCategories.CheckedItems.Count;
			if (e.CurrentValue == CheckState.Unchecked && e.NewValue == CheckState.Checked)
				count++;
			else if (e.CurrentValue == CheckState.Checked && e.NewValue == CheckState.Unchecked)
				count--;

			lblSuperCategories.Text = String.Format("Categories ({0})", count);
		}

		public Result WizardResult
		{
			get
			{
				return mResult;
			}
		}

		public int RoundDuration
		{
			get
			{
				return mRoundDuration;
			}
			set
			{
				mRoundDuration = value;
			}
		}

		public int MaximumPasses
		{
			get
			{
				return mMaximumPasses;
			}
			set
			{
				mMaximumPasses = value;
			}
		}

		public string[] Categories
		{
			get
			{
				return mCategories;
			}
			set
			{
				mCategories = value;
			}
		}

		public bool ResetReleventCards
		{
			get
			{
				return mResetReleventCards;
			}
			set
			{
				mResetReleventCards = value;
			}
		}
	}
}
