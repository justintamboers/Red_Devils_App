using Red_Devils_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Red_Devils_App.Repository
{
    public interface IPlayerRepository
    {
        Task<int> AddPlayerAsync(Player player);
        Task<int> DeletePlayerAsync(int id);
        Task<int> SavePlayerAsync(Player player);
        Task<int> UpdatePlayerAsync(Player player);
        Task<Player> GetPlayerAsync(int id);
        Task<List<Player>> GetAllPlayerAsync();
    }
}
