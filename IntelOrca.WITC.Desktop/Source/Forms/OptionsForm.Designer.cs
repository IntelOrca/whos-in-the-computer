namespace IntelOrca.WITC
{
	partial class OptionsForm
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
			this.grpGame = new System.Windows.Forms.GroupBox();
			this.nudFoul = new System.Windows.Forms.NumericUpDown();
			this.lblFoul = new System.Windows.Forms.Label();
			this.nudPass = new System.Windows.Forms.NumericUpDown();
			this.lblPass = new System.Windows.Forms.Label();
			this.nudCorrect = new System.Windows.Forms.NumericUpDown();
			this.lblCorrect = new System.Windows.Forms.Label();
			this.grpOther = new System.Windows.Forms.GroupBox();
			this.chkSounds = new System.Windows.Forms.CheckBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.grpGame.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudFoul)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudPass)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudCorrect)).BeginInit();
			this.grpOther.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpGame
			// 
			this.grpGame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grpGame.Controls.Add(this.nudFoul);
			this.grpGame.Controls.Add(this.lblFoul);
			this.grpGame.Controls.Add(this.nudPass);
			this.grpGame.Controls.Add(this.lblPass);
			this.grpGame.Controls.Add(this.nudCorrect);
			this.grpGame.Controls.Add(this.lblCorrect);
			this.grpGame.Font = new System.Drawing.Font("Calibri", 12F);
			this.grpGame.Location = new System.Drawing.Point(12, 12);
			this.grpGame.Name = "grpGame";
			this.grpGame.Size = new System.Drawing.Size(379, 96);
			this.grpGame.TabIndex = 0;
			this.grpGame.TabStop = false;
			this.grpGame.Text = "Game Settings";
			// 
			// nudFoul
			// 
			this.nudFoul.BackColor = System.Drawing.SystemColors.Window;
			this.nudFoul.Font = new System.Drawing.Font("Calibri", 12F);
			this.nudFoul.Location = new System.Drawing.Point(282, 48);
			this.nudFoul.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
			this.nudFoul.Name = "nudFoul";
			this.nudFoul.ReadOnly = true;
			this.nudFoul.Size = new System.Drawing.Size(83, 27);
			this.nudFoul.TabIndex = 5;
			this.nudFoul.Value = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
			// 
			// lblFoul
			// 
			this.lblFoul.AutoSize = true;
			this.lblFoul.Font = new System.Drawing.Font("Calibri", 12F);
			this.lblFoul.Location = new System.Drawing.Point(260, 26);
			this.lblFoul.Name = "lblFoul";
			this.lblFoul.Size = new System.Drawing.Size(75, 19);
			this.lblFoul.TabIndex = 4;
			this.lblFoul.Text = "Foul Score";
			// 
			// nudPass
			// 
			this.nudPass.BackColor = System.Drawing.SystemColors.Window;
			this.nudPass.Font = new System.Drawing.Font("Calibri", 12F);
			this.nudPass.Location = new System.Drawing.Point(154, 48);
			this.nudPass.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
			this.nudPass.Name = "nudPass";
			this.nudPass.ReadOnly = true;
			this.nudPass.Size = new System.Drawing.Size(83, 27);
			this.nudPass.TabIndex = 3;
			// 
			// lblPass
			// 
			this.lblPass.AutoSize = true;
			this.lblPass.Font = new System.Drawing.Font("Calibri", 12F);
			this.lblPass.Location = new System.Drawing.Point(132, 26);
			this.lblPass.Name = "lblPass";
			this.lblPass.Size = new System.Drawing.Size(78, 19);
			this.lblPass.TabIndex = 2;
			this.lblPass.Text = "Pass Score";
			// 
			// nudCorrect
			// 
			this.nudCorrect.BackColor = System.Drawing.SystemColors.Window;
			this.nudCorrect.Font = new System.Drawing.Font("Calibri", 12F);
			this.nudCorrect.Location = new System.Drawing.Point(28, 48);
			this.nudCorrect.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
			this.nudCorrect.Name = "nudCorrect";
			this.nudCorrect.ReadOnly = true;
			this.nudCorrect.Size = new System.Drawing.Size(83, 27);
			this.nudCorrect.TabIndex = 1;
			this.nudCorrect.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// lblCorrect
			// 
			this.lblCorrect.AutoSize = true;
			this.lblCorrect.Font = new System.Drawing.Font("Calibri", 12F);
			this.lblCorrect.Location = new System.Drawing.Point(6, 26);
			this.lblCorrect.Name = "lblCorrect";
			this.lblCorrect.Size = new System.Drawing.Size(95, 19);
			this.lblCorrect.TabIndex = 0;
			this.lblCorrect.Text = "Correct Score";
			// 
			// grpOther
			// 
			this.grpOther.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grpOther.Controls.Add(this.chkSounds);
			this.grpOther.Font = new System.Drawing.Font("Calibri", 12F);
			this.grpOther.Location = new System.Drawing.Point(12, 114);
			this.grpOther.Name = "grpOther";
			this.grpOther.Size = new System.Drawing.Size(379, 65);
			this.grpOther.TabIndex = 1;
			this.grpOther.TabStop = false;
			this.grpOther.Text = "Other Settings";
			// 
			// chkSounds
			// 
			this.chkSounds.AutoSize = true;
			this.chkSounds.Checked = true;
			this.chkSounds.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkSounds.Font = new System.Drawing.Font("Calibri", 12F);
			this.chkSounds.Location = new System.Drawing.Point(9, 28);
			this.chkSounds.Name = "chkSounds";
			this.chkSounds.Size = new System.Drawing.Size(122, 23);
			this.chkSounds.TabIndex = 0;
			this.chkSounds.Text = "Enable Sounds";
			this.chkSounds.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Font = new System.Drawing.Font("Calibri", 12F);
			this.btnCancel.Location = new System.Drawing.Point(163, 192);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(111, 32);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Font = new System.Drawing.Font("Calibri", 12F);
			this.btnOK.Location = new System.Drawing.Point(280, 192);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(111, 32);
			this.btnOK.TabIndex = 5;
			this.btnOK.Text = "OK";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// OptionsForm
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(403, 236);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.grpOther);
			this.Controls.Add(this.grpGame);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "OptionsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Options";
			this.grpGame.ResumeLayout(false);
			this.grpGame.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudFoul)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudPass)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudCorrect)).EndInit();
			this.grpOther.ResumeLayout(false);
			this.grpOther.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grpGame;
		private System.Windows.Forms.GroupBox grpOther;
		private System.Windows.Forms.NumericUpDown nudFoul;
		private System.Windows.Forms.Label lblFoul;
		private System.Windows.Forms.NumericUpDown nudPass;
		private System.Windows.Forms.Label lblPass;
		private System.Windows.Forms.NumericUpDown nudCorrect;
		private System.Windows.Forms.Label lblCorrect;
		private System.Windows.Forms.CheckBox chkSounds;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
	}
}