using CollectionViewPerformanceXamarin.ViewModels;
using Xamarin.Forms;

namespace CollectionViewPerformanceXamarin.Views
{
	public partial class DataView : ContentPage
	{
		public DataView(DataViewModel viewModel)
		{
			InitializeComponent();

			this.BindingContext = viewModel;
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			_ = ((DataViewModel)this.BindingContext).InitialiseAsync();
		}
	}
}