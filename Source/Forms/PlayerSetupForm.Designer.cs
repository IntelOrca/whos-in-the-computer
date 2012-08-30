namespace IntelOrca.WITC
{
	partial class PlayerSetupForm
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
			this.lblInformation = new System.Windows.Forms.Label();
			this.btnContinue = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.cmbTeams = new System.Windows.Forms.ComboBox();
			this.trvTeams = new System.Windows.Forms.TreeView();
			this.btnAddPlayer = new System.Windows.Forms.Button();
			this.btnRemovePlayer = new System.Windows.Forms.Button();
			this.btnRandomTeams = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblInformation
			// 
			this.lblInformation.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInformation.Location = new System.Drawing.Point(9, 9);
			this.lblInformation.Name = "lblInformation";
			this.lblInformation.Size = new System.Drawing.Size(133, 27);
			this.lblInformation.TabIndex = 0;
			this.lblInformation.Text = "Number of teams:";
			this.lblInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnContinue
			// 
			this.btnContinue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnContinue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnContinue.Location = new System.Drawing.Point(248, 267);
			this.btnContinue.Name = "btnContinue";
			this.btnContinue.Size = new System.Drawing.Size(124, 32);
			this.btnContinue.TabIndex = 2;
			this.btnContinue.Text = "Continue";
			this.btnContinue.UseVisualStyleBackColor = true;
			this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
			// 
			// btnBack
			// 
			this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBack.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBack.Location = new System.Drawing.Point(118, 267);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(124, 32);
			this.btnBack.TabIndex = 3;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// cmbTeams
			// 
			this.cmbTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTeams.Font = new System.Drawing.Font("Calibri", 12F);
			this.cmbTeams.FormattingEnabled = true;
			this.cmbTeams.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6"});
			this.cmbTeams.Location = new System.Drawing.Point(148, 9);
			this.cmbTeams.Name = "cmbTeams";
			this.cmbTeams.Size = new System.Drawing.Size(50, 27);
			this.cmbTeams.TabIndex = 5;
			this.cmbTeams.SelectedIndexChanged += new System.EventHandler(this.cmbTeams_SelectedIndexChanged);
			// 
			// trvTeams
			// 
			this.trvTeams.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.trvTeams.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.trvTeams.LabelEdit = true;
			this.trvTeams.Location = new System.Drawing.Point(13, 42);
			this.trvTeams.Name = "trvTeams";
			this.trvTeams.Size = new System.Drawing.Size(321, 219);
			this.trvTeams.TabIndex = 6;
			this.trvTeams.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvTeams_NodeMouseClick);
			this.trvTeams.KeyDown += new System.Windows.Forms.KeyEventHandler(this.trvTeams_KeyDown);
			// 
			// btnAddPlayer
			// 
			this.btnAddPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddPlayer.Font = new System.Drawing.Font("Calibri", 12F);
			this.btnAddPlayer.Location = new System.Drawing.Point(340, 42);
			this.btnAddPlayer.Name = "btnAddPlayer";
			this.btnAddPlayer.Size = new System.Drawing.Size(32, 32);
			this.btnAddPlayer.TabIndex = 7;
			this.btnAddPlayer.Text = "+";
			this.btnAddPlayer.UseVisualStyleBackColor = true;
			this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
			// 
			// btnRemovePlayer
			// 
			this.btnRemovePlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRemovePlayer.Font = new System.Drawing.Font("Calibri", 12F);
			this.btnRemovePlayer.Location = new System.Drawing.Point(340, 80);
			this.btnRemovePlayer.Name = "btnRemovePlayer";
			this.btnRemovePlayer.Size = new System.Drawing.Size(32, 32);
			this.btnRemovePlayer.TabIndex = 8;
			this.btnRemovePlayer.Text = "-";
			this.btnRemovePlayer.UseVisualStyleBackColor = true;
			this.btnRemovePlayer.Click += new System.EventHandler(this.btnRemovePlayer_Click);
			// 
			// btnRandomTeams
			// 
			this.btnRandomTeams.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRandomTeams.Font = new System.Drawing.Font("Calibri", 12F);
			this.btnRandomTeams.Location = new System.Drawing.Point(340, 229);
			this.btnRandomTeams.Name = "btnRandomTeams";
			this.btnRandomTeams.Size = new System.Drawing.Size(32, 32);
			this.btnRandomTeams.TabIndex = 9;
			this.btnRandomTeams.Text = "?";
			this.btnRandomTeams.UseVisualStyleBackColor = true;
			this.btnRandomTeams.Click += new System.EventHandler(this.btnRandomTeams_Click);
			// 
			// PlayerSetupForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 311);
			this.Controls.Add(this.btnRandomTeams);
			this.Controls.Add(this.btnRemovePlayer);
			this.Controls.Add(this.btnAddPlayer);
			this.Controls.Add(this.trvTeams);
			this.Controls.Add(this.cmbTeams);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnContinue);
			this.Controls.Add(this.lblInformation);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PlayerSetupForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "{NAME}";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblInformation;
		private System.Windows.Forms.Button btnContinue;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.ComboBox cmbTeams;
		private System.Windows.Forms.TreeView trvTeams;
		private System.Windows.Forms.Button btnAddPlayer;
		private System.Windows.Forms.Button btnRemovePlayer;
		private System.Windows.Forms.Button btnRandomTeams;
	}
}