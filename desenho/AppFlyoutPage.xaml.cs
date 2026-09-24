namespace desenho;

public partial class AppFlyoutPage : FlyoutPage
{
	public AppFlyoutPage()
	{
		InitializeComponent();
        //Define que a página inicial aberta dentro do Detail é a Mainpage (Home)
        Detail = new NavigationPage(new MainPage());
    }

    

    

    private void chavesClicked(object sender, EventArgs e)
    {
        Detail = new NavigationPage(new AppChaves());
        IsPresented = false;
    }

    private void kikoClicked(object sender, EventArgs e)
    {
        Detail = new NavigationPage(new AppKiko());
        IsPresented = false;
    }

    private void chiquinhaClicked(object sender, EventArgs e)
    {
        Detail = new NavigationPage(new AppChiquinha());
        IsPresented = false;
    }

    private void nhonhoClicked(object sender, EventArgs e)
    {
        Detail = new NavigationPage(new AppNhonho());
        IsPresented = false;
    }
}