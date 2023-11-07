using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Red_Devils_App.Services
{
    public interface IDialogService
    {
        Task ShowTaost(string message, int fontSize);

    }
}
