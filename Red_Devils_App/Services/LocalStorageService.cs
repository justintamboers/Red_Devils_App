using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Red_Devils_App.Services
{
    public class LocalStorageService : ILocalStorageService
    {
        void ILocalStorageService.SetPreferences(string key, dynamic value)
        {
            Preferences.Set(key, value);
        }

        string ILocalStorageService.GetPreferences(string key, dynamic defaultValue)
        {
            return Preferences.Get(key, defaultValue);
        }
    }
}
