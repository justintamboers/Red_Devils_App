using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Red_Devils_App.Models
{
    public partial class Player : ObservableObject
    {
        private const string IMG_URL = "https://belgianfootball.s3.eu-central-1.amazonaws.com/s3fs-public/rbfa/img/players/internationals/football/men/";

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(ImageUrl))]
        private int id;

        [ObservableProperty]
        private string name;

        [ObservableProperty]
        private int number;

        [ObservableProperty]
        private DateTime birthDate;

        public string ImageUrl
        {
            get
            {
                if (id == 0 || id == null)
                {
                    return null;
                }
                else
                {
                    return IMG_URL + id + ".jpg";
                }
            }

        }
        //    public int Id { get => id;
        //        set
        //        {
        //            id = value;
        //            RaisePropertyChanged(nameof(id));
        //        }
        //    }
        //    public string Name
        //    {
        //        get => name; set
        //        {
        //            name = value;
        //            RaisePropertyChanged(nameof(Name));
        //        }
        //    }
        //    public int Number
        //    {
        //        get => number;
        //        set
        //        {
        //            number = value;
        //            RaisePropertyChanged(nameof(Number));
        //        }
        //    }
        //    public DateTime BirthDate
        //    {
        //        get => birthDate;
        //        set
        //        {
        //            birthDate = value;
        //            RaisePropertyChanged(nameof(BirthDate));
        //        }
        //    }

        //    public event PropertyChangedEventHandler PropertyChanged;

        //    private void RaisePropertyChanged(string propertyName)
        //    {
        //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //    }
        //}
    }
}
