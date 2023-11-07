using Red_Devils_App.Vieuws;

namespace Red_Devils_App.Vieuws;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {

        await Shell.Current.GoToAsync("//TeamPage");
    }
}

