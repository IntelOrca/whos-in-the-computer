using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using WITC.Classes;

namespace WITC.Forms
{
	partial class NewGame : Form
	{
		const string SZ_INVALID_TEAMS = "Each team must have at least two player. Teams cannot contain players with the same name.";

		Game mGame;
		bool mCreated;
		int mTeams;

		public NewGame()
		{
			InitializeComponent();

			nudTurnTime.Value = WITC.mSettings.mTurnTime;
			nudMaxPasses.Value = WITC.mSettings.mMaxPasses;
			nudRounds.Enabled = WITC.mSettings.mObjRounds;
			chkRounds.Checked = WITC.mSettings.mObjRounds;
			nudRounds.Value = WITC.mSettings.mRounds;
			chkTime.Checked = WITC.mSettings.mObjTime;
			cmbGameTime.Enabled = WITC.mSettings.mObjTime;
			if (WITC.mSettings.mGameTime < cmbGameTime.Items.Count)
				cmbGameTime.SelectedIndex = WITC.mSettings.mGameTime;
			else
				cmbGameTime.SelectedIndex = 0;

			//Load categories
			int selindex = 0;
			CardBank cb = new CardBank();
			cb.Open(WITC.PATH_CARD_BANK);
			for (int i = 0; i < cb.NumberOfCatergories; i++) {
				cmbCategory.Items.Add(cb[i].mName);
				if (WITC.mSettings.mCategory.ToLower() == cb[i].mName.ToLower())
					selindex = i;
			}
			if (cmbCategory.Items.Count > 0)
				cmbCategory.SelectedIndex = selindex;

			//Teams
			cmbTeams.SelectedIndex = 0;

		#if DEBUG
			trvTeams.Nodes.Clear();
			TreeNode Team1 = new TreeNode("Team Ted");
			TreeNode Team2 = new TreeNode("Team Ellie");
			Team1.Nodes.Add("Ted");
			Team1.Nodes.Add("Bex");
			Team2.Nodes.Add("Ellie");
			Team2.Nodes.Add("James");
			trvTeams.Nodes.Add(Team1);
			trvTeams.Nodes.Add(Team2);
			trvTeams.ExpandAll();
		#endif
		}

