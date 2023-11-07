using Red_Devils_App.Models;
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
    public class PlayerDBRepo : IPlayerRepo
    {
        public async Task UpdatePlayer(Player player)
        {
            await Task.Delay(1);
        }
        public PlayerDBRepo(string connectionString)
        {
            //context.connectionString = connectionString
        }
        public List<Player> GetPlayers()
        {
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
    }
    public class PlayerFakeRepo : IPlayerRepo
    {
        public async Task UpdatePlayer(Player player)
        {
            await Task.Delay(1);
        }
        public PlayerFakeRepo()
        {
            //context.connectionString = connectionString
        }
        public List<Player> GetPlayers()
        {
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
    }
    public class PlayerAPIRepo : IPlayerRepo
    {
        public async Task UpdatePlayer(Player player)
        {
            await Task.Delay(1);
        }
        public PlayerAPIRepo(HttpClient client)
        {
            //context.connectionString = connectionString
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
    }
}
