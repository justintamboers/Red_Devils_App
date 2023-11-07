using Red_Devils_App.Models;
using Red_Devils_App.Repository;
using Red_Devils_App.VieuwModels;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Red_Devils_App.Vieuws;

public partial class TeamPage : ContentPage
{
    public TeamPage(TeamViewModel vm)
    {
        InitializeComponent();
        this.BindingContext = vm;
    }
}