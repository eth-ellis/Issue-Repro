using CollectionViewPerformanceXamarin.Services;
using CollectionViewPerformanceXamarin.ViewModels;
using CollectionViewPerformanceXamarin.Views;
using Xamarin.Forms;

namespace CollectionViewPerformanceXamarin
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			var dataService = new DataService();
			var viewModel = new DataViewModel(dataService);
			var view = new DataView(viewModel);

			MainPage = new NavigationPage(view);
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
