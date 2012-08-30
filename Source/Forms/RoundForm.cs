using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IntelOrca.WITC
{
	partial class RoundForm : Form
	{
		private int mTimeRemaining;
		private List<string> mCardsInHand;
		private int mViewingCardIndex;

		public RoundForm()
		{
			InitializeComponent();

			this.Icon = Program.AppIcon;
			this.Text = Program.AppName;

			this.Text = String.Format("Round {0} - {1}'s Turn", Program.Game.PlayedRounds + 1, Program.Game.CurrentTeam.PlayerGo.Name);

			mTimeRemaining = Program.Game.RoundDuration;
			UpdateTimeLabel();
			StartRound();
		}

		protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
		{
			base.OnClosing(e);
			EndRound();
		}

		private void UpdateTimeLabel()
		{
			int time = mTimeRemaining;
			if (time < 0)
				time = 0;
			lblTimeRemaining.Text = time.ToString();
		}

		private void StartRound()
		{
			mCardsInHand = new List<string>();
			RefreshCard();

			tmrUpdate.Start();
			RefreshCard();
		}

		private void EndRound()
		{
			foreach (string card in mCardsInHand)
				Program.Game.PushCard(card);

			tmrUpdate.Stop();
		}

		private void tmrTime_Tick(object sender, EventArgs e)
		{
			mTimeRemaining--;
			UpdateTimeLabel();

			if (mTimeRemaining <= -3) {
				Close();
			} else if (mTimeRemaining == 0) {
				Audio.PlaySound(Audio.Sounds.TimeUp);
			} else if (mTimeRemaining > 0 && mTimeRemaining <= 10) {
				Audio.PlaySound(Audio.Sounds.Tick);
			}
		}

		private void RefreshCard()
		{
			if (mCardsInHand.Count == 0)
				PickupCard();

			lblCard.Text = mCardsInHand[mViewingCardIndex];
			btnPass.Enabled = (mCardsInHand.Count - 1 < Program.Game.MaximumPasses);
			btnPrevious.Enabled = btnNext.Enabled = (mCardsInHand.Count > 1);
		}

		private void PickupCard()
		{
			mCardsInHand.Add(Program.Game.PopCard());
			mViewingCardIndex = mCardsInHand.Count - 1;
		}

		private void btnCorrect_Click(object sender, EventArgs e)
		{
			Audio.PlaySound(Audio.Sounds.Correct);

			// Add to used cards
			Program.CardBank.UsedCards.AddCard(Program.Game.Category, mCardsInHand[mViewingCardIndex]);

			Program.Game.CurrentPlayer.Correct++;
			mCardsInHand.RemoveAt(mViewingCardIndex);

			PickupCard();
			RefreshCard();
		}

		private void btnPass_Click(object sender, EventArgs e)
		{
			Audio.PlaySound(Audio.Sounds.Pass);

			Program.Game.CurrentPlayer.Pass++;

			PickupCard();
			RefreshCard();
		}

		private void btnFoul_Click(object sender, EventArgs e)
		{
			Audio.PlaySound(Audio.Sounds.Foul);

			// Add to used cards
			Program.CardBank.UsedCards.AddCard(Program.Game.Category, mCardsInHand[mViewingCardIndex]);

			Program.Game.CurrentPlayer.Foul++;
			mCardsInHand.RemoveAt(mViewingCardIndex);

			PickupCard();
			RefreshCard();
		}

		private void btnPrevious_Click(object sender, EventArgs e)
		{
			mViewingCardIndex--;
			if (mViewingCardIndex < 0)
				mViewingCardIndex = mCardsInHand.Count - 1;

			RefreshCard();
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			mViewingCardIndex++;
			if (mViewingCardIndex >= mCardsInHand.Count)
				mViewingCardIndex = 0;

			RefreshCard();
		}
	}
}
