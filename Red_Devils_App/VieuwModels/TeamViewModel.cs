﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Red_Devils_App.Models;
using Red_Devils_App.Repository;
using Red_Devils_App.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Red_Devils_App.VieuwModels
{
    public partial class TeamViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<Player> players;
        private readonly IPlayerRepository repo;
        private readonly INavigationService navigation;
        private readonly IDialogService dialog;


        public TeamViewModel(IPlayerRepository repo, INavigationService navigation)
        {
            this.repo = repo;
            this.navigation = navigation;           
        }

        [RelayCommand]
        private async Task OnLoadView()
        {
            players = new ObservableCollection<Player>(await repo.GetAllPlayerAsync());
        }

        [RelayCommand]
        private async Task OnDeletePlayer(Player player)
        {
            //TODO: delete from repository
            await repo.DeletePlayerAsync(player.Id);
            players.Remove(player);
        }

        [RelayCommand]
        private async Task OnAddPlayer()
        {
            //TODO: await NavigateToPlayer(player);
            Player player = new Player();

            await navigation.NavigateToAsync("PlayerPage", new Dictionary<string, object>
            {
                {"SelectedPlayer", player }
            });

            players.Add(player);
        }

        [RelayCommand]
        private async Task OnEditPlayer(Player player)
        {
            //TODO: await NavigateToPlayer(player);
            await navigation.NavigateToAsync("PlayerPage", new Dictionary<string, object>
            {
                {"SelectedPlayer", player }
            });
        }
        [RelayCommand]
        private async Task OnSelectPlayer(Player player)
        {
            players.Add(player);

        }
    }
}
