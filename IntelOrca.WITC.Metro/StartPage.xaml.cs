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
	internal sealed partial class StartPage : Page, IWizardPage
	{
		private readonly GameWizardPage _gameWizardPage;

		public string Title { get { return "Start"; } }

		public StartPage(GameWizardPage gameWizardPage)
		{
			_gameWizardPage = gameWizardPage;

			this.InitializeComponent();

			_resumePreviousGameButton.IsEnabled = false;
		}

		private void StartNewGameButtonOnClick(object sender, RoutedEventArgs e)
		{
			_gameWizardPage.NavigateTo(1);
		}

		private void ResumePreviousGameButtonOnClick(object sender, RoutedEventArgs e)
		{

		}
	}
}
