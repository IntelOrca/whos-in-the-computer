using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WITC.Classes;

namespace WITC.Forms
{
	partial class GameStats : Form
	{
		const string SZ_END_PROMPT = "Are you sure you want to end the game? This cannot be undone.";

		public Game mGame;

		public GameStats(Game game)
		{
			InitializeComponent();

			mGame = game;
			lblGameTime.Text = TimeFormat(mGame.mTotalGameTime);
			RefreshStats();
		}

		private void tmrGameTime_Tick(object sender, EventArgs e)
		{
			mGame.IncrementTotalGameTime();

			lblGameTime.Text = TimeFormat(mGame.mTotalGameTime);
		}

		private string TimeFormat(int secs)
		{
			int mins = secs / 60;
			int hours = mins / 60;
			mins %= 60;
			secs %= 60;

			if (hours > 99)
				return String.Format("{0:D2}:{1:D2}", hours, mins);
			else
				return String.Format("{0:D2}:{1:D2}:{2:D2}", hours, mins, secs);
		}

		private void btnNextTurn_Click(object sender, EventArgs e)
		{
			Turn round = new Turn(mGame, this);
			round.ShowDialog();
			round.Dispose();
			mGame.CheckEndGame();
			RefreshStats();
	
			//AUTOSAVE
			if (!mGame.mGameOver)
				mGame.Save(WITC.PATH_SAVED_GAME);
		}

		private void btnEndGame_Click(object sender, EventArgs e)
		{
			//Prompt
			if (MessageBox.Show(SZ_END_PROMPT, "End Game?", MessageBoxButtons.OKCancel,
				MessageBoxIcon.Question) == DialogResult.OK) {
				mGame.EndGame();
				File.Delete(WITC.PATH_SAVED_GAME);
				RefreshStats();
			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			if (!mGame.mGameOver)
				mGame.Save(WITC.PATH_SAVED_GAME);
			this.Close();
		}

		public void RefreshStats()
		{
			Label team, correct, pass, foul, score;
			int TeamCount = mGame.mTeams.Count;
			for (int i = 0; i < 6; i++) {
				team = (Label)grpTeams.Controls["lblTeam" + i];
				correct = (Label)grpTeams.Controls["lblCorrect" + i];
				pass = (Label)grpTeams.Controls["lblPass" + i];
				foul = (Label)grpTeams.Controls["lblFoul" + i];
				score = (Label)grpTeams.Controls["lblScore" + i];
				if (i < TeamCount) {
					if (mGame.mTeamGo == i) {
						team.ForeColor = Color.Blue;
						team.Font = new Font(team.Font, FontStyle.Bold);
					} else {
						team.ForeColor = Color.Black;
						team.Font = new Font(team.Font, FontStyle.Regular);
					}
					team.Text = mGame.mTeams[i].Name;
					team.Visible = true;
					correct.Text = Convert.ToString(mGame.mTeams[i].Correct);
					correct.Visible = true;
					pass.Text = Convert.ToString(mGame.mTeams[i].Pass);
					pass.Visible = true;
					foul.Text = Convert.ToString(mGame.mTeams[i].Foul);
					foul.Visible = true;
					score.Text = Convert.ToString(mGame.mTeams[i].Score);
					score.Visible = true;
				} else {
					team.Visible = false;
					correct.Visible = false;
					pass.Visible = false;
					foul.Visible = false;
					score.Visible = false;
				}
			}

			lblCurrentRound.Text = Convert.ToString(mGame.mCurrentRound);
			if (mGame.mGameOver)
				btnNextTurn.Text = "HAD FUN?";
			else
				btnNextTurn.Text = String.Format("{0}'S TURN", mGame.PlayerGo.ToUpper());
			btnNextTurn.Enabled = !mGame.mGameOver;
			btnEndGame.Enabled = !mGame.mGameOver;
		}
	}
}
