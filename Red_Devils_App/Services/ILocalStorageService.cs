using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Red_Devils_App.Services
{
    public interface ILocalStorageService
    {
        void SetPreferences(string key, dynamic value);
        string GetPreferences(string key, dynamic defaultValue);
    }
}
