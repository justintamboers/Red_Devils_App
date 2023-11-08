using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Red_Devils_App.Services
{
    public class MauiDialogServices : IDialogService
    {
        public Task ShowToast(string message, int fontSize = 16)
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

            ToastDuration duration = ToastDuration.Short;

            var toast = Toast.Make(message, duration, fontSize);

             return toast.Show(cancellationTokenSource.Token);
        }
    }
}
