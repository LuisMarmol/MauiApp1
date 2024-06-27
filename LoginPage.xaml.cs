namespace MauiApp1;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private void btnLogin_Clicked(object sender, EventArgs e)
    {
		this.entPassword.Placeholder.ToString();
        this.entPassword.Text.ToString();
    }
}