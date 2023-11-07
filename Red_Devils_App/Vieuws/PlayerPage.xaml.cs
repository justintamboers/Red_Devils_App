using System;
using System.Collections.Generic;
using Microsoft.Maui.Controls;
using Red_Devils_App.Models;
using Red_Devils_App.VieuwModels;

namespace Red_Devils_App.Vieuws
{
    public partial class PlayerPage : ContentPage
    {        public PlayerPage(PlayerViewModel vm)
        {
            InitializeComponent();
            this.BindingContext = vm;
        }
    }
}
