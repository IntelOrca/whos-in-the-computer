////////////////////////////////////
// Who's in the Computer          //
// Copyright (C) Ted John 2012    //
// http://intelorca.co.uk         //
////////////////////////////////////

using System.Windows.Forms;

namespace IntelOrca.WITC
{
	class GameWizard
	{
		private delegate StepAction StepAction();
		private bool mCompleted;

		public static bool Run()
		{
			GameWizard wizard = new GameWizard();
			StepAction stepAction = wizard.ShowStartupForm;
			while (stepAction != null)
				stepAction = stepAction();
			return wizard.mCompleted;
		}

		private GameWizard()
		{
			mCompleted = false;
		}

		private StepAction ShowStartupForm()
		{
			StartupForm startupForm = new StartupForm();
			if (startupForm.ShowDialog() != DialogResult.OK)
				return null;

			if (startupForm.WizardResult == StartupForm.Result.ResumeLastGame) {
				Program.Game.LoadGame();

				mCompleted = true;
				return null;
			}

			Program.Game = new Game();

			Program.Game.Teams = new Team[] {
				new Team("Good"),
				new Team("Evil"),
			};
			Program.Game.Teams[0].AddPlayer("Graham", "Janet", "Ellie", "Ryan");
			Program.Game.Teams[1].AddPlayer("Becky", "James", "Ted");

			return ShowPlayerForm;
		}

		private StepAction ShowPlayerForm()
		{
			PlayerSetupForm playerSetupForm = new PlayerSetupForm();
			playerSetupForm.Teams = Program.Game.Teams;

			if (playerSetupForm.ShowDialog() != DialogResult.OK)
				return null;

			if (playerSetupForm.WizardResult == PlayerSetupForm.Result.Back)
				return ShowStartupForm;

			Program.Game.Teams = playerSetupForm.Teams;

			return ShowGameSetupForm;
		}

		private StepAction ShowGameSetupForm()
		{
			//Show game setup form
			GameSetupForm gameSetupForm = new GameSetupForm();
			if (gameSetupForm.ShowDialog() != DialogResult.OK)
				return null;

			if (gameSetupForm.WizardResult == GameSetupForm.Result.Back)
				return ShowPlayerForm;

			Program.Game.RoundDuration = gameSetupForm.RoundDuration;
			Program.Game.MaximumPasses = gameSetupForm.MaximumPasses;
			Program.Game.Category = gameSetupForm.Category;

			if (gameSetupForm.ResetReleventCards)
				Program.CardBank.ResetUsedCards(Program.Game.Category);

			Program.Game.SaveGame();

			mCompleted = true;
			return null;
		}
	}
}
