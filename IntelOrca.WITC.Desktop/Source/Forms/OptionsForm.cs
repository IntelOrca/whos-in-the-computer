using System;
using System.Windows.Forms;

namespace IntelOrca.WITC
{
	partial class OptionsForm : Form
	{
		public OptionsForm()
		{
			InitializeComponent();

			//Init settings
			nudCorrect.Value = Program.Settings.CorrectScore;
			nudPass.Value = Program.Settings.PassScore;
			nudFoul.Value = Program.Settings.FoulScore;
			chkSounds.Checked = Program.Settings.EnableSounds;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			//Apply settings
			Program.Settings.CorrectScore = (int)nudCorrect.Value;
			Program.Settings.PassScore = (int)nudPass.Value;
			Program.Settings.FoulScore = (int)nudFoul.Value;
			Program.Settings.EnableSounds = chkSounds.Checked;

			//Save settings and close
			Program.Settings.Save();

			this.DialogResult = DialogResult.OK;
			this.Close();
		}
	}
}
