using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Diagnostics;
namespace BLSTREAM_PATRONAGE
{
    /*
        public interface INotifyPropertyChanged
    {
        string Name { get; set; }
        string Address { get; set; }
        double Lattitude { get; set; }
        double Longitude { get; set; }
        bool HasWifi { get; set; }

    }
     */
    class Place : INotifyPropertyChanged
    {
        private string _Name;
        private string _Address;
        private double _Lattitude;
        private double _Longitude;
        private bool _HasWifi;

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

       public  Place()
        {
            _Name = "Jan";
            _Address = "Wesoły";
            _Lattitude = 122;
            _Longitude = 123;
            _HasWifi = false;
        }


        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                if (value != this._Name)
                {
                    this._Name = value;
                    NotifyPropertyChanged("Name");
                }
            }
        }
        public string Address
        {
            get
            {
                return this._Address;
            }
            set
            {
                if (value != this._Address)
                {
                    this._Address = value;
                    NotifyPropertyChanged("Address");
                }
            }
        }
        public double Lattitude
        {
            get
            {
                return this._Lattitude;
            }
            set
            {
                if (value != this._Lattitude)
                {
                    this._Lattitude = value;
                    NotifyPropertyChanged("Lattitude");
                }
            }
        }
        public double Longitude
        {
            get
            {
                return this._Longitude;
            }
            set
            {
                if (value != this._Longitude)
                {
                    this._Longitude = value;
                    NotifyPropertyChanged("Longitude");
                }
            }
        }
        public bool HasWifi
        {
            get
            {
                return this._HasWifi;
            }
            set
            {
                if (value != this._HasWifi)
                {
                    this._HasWifi = value;
                    NotifyPropertyChanged("HasWifi");
                }
            }
        }


        public override string ToString()
        {
            return (System.String.Format("{{0}},{{1}}",Name,Address));
        }
        

    }
}
