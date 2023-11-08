using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Red_Devils_App.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Red_Devils_App.VieuwModels
{
    public partial class LoginViewModel : ObservableObject
    {
        private readonly INavigationService navigation;
        private readonly IDialogService dialog;
        private readonly ILocalStorageService storage;
        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(LoginCommand))]
        private string userName = string.Empty;
        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(LoginCommand))]
        private string password = string.Empty;
        [ObservableProperty]
        private bool rememberLogin;

        public LoginViewModel(INavigationService navigation, IDialogService dialog, ILocalStorageService storage)
        {
            this.navigation = navigation;
            this.dialog = dialog;
            this.storage = storage;

            storage.SetPreferences("RememberLogin", false);
            if (RememberLogin)
            {
                UserName = storage.GetPreferences("UserName", string.Empty);
                Password =  storage.GetPreferences("Password", string.Empty);
            }
        }
        [RelayCommand(CanExecute = nameof(LoginCanExecute))]
        private async Task OnLogin()
        {
            if (UserName.Equals("j") && Password.Equals("j"))
            {
                storage.SetPreferences("RememberLogin", RememberLogin);
                if (RememberLogin)
                {
                    storage.SetPreferences("UserName", UserName);
                    storage.SetPreferences("Password", Password);

                }
                    await navigation.NavigateToAsync("//MainPage");
            }
            else
            {
                await dialog.ShowToast("Wrong username or password");
            }
        }

        private bool LoginCanExecute()
        {
            if (UserName.Length > 0 && Password.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
