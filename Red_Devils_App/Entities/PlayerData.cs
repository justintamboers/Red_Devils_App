using CommunityToolkit.Mvvm.ComponentModel;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Red_Devils_App.Entities
{
    public class PlayerData
    {
        [PrimaryKey]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [Unique]
        public int Number { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
