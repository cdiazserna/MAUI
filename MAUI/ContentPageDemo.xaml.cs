namespace MAUI;

public partial class ContentPageDemo : ContentPage
{
	public ContentPageDemo()
	{
		InitializeComponent();
	}

    private void Button_Clicked_Again(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}