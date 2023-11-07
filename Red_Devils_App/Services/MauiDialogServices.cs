using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Red_Devils_App.Services
{
    class MauiDialogServices : IDialogService
    {
        public async Task ShowTaost(string message, int fontSize)
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

            ToastDuration duration = ToastDuration.Short;

            var toast = Toast.Make(message, duration, fontSize);

             await toast.Show(cancellationTokenSource.Token);
        }
    }
}
