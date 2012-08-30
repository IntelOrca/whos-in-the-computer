////////////////////////////////////
// Who's in the Computer          //
// Copyright (C) Ted John 2012    //
// http://intelorca.co.uk         //
////////////////////////////////////

using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace IntelOrca.WITC
{
	partial class MainForm : Form
	{
		private int mOriginalFormHeight;

		public MainForm()
		{
			InitializeComponent();

			this.Icon = Program.AppIcon;
			this.Text = Program.AppName;

			mOriginalFormHeight = this.ClientSize.Height;
			UpdateLabels();
		}

		private void UpdateLabels()
		{
			this.SuspendLayout();

			lblPlayedRounds.Text = String.Format("Played rounds: {0}", Program.Game.PlayedRounds);
			lblCategory.Text = String.Format("Category: {0}", Program.Game.Category);

			lblCurrentPlayer.Text = String.Format("{0}'s turn", Program.Game.CurrentTeam.PlayerGo.Name);

			UpdatePlayerLabels();

			this.ResumeLayout();
		}

		private void UpdatePlayerLabels()
		{
			if (Program.Game.Teams == null)
				return;

			//Sort the players by highest score
			Team[] teams = Program.Game.Teams.OrderByDescending(t => t.Score).ToArray();

			grpParticipants.Controls.Clear();

            if (Program.Game.Teams.Length < 2)
                return;

			int numPlayers = teams.Length;
			int highestScore = teams[0].Score;
			int lowestScore = teams[numPlayers - 1].Score;

			int currentY = 20;

			// Header
			Panel panel = new Panel();
			panel.Location = new Point(3, currentY);
			panel.Size = new Size(grpParticipants.Width - 6, 20);
			panel.Font = panel.Font = new Font(panel.Font, FontStyle.Bold);

			CreateParticipantRow(panel, new string[] { "Team", "Turns", "Correct", "Pass", "Foul", "Score" });

			grpParticipants.Controls.Add(panel);
			currentY += panel.Height + 3;

			foreach (Team team in teams) {
				panel = new Panel();
				panel.Location = new Point(3, currentY);
				panel.Size = new Size(grpParticipants.Width - 6, 20);

				CreateParticipantRow(panel, new string[] { team.Name, team.Turns.ToString(), team.Correct.ToString(), team.Pass.ToString(), team.Foul.ToString(), team.Score.ToString() });

				Color forecolour = Color.Black;
				if (highestScore != lowestScore) {
					if (team.Score == highestScore)
						forecolour = Color.Blue;
					else if (team.Score == lowestScore)
						forecolour = Color.Red;
				}

				foreach (Label label in panel.Controls.OfType<Label>())
					label.ForeColor = forecolour;

				grpParticipants.Controls.Add(panel);
				currentY += panel.Height + 3;

				foreach (Player player in team.Players) {
					panel = new Panel();
					panel.Location = new Point(3, currentY);
					panel.Size = new Size(grpParticipants.Width - 6, 14);
					panel.Font = panel.Font = new Font(panel.Font.FontFamily, 8.0f);

					string name;
					if (Program.Game.CurrentPlayer == player)
						name = String.Format("  {1}   {0}", player.Name, (char)8226);
					else
						name = String.Format("      {0}", player.Name);

					CreateParticipantRow(panel, new string[] { name, player.Turns.ToString(), player.Correct.ToString(), player.Pass.ToString(), player.Foul.ToString(), player.Score.ToString() });

					grpParticipants.Controls.Add(panel);
					currentY += panel.Height + 3;
				}
			}

			int formHeight = mOriginalFormHeight + currentY - 16;

			ClientSize = new Size(ClientSize.Width, formHeight);
		}

		private void CreateParticipantRow(Panel panel, string[] labelText)
		{
			const int scoreLabelWidth = 64;

			Label[] labels = new Label[6];
			for (int i = 0; i < labels.Length; i++) {
				labels[i] = new Label();
				labels[i].AutoSize = false;
				labels[i].TextAlign = ContentAlignment.MiddleCenter;
				labels[i].Location = new Point(0, 0);
				labels[i].Size = new Size(scoreLabelWidth, panel.Height);
				labels[i].Text = labelText[i];
				panel.Controls.Add(labels[i]);
			}

			labels[0].TextAlign = ContentAlignment.MiddleLeft;
			labels[0].Size = new Size(panel.Width - (scoreLabelWidth * 5) - 6 - 12, panel.Height);

			for (int i = 1; i < labels.Length; i++) {
				labels[i].Location = new Point(grpParticipants.Width - (scoreLabelWidth * (5 - i)) - 6, 0);
			}
		}

		private void btnOptions_Click(object sender, EventArgs e)
		{
			using (OptionsForm form = new OptionsForm())
				form.ShowDialog();
			UpdatePlayerLabels();
		}

		private void btnNextRound_Click(object sender, EventArgs e)
		{
			Category category = Program.CardBank.Categories[Program.Game.Category];
			if (category == null) {
				MessageBox.Show("Category does not exist", Program.AppName);
				return;
			}

			if (category.Cards.Count < 2) {
				MessageBox.Show("Not enough cards in this category.", Program.AppName);
				return;
			}

			RoundForm roundForm = new RoundForm();
			roundForm.ShowDialog();

			Program.Game.CurrentPlayer.Turns++;

			Program.Game.PlayedRounds++;
			Program.Game.NextTeam();
			UpdateLabels();

			Program.Game.SaveGame();
			Program.CardBank.Save();
		}

		private void btnFinishGame_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Are you sure you want to end the game?", Program.AppName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (result != DialogResult.OK)
				return;

			Program.Game.FinishGame();

			Audio.RandomHadFun();
			result = MessageBox.Show("HAD FUN?", Program.AppName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes) {
				Application.Exit();
			} else {
				Hide();
				if (!GameWizard.Run()) {
					Application.Exit();
				} else {
					UpdateLabels();
					Show();
				}
			}
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			e.Cancel = true;
			btnFinishGame_Click(this, e);
		}
	}
}
