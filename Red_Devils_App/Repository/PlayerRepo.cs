using Red_Devils_App.Entities;
using Red_Devils_App.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Red_Devils_App.Repository
{
    public interface IPlayerRepo
    {
        List<Player> GetPlayers();
        Task UpdatePlayer(Player player);
    }
    public class PlayerDbRepo : IPlayerRepository
    {
        private readonly SQLiteAsyncConnection connection;
        private bool initComplete = false;
        public PlayerDbRepo(SQLiteAsyncConnection connection) 
        {
            this.connection = connection;
        }
        private async Task Init()
        {
            if (!initComplete)
            {
                await connection.CreateTableAsync<Player>();
                initComplete = true;
            }
        }
        public async Task<List<Player>> GetAllPlayerAsync()
        {
            await Init();
            return await connection.Table<Player>().ToListAsync();
        }
        public async Task<Player> GetPlayerAsync(int id)
        {
            await Init();
            return await connection.GetAsync<Player>(id);
        }

        public async Task<int> SavePlayerAsync(Player player)
        {
            await Init();
            if (player.Id != 0)
            {
                return await connection.UpdateAsync(player);                
            }
            else
            {
                return await connection.InsertAsync(player);
            }
        }
        public async Task<int> DeletePlayerAsync(int id)
        {
            await Init();
            return await connection.DeleteAsync(id);
        }
        public async Task<int> AddPlayerAsync(Player player)
        {
            await Init();
            return await connection.InsertAsync(player);
        }
        public async Task<int> UpdatePlayerAsync(Player player)
        {
            await Init();
            return await connection.UpdateAsync(player);
        }
    }
        //public List<Player> GetPlayers()
        //{
        //    var data = connection.Table<PlayerData>().ToList();
        //    var result = new List<Player>();

        //    foreach (var item in data)
        //    {
        //        var player = new Player()
        //        {
        //            Id = item.Id,
        //            Name = item.Name,
        //            Number = item.Number,
        //            BirthDate = item.BirthDate,
        //        };
        //        result.Add(player);
        //    }
        //    return result;
        //}
    public class PlayerFakeRepo : IPlayerRepository
    {
        public async Task UpdatePlayer(Player player)
        {
            await Task.Delay(1);
        }
        public PlayerFakeRepo()
        {
            //context.connectionString = connectionString
        }
        public async Task<List<Player>> GetAllPlayerAsync()
        {
            await Task.Delay(1);
            var players = new List<Player>
            {
            new Player
            {
                Id = 5257,
                Name = "Toby Alderweireld",
                Number = 2,
                BirthDate = new DateTime(1989,3,2)
            },
            new Player
            {
                Id = 5581,
                Name = "Yannick Carrasco",
                Number = 11,
                BirthDate = new DateTime(1993,9,4)
            },
            new Player
            {
                Id = 5771,
                Name = "Thibaut Courtois",
                Number = 1,
                BirthDate = new DateTime(1992,5,11)
            },
            new Player
            {
                Id = 5590,
                Name = "Romelu Lukaku",
                Number = 9,
                BirthDate = new DateTime(1993,5,13)
            },
            new Player
            {
                Id = 5110,
                Name = "Jan Vertonghen",
                Number = 5,
                BirthDate = new DateTime(1987,4,24)
            },
            new Player
            {
                Id = 5733,
                Name = "Kevin De Bruyne",
                Number = 7,
                BirthDate = new DateTime(1991,6,28)
            },
            new Player
            {
                Id = 6135,
                Name = "Youri Tielemans",
                Number = 8,
                BirthDate= new DateTime(1997,5,7)
            }
        };
            return players;
        }

        public Task<int> AddPlayerAsync(Player player)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeletePlayerAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Player> GetPlayerAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdatePlayerAsync(Player player)
        {
            throw new NotImplementedException();
        }

        public Task<int> SavePlayerAsync(Player player)
        {
            throw new NotImplementedException();
        }
    }
    public class PlayerAPIRepo : IPlayerRepository
    {
        
        public PlayerAPIRepo(HttpClient client)
        {
            //context.connectionString = connectionString
        }

        public Task<int> AddPlayerAsync(Player player)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeletePlayerAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Player>> GetAllPlayerAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Player> GetPlayerAsync(int id)
        {
            throw new NotImplementedException();
        }

        public List<Player> GetPlayers()
        {
            //TODO get players from database
            var players = new List<Player>
            {
            new Player
            {
                Id = 5257,
                Name = "Toby Alderweireld",
                Number = 2,
                BirthDate = new DateTime(1989,3,2)
            },
            new Player
            {
                Id = 5581,
                Name = "Yannick Carrasco",
                Number = 11,
                BirthDate = new DateTime(1993,9,4)
            },
            new Player
            {
                Id = 5771,
                Name = "Thibaut Courtois",
                Number = 1,
                BirthDate = new DateTime(1992,5,11)
            },
            new Player
            {
                Id = 5590,
                Name = "Romelu Lukaku",
                Number = 9,
                BirthDate = new DateTime(1993,5,13)
            },
            new Player
            {
                Id = 5110,
                Name = "Jan Vertonghen",
                Number = 5,
                BirthDate = new DateTime(1987,4,24)
            },
            new Player
            {
                Id = 5733,
                Name = "Kevin De Bruyne",
                Number = 7,
                BirthDate = new DateTime(1991,6,28)
            },
            new Player
            {
                Id = 6135,
                Name = "Youri Tielemans",
                Number = 8,
                BirthDate= new DateTime(1997,5,7)
            }
        };
            return players;
        }

        public Task<int> SavePlayerAsync(Player player)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdatePlayerAsync(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
