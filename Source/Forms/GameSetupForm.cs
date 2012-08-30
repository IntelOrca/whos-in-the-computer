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
		private string mCategory;
		private bool mResetReleventCards;

		public GameSetupForm()
		{
			InitializeComponent();

			this.Icon = Program.AppIcon;
			this.Text = Program.AppName;

			foreach (Category category in Program.CardBank.Categories.Cast<Category>().OrderBy(c => c.Name))
				cmbCategory.Items.Add(category.Name);
			if (cmbCategory.Items.Count > 0)
				cmbCategory.SelectedIndex = 0;
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			mResult = Result.Back;
			this.DialogResult = DialogResult.OK;
			Close();
		}

		private void btnContinue_Click(object sender, EventArgs e)
		{
			mRoundDuration = (int)nudRoundDuration.Value;
			mMaximumPasses = (int)nudMaxPasses.Value;
			mCategory = cmbCategory.Text;
			mResetReleventCards = chkResetReleventCards.Checked;

			mResult = Result.Continue;
			this.DialogResult = DialogResult.OK;
			Close();
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

		public string Category
		{
			get
			{
				return mCategory;
			}
			set
			{
				mCategory = value;
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
