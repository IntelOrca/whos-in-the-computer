////////////////////////////////////
// Who's in the Computer          //
// Copyright (C) Ted John 2012    //
// http://intelorca.co.uk         //
////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IntelOrca.WITC
{
	partial class PlayerSetupForm : Form
	{
		public enum Result
		{
			Back,
			Continue,
		}

		private Result mResult;
		private int mNumTeams;
		private Team[] mTeams;

		public PlayerSetupForm()
		{
			InitializeComponent();

			this.Icon = Program.AppIcon;
			this.Text = Program.AppName;

			cmbTeams.SelectedIndex = 0;
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if (mTeams == null)
				return;
			cmbTeams.SelectedIndex = mTeams.Length - 2;
			trvTeams.Nodes.Clear();
			foreach (Team team in mTeams) {
				TreeNode teamNode = new TreeNode(team.Name);
				foreach (Player player in team)
					teamNode.Nodes.Add(player.Name);
				trvTeams.Nodes.Add(teamNode);
			}
			trvTeams.ExpandAll();
		}

		private void cmbTeams_SelectedIndexChanged(object sender, EventArgs e)
		{
			int newteam = cmbTeams.SelectedIndex + 2;

			if (newteam < mNumTeams) {
				for (int i = mNumTeams - 1; i > newteam - 1; i--)
					trvTeams.Nodes.RemoveAt(i);
			} else {
				for (int i = mNumTeams; i < newteam; i++)
					trvTeams.Nodes.Add("Team " + (i + 1));
			}
			mNumTeams = newteam;

			if (trvTeams.Nodes.Count > 0)
				trvTeams.SelectedNode = trvTeams.Nodes[0];
		}

		private void btnAddPlayer_Click(object sender, EventArgs e)
		{
			// Check if there is a selected node
			if (trvTeams.SelectedNode == null)
				return;

			// Determine parent node
			TreeNode parent;
			if (trvTeams.SelectedNode.Level == 0)
				parent = trvTeams.SelectedNode;
			else
				parent = trvTeams.SelectedNode.Parent;

			// Create a new player mode
			TreeNode newplayer = new TreeNode("New player");
			parent.Nodes.Add(newplayer);
			trvTeams.SelectedNode = newplayer;
			newplayer.BeginEdit();
		}

		private void btnRemovePlayer_Click(object sender, EventArgs e)
		{
			// Check if there is a selected node
			if (trvTeams.SelectedNode == null)
				return;

			// Check if it is a player node
			if (trvTeams.SelectedNode.Level != 1)
				return;

			TreeNode node = trvTeams.SelectedNode;

			// Select the previous/next node
			if (node.NextNode == null) {
				if (node.PrevNode == null)
					trvTeams.SelectedNode = node.Parent;
				else
					trvTeams.SelectedNode = node.PrevNode;
			} else {
				trvTeams.SelectedNode = node.NextNode;
			}

			// Remove the node
			node.Remove();

			// Focus the control
			trvTeams.Focus();
		}

		private void btnRandomTeams_Click(object sender, EventArgs e)
		{
			Random r = new Random();
			List<string> players = new List<string>();

			// Get each player and remove it from the team
			foreach (TreeNode team in trvTeams.Nodes) {
				foreach (TreeNode player in team.Nodes)
					players.Add(player.Text);
				team.Nodes.Clear();
			}

			//Mix up players
			players = new List<string>(players.OrderBy(player => r.Next()));

			//Replace them
			int teamcount = trvTeams.Nodes.Count;
			int t = 0;
			foreach (string player in players) {
				trvTeams.Nodes[t].Nodes.Add(player);
				t = (t + 1) % teamcount;
			}

			// Expand all the nodes
			trvTeams.ExpandAll();
		}

		private void trvTeams_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			trvTeams.SelectedNode = e.Node;
		}

		private void trvTeams_KeyDown(object sender, KeyEventArgs e)
		{
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

		private void btnBack_Click(object sender, EventArgs e)
		{
			mResult = Result.Back;
			this.DialogResult = DialogResult.OK;
			Close();
		}

		private void btnContinue_Click(object sender, EventArgs e)
		{
			Team[] teams = GetTeams();
			if (!PlayerTeamNameCheck(teams)) {
				MessageBox.Show("There are duplicate player or team names.", Program.AppName);
				return;
			}

			if (teams.Any(t => (t.Players.Count == 0))) {
				MessageBox.Show("There are teams with no players.", Program.AppName);
				return;
			}

			mTeams = teams;

			mResult = Result.Continue;
			this.DialogResult = DialogResult.OK;
			Close();
		}

		private bool PlayerTeamNameCheck(Team[] teams)
		{
			// Check for teams with same name
			if (teams.GroupBy(t => t.Name.ToLower()).Where(g => g.Count() > 1).Count() > 0)
				return false;

			// Check for player names
			List<string> players = new List<string>();
			foreach (Team t in teams)
				players.AddRange(t.Players.Select(p => p.Name));
			if (players.GroupBy(p => p.ToLower()).Where(g => g.Count() > 1).Count() > 0)
				return false;

			return true;
		}

		private Team[] GetTeams()
		{
			List<Team> teams = new List<Team>();
			foreach (TreeNode node in trvTeams.Nodes) {
				Team team = new Team(node.Text);
				foreach (TreeNode player in node.Nodes)
					team.AddPlayer(player.Text);
				teams.Add(team);
			}
			return teams.ToArray();
		}

		public Result WizardResult
		{
			get
			{
				return mResult;
			}
		}

		public Team[] Teams
		{
			get
			{
				return mTeams;
			}
			set
			{
				mTeams = value;
			}
		}
	}
}
