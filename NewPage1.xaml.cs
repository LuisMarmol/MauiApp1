namespace MauiApp1;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}
	private void btn1_Pressed(object sender, EventArgs e)
	{
		this.lblNombre.Text = DateTime.Now.ToString("dd/MM/yyyy");
		this.lblNombre2.Text = DateTime.Now.ToString("HH:mm:ss");
	}
}