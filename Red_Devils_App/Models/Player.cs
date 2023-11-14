using CommunityToolkit.Mvvm.ComponentModel;
using SQLite;
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
        private const string IMAGE_URL = "https://belgianfootball.s3.eu-central-1.amazonaws.com/s3fs-public/rbfa/img/players/internationals/football/men/";

        private int id;
        [PrimaryKey]
        [AutoIncrement]
        public int Id
        {
            get { return id; }
            set { SetProperty(ref id, value); }
         }

        private int externalId;
        [Unique]
        public int ExternalID
        {
            get { return externalId; }
            set
            {
                if (SetProperty(ref externalId, value))
                {
                    OnPropertyChanged(nameof(ImageUrl));
                } }
        }
        [Ignore]
        public string ImageUrl
        {
            get
            {
                if (ExternalID == 0 || ExternalID == null)
                {
                    return null;
                }
                else
                {
                    return IMAGE_URL + ExternalID + ".jpg";
                }
            }

        }

        private string name;
        [MaxLength(100)]
        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value); }
        }

        private int number;
        [Unique]
        public int Number
        {
            get { return number; }
            set { SetProperty(ref number, value); }
        }

        private DateTime birthDate;
        public DateTime BirthDate
        {
            get { return birthDate; }
            set { SetProperty(ref birthDate, value); }
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
