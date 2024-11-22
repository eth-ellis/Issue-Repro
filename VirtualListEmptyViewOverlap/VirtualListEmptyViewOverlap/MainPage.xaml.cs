using Microsoft.Maui.Adapters;
using System.Collections.ObjectModel;

namespace VirtualListEmptyViewOverlap
{
	public partial class MainPage : ContentPage
	{
		private ObservableCollection<string> content = new ObservableCollection<string>();

		public MainPage()
		{
			InitializeComponent();

			this.virtualListView.Adapter = new ObservableCollectionAdapter<string>(this.content);
		}

		private void AddContent(object sender, EventArgs e)
		{
			this.content.Add("Content");
		}

		private void ClearContent(object sender, EventArgs e)
		{
			this.content.Clear();
		}
	}
}
