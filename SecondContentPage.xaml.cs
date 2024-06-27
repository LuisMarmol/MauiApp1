namespace MauiApp1;

public partial class SecondContentPage : ContentPage
{
	public SecondContentPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		this.Navigation.PushAsync(new ThirdContentPage());
    }
}