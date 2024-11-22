using System.Collections.ObjectModel;

namespace MauiAppCollectionViewFooterResize
{
    internal class ViewModel
    {
        public ObservableCollection<string> ItemList { get; set; }

        public ObservableCollection<string> ItemListFooter { get; set; }

        public Command AddCommand => new (Add);

        public ViewModel()
        {
            ItemList = new ObservableCollection<string>
            {
                "Red",
                "Blue",
                "Green",
                "Red",
                "Blue",
                "Green",
                "Red",
                "Blue",
                "Green",
                "Red",
                "Blue",
                "Green",
                "Red",
                "Blue",
                "Green",
            };
            ItemListFooter = new ObservableCollection<string>
            {
                "Paris",
                "London"
            };
        }

        private void Add()
        {
            ItemListFooter.Add("Madrid");
        }
    }
}
