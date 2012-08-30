namespace WITC.Forms
{
	partial class NewGame
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.grpSettings = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.nudTurnTime = new System.Windows.Forms.NumericUpDown();
			this.cmbCategory = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.nudMaxPasses = new System.Windows.Forms.NumericUpDown();
			this.cmbGameTime = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lblRounds = new System.Windows.Forms.Label();
			this.chkTime = new System.Windows.Forms.CheckBox();
			this.chkRounds = new System.Windows.Forms.CheckBox();
			this.nudRounds = new System.Windows.Forms.NumericUpDown();
			this.lblObjectives = new System.Windows.Forms.Label();
			this.lblTurnTime = new System.Windows.Forms.Label();
			this.grpTeams = new System.Windows.Forms.GroupBox();
			this.btnRandom = new System.Windows.Forms.Button();
			this.btnRemovePlayer = new System.Windows.Forms.Button();
			this.btnAddPlayer = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.cmbTeams = new System.Windows.Forms.ComboBox();
			this.trvTeams = new System.Windows.Forms.TreeView();
			this.btnPlay = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.btnResetCards = new System.Windows.Forms.Button();
			this.grpSettings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudTurnTime)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMaxPasses)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudRounds)).BeginInit();
			this.grpTeams.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpSettings
			// 
			this.grpSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.grpSettings.Controls.Add(this.btnResetCards);
			this.grpSettings.Controls.Add(this.label6);
			this.grpSettings.Controls.Add(this.nudTurnTime);
			this.grpSettings.Controls.Add(this.cmbCategory);
			this.grpSettings.Controls.Add(this.label5);
			this.grpSettings.Controls.Add(this.label4);
			this.grpSettings.Controls.Add(this.nudMaxPasses);
			this.grpSettings.Controls.Add(this.cmbGameTime);
			this.grpSettings.Controls.Add(this.label2);
			this.grpSettings.Controls.Add(this.lblRounds);
			this.grpSettings.Controls.Add(this.chkTime);
			this.grpSettings.Controls.Add(this.chkRounds);
			this.grpSettings.Controls.Add(this.nudRounds);
			this.grpSettings.Controls.Add(this.lblObjectives);
			this.grpSettings.Controls.Add(this.lblTurnTime);
			this.grpSettings.Location = new System.Drawing.Point(12, 12);
			this.grpSettings.Name = "grpSettings";
			this.grpSettings.Size = new System.Drawing.Size(319, 218);
			this.grpSettings.TabIndex = 0;
			this.grpSettings.TabStop = false;
			this.grpSettings.Text = "Settings";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(110, 52);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(62, 16);
			this.label6.TabIndex = 15;
			this.label6.Text = "Seconds";
			// 
			// nudTurnTime
			// 
			this.nudTurnTime.BackColor = System.Drawing.Color.White;
			this.nudTurnTime.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.nudTurnTime.Location = new System.Drawing.Point(29, 50);
			this.nudTurnTime.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
			this.nudTurnTime.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.nudTurnTime.Name = "nudTurnTime";
			this.nudTurnTime.ReadOnly = true;
			this.nudTurnTime.Size = new System.Drawing.Size(75, 22);
			this.nudTurnTime.TabIndex = 1;
			this.toolTip.SetToolTip(this.nudTurnTime, "How long the players can guess for in a turn.");
			this.nudTurnTime.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
			// 
			// cmbCategory
			// 
			this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cmbCategory.FormattingEnabled = true;
			this.cmbCategory.Location = new System.Drawing.Point(29, 181);
			this.cmbCategory.Name = "cmbCategory";
			this.cmbCategory.Size = new System.Drawing.Size(161, 24);
			this.cmbCategory.TabIndex = 6;
			this.toolTip.SetToolTip(this.cmbCategory, "The category to choose the cards from.");
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(8, 162);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(66, 16);
			this.label5.TabIndex = 5;
			this.label5.Text = "Category:";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(193, 18);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(117, 16);
			this.label4.TabIndex = 8;
			this.label4.Text = "Maximum Passes:";
			// 
			// nudMaxPasses
			// 
			this.nudMaxPasses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.nudMaxPasses.BackColor = System.Drawing.SystemColors.Window;
			this.nudMaxPasses.Location = new System.Drawing.Point(216, 37);
			this.nudMaxPasses.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.nudMaxPasses.Name = "nudMaxPasses";
			this.nudMaxPasses.ReadOnly = true;
			this.nudMaxPasses.Size = new System.Drawing.Size(97, 22);
			this.nudMaxPasses.TabIndex = 9;
			this.toolTip.SetToolTip(this.nudMaxPasses, "The maximum passes allowed during a round.");
			this.nudMaxPasses.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// cmbGameTime
			// 
			this.cmbGameTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmbGameTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbGameTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cmbGameTime.FormattingEnabled = true;
			this.cmbGameTime.Items.AddRange(new object[] {
            "30 Minutes",
            "1 Hour",
            "2 Hours",
            "3 Hours",
            "4 Hours",
            "5 Hours"});
			this.cmbGameTime.Location = new System.Drawing.Point(216, 135);
			this.cmbGameTime.Name = "cmbGameTime";
			this.cmbGameTime.Size = new System.Drawing.Size(97, 24);
			this.cmbGameTime.TabIndex = 13;
			this.toolTip.SetToolTip(this.cmbGameTime, "How long the game should last before ending.");
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(193, 116);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(101, 16);
			this.label2.TabIndex = 12;
			this.label2.Text = "Game Duration:";
			// 
			// lblRounds
			// 
			this.lblRounds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblRounds.AutoSize = true;
			this.lblRounds.Location = new System.Drawing.Point(193, 69);
			this.lblRounds.Name = "lblRounds";
			this.lblRounds.Size = new System.Drawing.Size(58, 16);
			this.lblRounds.TabIndex = 10;
			this.lblRounds.Text = "Rounds:";
			// 
			// chkTime
			// 
			this.chkTime.AutoSize = true;
			this.chkTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.chkTime.Location = new System.Drawing.Point(29, 139);
			this.chkTime.Name = "chkTime";
			this.chkTime.Size = new System.Drawing.Size(56, 20);
			this.chkTime.TabIndex = 4;
			this.chkTime.Text = "Time";
			this.toolTip.SetToolTip(this.chkTime, "Check if the game should end when the time reaches\r\nthe target time. The team wit" +
					"h the highest amout of\r\npoints wins. The game will end with an equal amount\r\nof " +
					"turns for each team.");
			this.chkTime.UseVisualStyleBackColor = true;
			this.chkTime.CheckedChanged += new System.EventHandler(this.chkTime_CheckedChanged);
			// 
			// chkRounds
			// 
			this.chkRounds.AutoSize = true;
			this.chkRounds.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.chkRounds.Location = new System.Drawing.Point(29, 113);
			this.chkRounds.Name = "chkRounds";
			this.chkRounds.Size = new System.Drawing.Size(72, 20);
			this.chkRounds.TabIndex = 3;
			this.chkRounds.Text = "Rounds";
			this.toolTip.SetToolTip(this.chkRounds, "Check if the game should end when a number of\r\nrounds have passed. The team with " +
					"the most\r\nwins.");
			this.chkRounds.UseVisualStyleBackColor = true;
			this.chkRounds.CheckedChanged += new System.EventHandler(this.chkPoints_CheckedChanged);
			// 
			// nudRounds
			// 
			this.nudRounds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.nudRounds.BackColor = System.Drawing.SystemColors.Window;
			this.nudRounds.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.nudRounds.Location = new System.Drawing.Point(216, 88);
			this.nudRounds.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
			this.nudRounds.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.nudRounds.Name = "nudRounds";
			this.nudRounds.ReadOnly = true;
			this.nudRounds.Size = new System.Drawing.Size(97, 22);
			this.nudRounds.TabIndex = 11;
			this.toolTip.SetToolTip(this.nudRounds, "The number of rounds should pass to end the\r\ngame.");
			this.nudRounds.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
			// 
			// lblObjectives
			// 
			this.lblObjectives.AutoSize = true;
			this.lblObjectives.Location = new System.Drawing.Point(6, 94);
			this.lblObjectives.Name = "lblObjectives";
			this.lblObjectives.Size = new System.Drawing.Size(75, 16);
			this.lblObjectives.TabIndex = 2;
			this.lblObjectives.Text = "Objectives:";
			// 
			// lblTurnTime
			// 
			this.lblTurnTime.AutoSize = true;
			this.lblTurnTime.Location = new System.Drawing.Point(6, 31);
			this.lblTurnTime.Name = "lblTurnTime";
			this.lblTurnTime.Size = new System.Drawing.Size(91, 16);
			this.lblTurnTime.TabIndex = 0;
			this.lblTurnTime.Text = "Turn Duration:";
			// 
			// grpTeams
			// 
			this.grpTeams.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.grpTeams.Controls.Add(this.btnRandom);
			this.grpTeams.Controls.Add(this.btnRemovePlayer);
			this.grpTeams.Controls.Add(this.btnAddPlayer);
			this.grpTeams.Controls.Add(this.label3);
			this.grpTeams.Controls.Add(this.cmbTeams);
			this.grpTeams.Controls.Add(this.trvTeams);
			this.grpTeams.Location = new System.Drawing.Point(12, 236);
			this.grpTeams.Name = "grpTeams";
			this.grpTeams.Size = new System.Drawing.Size(319, 178);
			this.grpTeams.TabIndex = 1;
			this.grpTeams.TabStop = false;
			this.grpTeams.Text = "Teams";
			// 
			// btnRandom
			// 
			this.btnRandom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRandom.BackColor = System.Drawing.Color.Brown;
			this.btnRandom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRandom.Location = new System.Drawing.Point(281, 140);
			this.btnRandom.Name = "btnRandom";
			this.btnRandom.Size = new System.Drawing.Size(32, 32);
			this.btnRandom.TabIndex = 5;
			this.btnRandom.Text = "?";
			this.toolTip.SetToolTip(this.btnRandom, "Randomize the players in different teams.");
			this.btnRandom.UseVisualStyleBackColor = false;
			this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
			// 
			// btnRemovePlayer
			// 
			this.btnRemovePlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRemovePlayer.BackColor = System.Drawing.Color.Brown;
			this.btnRemovePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnRemovePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRemovePlayer.Location = new System.Drawing.Point(281, 89);
			this.btnRemovePlayer.Name = "btnRemovePlayer";
			this.btnRemovePlayer.Size = new System.Drawing.Size(32, 32);
			this.btnRemovePlayer.TabIndex = 4;
			this.btnRemovePlayer.Text = "-";
			this.toolTip.SetToolTip(this.btnRemovePlayer, "Remove the selected player from the team.");
			this.btnRemovePlayer.UseVisualStyleBackColor = false;
			this.btnRemovePlayer.Click += new System.EventHandler(this.btnRemovePlayer_Click);
			// 
			// btnAddPlayer
			// 
			this.btnAddPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddPlayer.BackColor = System.Drawing.Color.Brown;
			this.btnAddPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnAddPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddPlayer.Location = new System.Drawing.Point(281, 51);
			this.btnAddPlayer.Name = "btnAddPlayer";
			this.btnAddPlayer.Size = new System.Drawing.Size(32, 32);
			this.btnAddPlayer.TabIndex = 3;
			this.btnAddPlayer.Text = "+";
			this.toolTip.SetToolTip(this.btnAddPlayer, "Add a new player to the selected team.");
			this.btnAddPlayer.UseVisualStyleBackColor = false;
			this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(116, 16);
			this.label3.TabIndex = 0;
			this.label3.Text = "Number of Teams";
			// 
			// cmbTeams
			// 
			this.cmbTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTeams.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cmbTeams.FormattingEnabled = true;
			this.cmbTeams.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6"});
			this.cmbTeams.Location = new System.Drawing.Point(128, 21);
			this.cmbTeams.Name = "cmbTeams";
			this.cmbTeams.Size = new System.Drawing.Size(44, 24);
			this.cmbTeams.TabIndex = 1;
			this.toolTip.SetToolTip(this.cmbTeams, "The number of teams to play the game.");
			this.cmbTeams.SelectedIndexChanged += new System.EventHandler(this.cmbTeams_SelectedIndexChanged);
			// 
			// trvTeams
			// 
			this.trvTeams.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.trvTeams.LabelEdit = true;
			this.trvTeams.Location = new System.Drawing.Point(6, 51);
			this.trvTeams.Name = "trvTeams";
			this.trvTeams.Size = new System.Drawing.Size(269, 121);
			this.trvTeams.TabIndex = 2;
			// 
			// btnPlay
			// 
			this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPlay.BackColor = System.Drawing.Color.Green;
			this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnPlay.Location = new System.Drawing.Point(246, 420);
			this.btnPlay.Name = "btnPlay";
			this.btnPlay.Size = new System.Drawing.Size(85, 25);
			this.btnPlay.TabIndex = 3;
			this.btnPlay.Text = "Play";
			this.btnPlay.UseVisualStyleBackColor = false;
			this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
			// 
			// btnExit
			// 
			this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExit.BackColor = System.Drawing.Color.Red;
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnExit.Location = new System.Drawing.Point(155, 420);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(85, 25);
			this.btnExit.TabIndex = 2;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnResetCards
			// 
			this.btnResetCards.BackColor = System.Drawing.Color.Yellow;
			this.btnResetCards.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnResetCards.Location = new System.Drawing.Point(216, 181);
			this.btnResetCards.Name = "btnResetCards";
			this.btnResetCards.Size = new System.Drawing.Size(94, 24);
			this.btnResetCards.TabIndex = 16;
			this.btnResetCards.Text = "Reset Cards";
			this.btnResetCards.UseVisualStyleBackColor = false;
			this.btnResetCards.Click += new System.EventHandler(this.btnResetCards_Click);
			// 
			// NewGame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(343, 457);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnPlay);
			this.Controls.Add(this.grpTeams);
			this.Controls.Add(this.grpSettings);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "NewGame";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "New Game";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewGame_KeyDown);
			this.grpSettings.ResumeLayout(false);
			this.grpSettings.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudTurnTime)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMaxPasses)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudRounds)).EndInit();
			this.grpTeams.ResumeLayout(false);
			this.grpTeams.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grpSettings;
		private System.Windows.Forms.Label lblTurnTime;
		private System.Windows.Forms.GroupBox grpTeams;
		private System.Windows.Forms.Button btnPlay;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Label lblObjectives;
		private System.Windows.Forms.CheckBox chkRounds;
		private System.Windows.Forms.NumericUpDown nudRounds;
		private System.Windows.Forms.CheckBox chkTime;
		private System.Windows.Forms.Label lblRounds;
		private System.Windows.Forms.ComboBox cmbGameTime;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbTeams;
		private System.Windows.Forms.TreeView trvTeams;
		private System.Windows.Forms.Button btnAddPlayer;
		private System.Windows.Forms.Button btnRemovePlayer;
		private System.Windows.Forms.Button btnRandom;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown nudMaxPasses;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cmbCategory;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown nudTurnTime;
		private System.Windows.Forms.Button btnResetCards;
	}
}