namespace desenho;

public partial class AppFlyoutPage : FlyoutPage
{
	public AppFlyoutPage()
	{
		InitializeComponent();
        //Define que a página inicial aberta dentro do Detail é a Mainpage (Home
        Detail = new NavigationPage(new MainPage());
    }
}