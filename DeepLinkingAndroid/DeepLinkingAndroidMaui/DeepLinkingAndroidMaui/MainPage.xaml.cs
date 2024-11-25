namespace DeepLinkingAndroidMaui;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnButtonClicked(object sender, EventArgs e)
    {
        try
        {
            await WebAuthenticator.Default.AuthenticateAsync(
                new Uri("https://www.google.com"),
                new Uri("oauth://"));
        }
        catch (Exception exception)
        {
            // Do nothing
        }
    }
}