using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac6task1
{
    public class Restaurant : IPublicEstablishment
    {
        static int ID = 0;
        public int _RestaurantID { get; private set; }
        public string _Name { get; set; }
        public string _Address { get; set; }
        public bool _isOpened { get; set; }
        public int _Rating { get; }

        public Restaurant(string Name, string Address, bool isOpen,int Rating)
        {
            this._RestaurantID = ID++;
            this._Name = Name;
            this._Address = Address;
            this._isOpened = isOpen;
            if (Rating > 3)
                this._Rating = 3;
            else if (Rating < 1) this._Rating = 1;
            else this._Rating = Rating;
        }

        public override string ToString()
        {
            return String.Format("RESTAURANT {0} : {1}, {2}, isOpened: {3}, Rating: {4}",
                this._RestaurantID, this._Name, this._Address, this._isOpened, this._Rating);
        }

        public void Open()
        {
            this._isOpened = true;
        }

        public void Close()
        {
            this._isOpened = false;
        }

        public void Toggle()
        {
            if (this._isOpened) Close();
            else Open();
        }
    }
}
