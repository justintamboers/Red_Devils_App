using Red_Devils_App.VieuwModels;

namespace Red_Devils_App.Vieuws;

public partial class LoginPage : ContentPage
{
    public LoginPage(LoginViewModel vm)
    {
        InitializeComponent();
        this.BindingContext = vm;
    }
  //  private async void LoginButton_Clicked(object sender, EventArgs e)
  //  {
		//await Shell.Current.GoToAsync("//MainPage");
  //  }
}