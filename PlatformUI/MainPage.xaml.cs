namespace PlatformUI;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnButtonClicked(object sender, EventArgs e)
    {
        var page =
#if IOS || ANDROID
            new HelloFromMobilePage();
#elif WINDOWS || MACCATALYST
            new HelloFromDesktopPage();
#endif
        await Navigation.PushAsync(page);
    }
}
