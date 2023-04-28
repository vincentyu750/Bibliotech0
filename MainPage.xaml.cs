using Bibliotech0.Database;

namespace Bibliotech0;

public partial class MainPage : ContentPage
{
    private Repository repository;
    public MainPage()
	{
		repository = new Repository();
		InitializeComponent();
	}

}
