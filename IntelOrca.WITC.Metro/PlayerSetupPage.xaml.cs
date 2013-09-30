using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace IntelOrca.WITC.Metro
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	internal sealed partial class PlayerSetupPage : Page, IWizardPage
	{
		private readonly GameWizardPage _gameWizardPage;

		public string Title { get { return "Players"; } }

		private readonly List<string> _teamNames = new List<string>();
		private readonly List<List<string>> _players = new List<List<string>>();

		private int _numberTeams = 0;

		public PlayerSetupPage(GameWizardPage gameWizardPage)
		{
			_gameWizardPage = gameWizardPage;

			this.InitializeComponent();

			for (int i = 1; i <= 6; i++)
				_numberOfTeamsDropDown.Items.Add(i);
			_numberOfTeamsDropDown.SelectedIndex = 0;
		}

		/// <summary>
		/// Invoked when this page is about to be displayed in a Frame.
		/// </summary>
		/// <param name="e">Event data that describes how this page was reached.  The Parameter
		/// property is typically used to configure the page.</param>
		protected override void OnNavigatedTo(NavigationEventArgs e)
		{
		}

		private void _numberOfTeamsDropDown_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			UpdateTeamsFromUi();
			ChangeNumberTeams(_numberOfTeamsDropDown.SelectedIndex + 1);
		}

		private void UpdateTeamsFromUi()
		{
			for (int i = 0; i < _teamStackPanel.Children.Count; i++) {
				var textBox = _teamStackPanel.Children[i] as TextBox;
				int teamIndex = i / 2;
				if (i % 2 == 0) {
					_teamNames[teamIndex] = textBox.Text;
				} else {
					_players[teamIndex].Clear();
					_players[teamIndex].AddRange(
						textBox.Text.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
					);
				}
			}
		}

		private void UpdateTeamsToUi()
		{
			for (int i = 0; i < _teamStackPanel.Children.Count; i++) {
				var textBox = _teamStackPanel.Children[i] as TextBox;
				int teamIndex = i / 2;

				textBox.Text = i % 2 == 0 ?
					_teamNames[teamIndex] :
					String.Join("\n", _players[teamIndex]);
			}
		}

		private void ChangeNumberTeams(int value)
		{
			int delta = value - _numberTeams;
			if (delta < 0) {
				_numberTeams = value;
				while (_teamStackPanel.Children.Count > _numberTeams * 2)
					_teamStackPanel.Children.RemoveAt(_teamStackPanel.Children.Count - 1);
			} else if (delta > 0) {
				while (_teamNames.Count < value)
					_teamNames.Add("Team " + (_teamNames.Count + 1));
				while (_players.Count < value)
					_players.Add(new List<string>());

				for (int i = 0; i < delta; i++) {
					var teamTextBox = new TextBox();
					teamTextBox.Style = Resources["TeamTextBoxStyle"] as Style;
					teamTextBox.Text = _teamNames[_numberTeams + i];

					var playersTextBox = new TextBox();
					playersTextBox.Style = Resources["PlayerTextBoxStyle"] as Style;
					playersTextBox.Text = String.Join("\n", _players[_numberTeams + i]);

					_teamStackPanel.Children.Add(teamTextBox);
					_teamStackPanel.Children.Add(playersTextBox);
				}

				_numberTeams = value;
			}
		}

		private void RandomiseButtonOnClick(object sender, RoutedEventArgs e)
		{
			var rand = new Random();

			// Update the internal player list from the ui
			UpdateTeamsFromUi();

			// Shuffle the players
			string[] shuffledPlayers = _players.Take(_numberTeams).SelectMany(x => x).OrderBy(x => rand.Next()).ToArray();

			// Clear the teams
			for (int i = 0; i < _numberTeams; i++)
				_players[i].Clear();

			// Add the players back to the teams equally
			int teamIndex = 0;
			for (int i = 0; i < shuffledPlayers.Length; i++) {
				_players[teamIndex].Add(shuffledPlayers[i]);
				teamIndex = (teamIndex + 1) % _numberTeams;
			}

			// Update the ui
			UpdateTeamsToUi();
		}

		private void BackButtonOnClick(object sender, RoutedEventArgs e)
		{
			_gameWizardPage.NavigateTo(1);
		}

		private void PlayButtonOnClick(object sender, RoutedEventArgs e)
		{

		}
	}
}
