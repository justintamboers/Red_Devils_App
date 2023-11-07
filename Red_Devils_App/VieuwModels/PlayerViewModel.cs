using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Red_Devils_App.Models;
using Red_Devils_App.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Red_Devils_App.VieuwModels
{
    [QueryProperty(nameof(SelectedPlayer), "SelectedPlayer")]
    public partial class PlayerViewModel : ObservableObject
    {
        [ObservableProperty]
        private Player selectedPlayer;

        [ObservableProperty]
        private List<int> numbers;

        private IPlayerRepo playerRepo;

        public PlayerViewModel(IPlayerRepo repo)
        {
            this.playerRepo = repo;

            numbers = GetNumbers();
        }

        private List<int> GetNumbers()
        {
            var list = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                list.Add(i);
            }
            return list;
        }

        [RelayCommand]
        public async Task OnUpdate()
        {
            await playerRepo.UpdatePlayer(SelectedPlayer);
        }
    }
}
