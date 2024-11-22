using CollectionViewPerformanceXamarin.Models;
using CommunityToolkit.Mvvm.Input;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionViewPerformanceXamarin.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ComplexCard : Grid
    {
        public ComplexCard()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty SourceProperty = BindableProperty.Create(nameof(Source), typeof(Data), typeof(ComplexCard));

        public Data Source
        {
            get => (Data)GetValue(SourceProperty);
            set => SetValue(SourceProperty, value);
        }

        [RelayCommand]
        private async Task OpenLink()
        {
            if (Application.Current?.MainPage is null)
            {
                return;
            }

            await Application.Current.MainPage.DisplayAlert(
                "Ahoy",
                "The link was tapped",
                "Close");
        }
    }
}