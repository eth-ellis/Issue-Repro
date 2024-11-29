namespace OnNavigatedFromAfterSwipe;

public partial class FirstPage : ContentPage
{
    public FirstPage()
    {
        InitializeComponent();
    }

    private void OnButtonClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SecondPage());
    }
}