namespace IntelOrca.WITC
{
	partial class GameSetupForm
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
			this.lblRoundDuration = new System.Windows.Forms.Label();
			this.nudRoundDuration = new System.Windows.Forms.NumericUpDown();
			this.lblSuperCategories = new System.Windows.Forms.Label();
			this.chkResetReleventCards = new System.Windows.Forms.CheckBox();
			this.nudMaxPasses = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.clbCategories = new System.Windows.Forms.CheckedListBox();
			((System.ComponentModel.ISupportInitialize)(this.nudRoundDuration)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMaxPasses)).BeginInit();
			this.SuspendLayout();
			// 
			// lblInformation
			// 
			this.lblInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblInformation.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInformation.Location = new System.Drawing.Point(9, 9);
			this.lblInformation.Name = "lblInformation";
			this.lblInformation.Size = new System.Drawing.Size(362, 23);
			this.lblInformation.TabIndex = 0;
			this.lblInformation.Text = "Set the game options to your liking.";
			// 
			// btnContinue
			// 
			this.btnContinue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnContinue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnContinue.Location = new System.Drawing.Point(250, 341);
			this.btnContinue.Name = "btnContinue";
			this.btnContinue.Size = new System.Drawing.Size(124, 32);
			this.btnContinue.TabIndex = 2;
			this.btnContinue.Text = "Play";
			this.btnContinue.UseVisualStyleBackColor = true;
			this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
			// 
			// btnBack
			// 
			this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBack.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBack.Location = new System.Drawing.Point(120, 341);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(124, 32);
			this.btnBack.TabIndex = 3;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// lblRoundDuration
			// 
			this.lblRoundDuration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblRoundDuration.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRoundDuration.Location = new System.Drawing.Point(9, 41);
			this.lblRoundDuration.Name = "lblRoundDuration";
			this.lblRoundDuration.Size = new System.Drawing.Size(362, 23);
			this.lblRoundDuration.TabIndex = 4;
			this.lblRoundDuration.Text = "Round duration (seconds):";
			// 
			// nudRoundDuration
			// 
			this.nudRoundDuration.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nudRoundDuration.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.nudRoundDuration.Location = new System.Drawing.Point(29, 67);
			this.nudRoundDuration.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
			this.nudRoundDuration.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
			this.nudRoundDuration.Name = "nudRoundDuration";
			this.nudRoundDuration.Size = new System.Drawing.Size(215, 27);
			this.nudRoundDuration.TabIndex = 5;
			this.nudRoundDuration.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
			// 
			// lblSuperCategories
			// 
			this.lblSuperCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblSuperCategories.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSuperCategories.Location = new System.Drawing.Point(9, 183);
			this.lblSuperCategories.Name = "lblSuperCategories";
			this.lblSuperCategories.Size = new System.Drawing.Size(362, 23);
			this.lblSuperCategories.TabIndex = 6;
			this.lblSuperCategories.Text = "Categories (0):";
			// 
			// chkResetReleventCards
			// 
			this.chkResetReleventCards.AutoSize = true;
			this.chkResetReleventCards.Font = new System.Drawing.Font("Calibri", 12F);
			this.chkResetReleventCards.Location = new System.Drawing.Point(29, 309);
			this.chkResetReleventCards.Name = "chkResetReleventCards";
			this.chkResetReleventCards.Size = new System.Drawing.Size(161, 23);
			this.chkResetReleventCards.TabIndex = 11;
			this.chkResetReleventCards.Text = "Reset relevent cards";
			this.chkResetReleventCards.UseVisualStyleBackColor = true;
			// 
			// nudMaxPasses
			// 
			this.nudMaxPasses.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nudMaxPasses.Location = new System.Drawing.Point(29, 137);
			this.nudMaxPasses.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
			this.nudMaxPasses.Name = "nudMaxPasses";
			this.nudMaxPasses.Size = new System.Drawing.Size(215, 27);
			this.nudMaxPasses.TabIndex = 14;
			this.nudMaxPasses.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(9, 111);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(362, 23);
			this.label1.TabIndex = 13;
			this.label1.Text = "Maximum passes:";
			// 
			// clbCategories
			// 
			this.clbCategories.CheckOnClick = true;
			this.clbCategories.Font = new System.Drawing.Font("Calibri", 12F);
			this.clbCategories.FormattingEnabled = true;
			this.clbCategories.Location = new System.Drawing.Point(29, 209);
			this.clbCategories.Name = "clbCategories";
			this.clbCategories.ScrollAlwaysVisible = true;
			this.clbCategories.Size = new System.Drawing.Size(215, 92);
			this.clbCategories.TabIndex = 15;
			this.clbCategories.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbCategories_ItemCheck);
			// 
			// GameSetupForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(386, 385);
			this.Controls.Add(this.clbCategories);
			this.Controls.Add(this.nudMaxPasses);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.chkResetReleventCards);
			this.Controls.Add(this.lblSuperCategories);
			this.Controls.Add(this.nudRoundDuration);
			this.Controls.Add(this.lblRoundDuration);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnContinue);
			this.Controls.Add(this.lblInformation);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "GameSetupForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "{NAME}";
			((System.ComponentModel.ISupportInitialize)(this.nudRoundDuration)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMaxPasses)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblInformation;
		private System.Windows.Forms.Button btnContinue;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Label lblRoundDuration;
		private System.Windows.Forms.NumericUpDown nudRoundDuration;
		private System.Windows.Forms.Label lblSuperCategories;
		private System.Windows.Forms.CheckBox chkResetReleventCards;
		private System.Windows.Forms.NumericUpDown nudMaxPasses;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckedListBox clbCategories;
	}
}