		private bool SetupGame()
		{
			//Teams
			if (!ValidTeams()) {
				MessageBox.Show(SZ_INVALID_TEAMS, "Invalid Teams!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}

			mGame.mTeams.Clear();
			foreach (TreeNode node in trvTeams.Nodes) {
				Team t = new Team(node.Text);
				foreach (TreeNode player in node.Nodes) {
					t.AddPlayer(player.Text);
				}
				mGame.mTeams.Add(t);
			}

			//Round Time
			mGame.mTurnDuration = (int)nudTurnTime.Value;
			WITC.mSettings.mTurnTime = (int)nudTurnTime.Value;

			mGame.mMaxPasses = (int)nudMaxPasses.Value;
			WITC.mSettings.mMaxPasses = (int)nudMaxPasses.Value;

			if (chkRounds.Checked) {
				mGame.mObjectiveRounds = (int)nudRounds.Value;
				WITC.mSettings.mRounds = (int)nudRounds.Value;
				WITC.mSettings.mObjRounds = true;
			} else {
				mGame.mObjectiveRounds = 0;
				WITC.mSettings.mObjRounds = false;
			}

			if (chkTime.Checked) {
				if (cmbGameTime.SelectedIndex == 0)
					mGame.mObjectiveTime = 30 * 60;
				else
					mGame.mObjectiveTime =
						(cmbGameTime.SelectedIndex * 60) * 60;
				WITC.mSettings.mGameTime = cmbGameTime.SelectedIndex;
				WITC.mSettings.mObjTime = true;
			} else {
				mGame.mObjectiveTime = 0;
				WITC.mSettings.mObjTime = false;
			}

			//Cards
			mGame.mCategory = cmbCategory.Text;
			WITC.mSettings.mCategory = cmbCategory.Text;

			mGame.mCorrectScore = WITC.mSettings.mCorrect;
			mGame.mPassScore = WITC.mSettings.mPass;
			mGame.mFoulScore = WITC.mSettings.mFoul;

			WITC.SaveSettings();
			mGame.StartGame();
			return true;
		}

		public bool Initilize(ref Game game)
		{
			mGame = new Game();

			//Show the dialog
			this.ShowDialog();

			//Return the game pointer and success
			game = mGame;
			return mCreated;
		}

		private void btnPlay_Click(object sender, EventArgs e)
		{
			mCreated = true;
			if (SetupGame())
				this.Close();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			mCreated = false;
			this.Close();
		}

		private void chkPoints_CheckedChanged(object sender, EventArgs e)
		{
			nudRounds.Enabled = chkRounds.Checked;
		}

		private void chkTime_CheckedChanged(object sender, EventArgs e)
		{
			cmbGameTime.Enabled = chkTime.Checked;
		}

		private void cmbTeams_SelectedIndexChanged(object sender, EventArgs e)
		{
			int newteam = cmbTeams.SelectedIndex + 2;

			if (newteam < mTeams) {
				for (int i = mTeams - 1; i > newteam - 1; i--) {
					trvTeams.Nodes.RemoveAt(i);
				}
			} else {
				for (int i = mTeams; i < newteam; i++) {
					trvTeams.Nodes.Add("Team " + (i + 1));
				}
			}
			mTeams = newteam;

			if (trvTeams.Nodes.Count > 0)
				trvTeams.SelectedNode = trvTeams.Nodes[0];
		}

		private void btnAddPlayer_Click(object sender, EventArgs e)
		{
			if (trvTeams.SelectedNode == null)
				return;
			TreeNode parent;
			if (trvTeams.SelectedNode.Level == 0)
				parent = trvTeams.SelectedNode;
			else
				parent = trvTeams.SelectedNode.Parent;

			TreeNode newplayer = new TreeNode("New player");
			parent.Nodes.Add(newplayer);
			trvTeams.SelectedNode = newplayer;
			newplayer.BeginEdit();
		}

		private void btnRemovePlayer_Click(object sender, EventArgs e)
		{
			if (trvTeams.SelectedNode == null)
				return;

			//Check if it is a player node
			if (trvTeams.SelectedNode.Level == 1) {
				TreeNode node = trvTeams.SelectedNode;

				//Select the previous/next node
				if (node.NextNode == null)
					if (node.PrevNode == null)
						trvTeams.SelectedNode = node.Parent;
					else
						trvTeams.SelectedNode = node.PrevNode;
				else
					trvTeams.SelectedNode = node.NextNode;
				
				//Remove the node
				node.Remove();

				//Focus the control
				trvTeams.Focus();
			}
		}

		private void btnRandom_Click(object sender, EventArgs e)
		{
			Random r = new Random();
			List<string> players = new List<string>();
			//Create player list
			foreach (TreeNode team in trvTeams.Nodes) {
				foreach (TreeNode player in team.Nodes) {
					players.Add(player.Text);
				}
				team.Nodes.Clear();
			}

			//Mix up players
			for (int i = 0; i < 100; i++) {
				int a = r.Next(0, players.Count);
				int b = r.Next(0, players.Count);
				if (a != b) {
					string c = players[a];
					players[a] = players[b];
					players[b] = c;
				}
			}

			//Replace them
			int teamcount = trvTeams.Nodes.Count;
			int t = 0;
			foreach (string player in players) {
				trvTeams.Nodes[t].Nodes.Add(player);
				t = (t + 1) % teamcount;
			}
			trvTeams.ExpandAll();
		}

		private bool ValidTeams()
		{
			//Check for similar team names
			for (int i = 0; i < trvTeams.Nodes.Count; i++) {
				string team = trvTeams.Nodes[i].Text.ToLower();
				for (int j = 0; j < trvTeams.Nodes.Count; j++) {
					if (j != i) {
						if (team == trvTeams.Nodes[j].Text.ToLower())
							return false;
					}
				}
			}

			//Check for similar player names
			for (int i = 0; i < trvTeams.Nodes.Count; i++) {
				if (trvTeams.Nodes[i].Nodes.Count < 2)
					return false;
				for (int j = 0; j < trvTeams.Nodes[i].Nodes.Count; j++) {
					string player = trvTeams.Nodes[i].Nodes[j].Text.ToLower();
					for (int k = 0; k < trvTeams.Nodes[i].Nodes.Count; k++) {
						if (k != j) {
							if (player == trvTeams.Nodes[i].Nodes[k].Text.ToLower())
								return false;
						}
					}
				}
			}

			return true;
		}

		private void NewGame_KeyDown(object sender, KeyEventArgs e)
		{
			if (trvTeams.Focused) {
				switch (e.KeyCode) {
					case Keys.Insert:
						btnAddPlayer_Click(sender, e);
						break;
					case Keys.Delete:
						btnRemovePlayer_Click(sender, e);
						break;
					case Keys.F2:
						if (trvTeams.SelectedNode != null)
							trvTeams.SelectedNode.BeginEdit();
						break;
				}
			}
		}

		private void btnResetCards_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Are you sure you want to reset this category?", "Reset Cards", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				if (!File.Exists(WITC.PATH_USED_BANK))
					return;
				CardBank bank = new CardBank(WITC.PATH_USED_BANK);
				string cat = cmbCategory.Text;
				if (bank.CategoryExists(cat))
					bank.RemoveCategory(cat);
			}
		}
	}
}
