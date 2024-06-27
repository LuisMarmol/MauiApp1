namespace MauiApp1
{
    /// <summary>
    /// Así también se puede poner un comentario en el código, escribiendo tres veces el "///"
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            #region 2024/06/21 Así se pone un comentario para poder colapsar una parte del código
            //MainPage = new LoginPage(); MainPage(); AppShell();
            #endregion
            //MainPage = new LoginPage();
            MainPage = new NavigationPage(new ContentPageDemo());
        }
    }
}
