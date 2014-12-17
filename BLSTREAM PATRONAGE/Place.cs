using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLSTREAM_PATRONAGE
{
    interface INotifyPropertyChanged
    {
        string Name { get; set; }
        string Address { get; set; }
        double Lattitude { get; set; }
        double Longitude { get; set; }
        bool HasWifi { get; set; }

    }
    class Place : INotifyPropertyChanged
    {
        private string _Name;
        private string _Address;
        private double _Lattitude;
        private double _Longitude;
        private bool _HasWifi;

       /* public Place(string Name, string Address, double Lattitude, double Longitude, bool HasWifi)
        {
            _Name = Name;
            _Address = Address;
            _Lattitude = Lattitude;
            _Longitude = Longitude;
            _HasWifi = HasWifi;
        }*/

        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }
        public string Address
        {
            get
            {
                return _Address;
            }
            set
            {
                _Address = value;
            }
        }
        public double Lattitude
        {
            get
            {
                return _Lattitude;
            }
            set
            {
                _Lattitude = value;
            }
        }
        public double Longitude
        {
            get
            {
                return _Longitude;
            }
            set
            {
                _Longitude = value;
            }
        }
        public bool HasWifi
        {
            get
            {
                return _HasWifi;
            }
            set
            {
                _HasWifi = value;
            }
        }


        public override string ToString()
        {
            return (System.String.Format("{0} + {1}",Name,Address));
        }
    }
}
