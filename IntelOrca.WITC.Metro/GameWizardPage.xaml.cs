using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace IntelOrca.WITC.Metro
{
	internal interface IWizardPage
	{
		string Title { get; }
	}

	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	internal sealed partial class GameWizardPage : Page
	{
		private readonly List<IWizardPage> _pages = new List<IWizardPage>();

		public IReadOnlyList<IWizardPage> Pages { get { return _pages; } }

		public GameWizardPage()
		{
			this.InitializeComponent();

			_pages.Add(new StartPage(this));
			_pages.Add(new GameSettingsPage(this));
			_pages.Add(new PlayerSetupPage(this));

			UpdateFlipView();
			UpdateNavigationItems();
			UpdateNavigationBarSelection();
		}

		/// <summary>
		/// Invoked when this page is about to be displayed in a Frame.
		/// </summary>
		/// <param name="e">Event data that describes how this page was reached.  The Parameter
		/// property is typically used to configure the page.</param>
		protected override void OnNavigatedTo(NavigationEventArgs e)
		{
		}

		public void NavigateTo(IWizardPage page)
		{
			NavigateTo(_pages.IndexOf(page));
		}

		public void NavigateTo(int pageIndex)
		{
			_flipView.SelectedIndex = pageIndex;
		}

		private void UpdateFlipView()
		{
			_flipView.Items.Clear();
			foreach (IWizardPage page in _pages)
				_flipView.Items.Add(page);
		}

		private void UpdateNavigationItems()
		{
			_navigationBar.Children.Clear();
			foreach (IWizardPage page in _pages) {
				var navigationItem = new Button();
				navigationItem.Tag = page;
				navigationItem.Template = Resources["NavigationItem"] as ControlTemplate;
				navigationItem.Content = page.Title;
				navigationItem.Click += (s, e) => {
					NavigateTo(navigationItem.Tag as IWizardPage);
				};

				_navigationBar.Children.Add(navigationItem);
			}
		}

		private void UpdateNavigationBarSelection()
		{
			int index = _flipView.SelectedIndex;
			for (int i = 0; i < _navigationBar.Children.Count; i++) {
				var button = _navigationBar.Children[i] as Button;
				if (i == index)
					button.Foreground = new SolidColorBrush(Colors.White);
				else
					button.Foreground = new SolidColorBrush(Colors.Gray);
			}
		}

		private void _flipView_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			UpdateNavigationBarSelection();
		}
	}
}
