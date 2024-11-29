namespace OnNavigatedFromAfterSwipe;

public partial class SecondPage : ContentPage
{
    public SecondPage()
    {
        InitializeComponent();
    }
    
    protected override void OnNavigatedFrom(NavigatedFromEventArgs args)
    {
        base.OnNavigatedFrom(args);

        Application.Current?.MainPage?.DisplayAlert(
            "Navigated",
            "Navigated from second page",
            "OK");
    }
}