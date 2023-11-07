using Red_Devils_App.Vieuws;

namespace Red_Devils_App;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
	}
}
