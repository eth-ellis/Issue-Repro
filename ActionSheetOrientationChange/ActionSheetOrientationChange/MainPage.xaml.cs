namespace ActionSheetOrientationChange;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnButtonClicked(object sender, EventArgs e)
    {
        DisplayActionSheet("ActionSheet", "Cancel", "Destruction", "Option1", "Option2", "Option3");
    }
}