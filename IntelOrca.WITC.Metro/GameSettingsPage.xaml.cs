using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
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
	internal sealed partial class GameSettingsPage : Page, IWizardPage
	{
		private readonly GameWizardPage _gameWizardPage;

		public string Title { get { return "Game settings"; } }

		public GameSettingsPage(GameWizardPage gameWizardPage)
		{
			_gameWizardPage = gameWizardPage;

			this.InitializeComponent();

			_roundDurationTextBox.Text = 120.ToString();
			_maxPassesTextBox.Text = 3.ToString();
		}

		private void NumericTextBoxOnKeyDown(object sender, KeyRoutedEventArgs e)
		{
			e.Handled = !(
				(uint)e.Key >= (uint)VirtualKey.Number0 &&
				(uint)e.Key <= (uint)VirtualKey.Number9);
		}

		private void NumericTextBoxOnTextChanged(object sender, TextChangedEventArgs e)
		{
			TextBox textBox = (TextBox)sender;

			string newText = String.Empty;
			foreach (char c in textBox.Text)
				if (Char.IsNumber(c))
					newText += c;

			if (textBox.Text != newText)
				textBox.Text = newText;
		}

		private void BackButtonOnClick(object sender, RoutedEventArgs e)
		{
			_gameWizardPage.NavigateTo(0);
		}

		private void NextButtonOnClick(object sender, RoutedEventArgs e)
		{
			_gameWizardPage.NavigateTo(2);
		}
	}
}
