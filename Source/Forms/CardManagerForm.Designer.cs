namespace WITC.Forms
{
	partial class CardManager
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
			this.trvCards = new System.Windows.Forms.TreeView();
			this.mnuCards = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.addCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.lblCards = new System.Windows.Forms.Label();
			this.btnMerge = new System.Windows.Forms.Button();
			this.mnuCards.SuspendLayout();
			this.SuspendLayout();
			// 
			// trvCards
			// 
			this.trvCards.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.trvCards.ContextMenuStrip = this.mnuCards;
			this.trvCards.LabelEdit = true;
			this.trvCards.Location = new System.Drawing.Point(12, 12);
			this.trvCards.Name = "trvCards";
			this.trvCards.Size = new System.Drawing.Size(433, 291);
			this.trvCards.TabIndex = 0;
			this.trvCards.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.trvCards_AfterLabelEdit);
			this.trvCards.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvCards_AfterSelect);
			this.trvCards.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvCards_NodeMouseClick);
			// 
			// mnuCards
			// 
			this.mnuCards.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCategoryToolStripMenuItem,
            this.addCardToolStripMenuItem,
            this.editToolStripMenuItem,
            this.removeToolStripMenuItem});
			this.mnuCards.Name = "mnuCards";
			this.mnuCards.Size = new System.Drawing.Size(148, 92);
			// 
			// addCategoryToolStripMenuItem
			// 
			this.addCategoryToolStripMenuItem.Name = "addCategoryToolStripMenuItem";
			this.addCategoryToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.addCategoryToolStripMenuItem.Text = "Add Category";
			this.addCategoryToolStripMenuItem.Click += new System.EventHandler(this.addCategoryToolStripMenuItem_Click);
			// 
			// addCardToolStripMenuItem
			// 
			this.addCardToolStripMenuItem.Name = "addCardToolStripMenuItem";
			this.addCardToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Insert;
			this.addCardToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.addCardToolStripMenuItem.Text = "Add Card";
			this.addCardToolStripMenuItem.Click += new System.EventHandler(this.addCardToolStripMenuItem_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
			this.editToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.editToolStripMenuItem.Text = "Edit";
			this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
			// 
			// removeToolStripMenuItem
			// 
			this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
			this.removeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
			this.removeToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.removeToolStripMenuItem.Text = "Remove";
			this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.BackColor = System.Drawing.Color.Green;
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnOK.Location = new System.Drawing.Point(370, 309);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 25);
			this.btnOK.TabIndex = 3;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = false;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.BackColor = System.Drawing.Color.Red;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCancel.Location = new System.Drawing.Point(289, 309);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 25);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// lblCards
			// 
			this.lblCards.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblCards.AutoSize = true;
			this.lblCards.Location = new System.Drawing.Point(12, 321);
			this.lblCards.Name = "lblCards";
			this.lblCards.Size = new System.Drawing.Size(49, 13);
			this.lblCards.TabIndex = 1;
			this.lblCards.Text = "Cards : 0";
			// 
			// btnMerge
			// 
			this.btnMerge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMerge.BackColor = System.Drawing.Color.Yellow;
			this.btnMerge.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnMerge.Location = new System.Drawing.Point(153, 309);
			this.btnMerge.Name = "btnMerge";
			this.btnMerge.Size = new System.Drawing.Size(90, 25);
			this.btnMerge.TabIndex = 4;
			this.btnMerge.Text = "Import Cards";
			this.btnMerge.UseVisualStyleBackColor = false;
			this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
			// 
			// CardManager
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(457, 346);
			this.Controls.Add(this.btnMerge);
			this.Controls.Add(this.lblCards);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.trvCards);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CardManager";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Card Manager";
			this.mnuCards.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TreeView trvCards;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.ContextMenuStrip mnuCards;
		private System.Windows.Forms.ToolStripMenuItem addCategoryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addCardToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
		private System.Windows.Forms.Label lblCards;
		private System.Windows.Forms.Button btnMerge;
	}
}