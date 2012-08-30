namespace IntelOrca.WITC
{
	partial class RoundForm
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
			this.lblTimeRemaining = new System.Windows.Forms.Label();
			this.lblCard = new System.Windows.Forms.Label();
			this.btnCorrect = new System.Windows.Forms.Button();
			this.btnFoul = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnPrevious = new System.Windows.Forms.Button();
			this.btnPass = new System.Windows.Forms.Button();
			this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// lblTimeRemaining
			// 
			this.lblTimeRemaining.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTimeRemaining.Font = new System.Drawing.Font("Consolas", 92.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTimeRemaining.Location = new System.Drawing.Point(12, 9);
			this.lblTimeRemaining.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTimeRemaining.Name = "lblTimeRemaining";
			this.lblTimeRemaining.Size = new System.Drawing.Size(409, 134);
			this.lblTimeRemaining.TabIndex = 0;
			this.lblTimeRemaining.Text = "120";
			this.lblTimeRemaining.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblCard
			// 
			this.lblCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblCard.Font = new System.Drawing.Font("Calibri", 24F);
			this.lblCard.Location = new System.Drawing.Point(12, 201);
			this.lblCard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCard.Name = "lblCard";
			this.lblCard.Size = new System.Drawing.Size(409, 122);
			this.lblCard.TabIndex = 3;
			this.lblCard.Text = "Ted John";
			this.lblCard.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// btnCorrect
			// 
			this.btnCorrect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnCorrect.BackColor = System.Drawing.Color.Green;
			this.btnCorrect.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
			this.btnCorrect.Location = new System.Drawing.Point(12, 335);
			this.btnCorrect.Name = "btnCorrect";
			this.btnCorrect.Size = new System.Drawing.Size(125, 40);
			this.btnCorrect.TabIndex = 4;
			this.btnCorrect.Text = "CORRECT!";
			this.toolTip.SetToolTip(this.btnCorrect, "Click if your team mates have guessed the card\r\nfully.");
			this.btnCorrect.UseVisualStyleBackColor = false;
			this.btnCorrect.Click += new System.EventHandler(this.btnCorrect_Click);
			// 
			// btnFoul
			// 
			this.btnFoul.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnFoul.BackColor = System.Drawing.Color.Red;
			this.btnFoul.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
			this.btnFoul.Location = new System.Drawing.Point(296, 335);
			this.btnFoul.Name = "btnFoul";
			this.btnFoul.Size = new System.Drawing.Size(125, 40);
			this.btnFoul.TabIndex = 6;
			this.btnFoul.Text = "FOUL!";
			this.toolTip.SetToolTip(this.btnFoul, "Click here if you have accidently gave them part\r\nor all of the answer in anyway." +
        "");
			this.btnFoul.UseVisualStyleBackColor = false;
			this.btnFoul.Click += new System.EventHandler(this.btnFoul_Click);
			// 
			// btnNext
			// 
			this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNext.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNext.Location = new System.Drawing.Point(271, 146);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(150, 40);
			this.btnNext.TabIndex = 2;
			this.btnNext.Text = "NEXT";
			this.toolTip.SetToolTip(this.btnNext, "Click here to scroll to the next card you passed.");
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnPrevious
			// 
			this.btnPrevious.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPrevious.Location = new System.Drawing.Point(12, 146);
			this.btnPrevious.Name = "btnPrevious";
			this.btnPrevious.Size = new System.Drawing.Size(150, 40);
			this.btnPrevious.TabIndex = 1;
			this.btnPrevious.Text = "PREVIOUS";
			this.toolTip.SetToolTip(this.btnPrevious, "Click here to scroll to the previous card you passed.");
			this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
			// 
			// btnPass
			// 
			this.btnPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPass.BackColor = System.Drawing.Color.Yellow;
			this.btnPass.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
			this.btnPass.Location = new System.Drawing.Point(154, 335);
			this.btnPass.Name = "btnPass";
			this.btnPass.Size = new System.Drawing.Size(125, 40);
			this.btnPass.TabIndex = 5;
			this.btnPass.Text = "PASS!";
			this.toolTip.SetToolTip(this.btnPass, "Click here to play another card. There is a limit to how\r\nmany cards you can pass" +
        ".");
			this.btnPass.UseVisualStyleBackColor = false;
			this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
			// 
			// tmrUpdate
			// 
			this.tmrUpdate.Enabled = true;
			this.tmrUpdate.Interval = 1000;
			this.tmrUpdate.Tick += new System.EventHandler(this.tmrTime_Tick);
			// 
			// RoundForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(434, 391);
			this.ControlBox = false;
			this.Controls.Add(this.btnPass);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.btnPrevious);
			this.Controls.Add(this.btnFoul);
			this.Controls.Add(this.btnCorrect);
			this.Controls.Add(this.lblCard);
			this.Controls.Add(this.lblTimeRemaining);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "RoundForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "{ROUND}";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblTimeRemaining;
		private System.Windows.Forms.Label lblCard;
		private System.Windows.Forms.Button btnCorrect;
		private System.Windows.Forms.Button btnFoul;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnPrevious;
		private System.Windows.Forms.Button btnPass;
		private System.Windows.Forms.Timer tmrUpdate;
		private System.Windows.Forms.ToolTip toolTip;
	}
}