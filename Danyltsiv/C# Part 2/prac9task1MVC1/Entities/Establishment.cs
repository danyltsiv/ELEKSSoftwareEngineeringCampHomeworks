using System;

namespace prac9task1MVC1.Entities
{
    public class Establishment : ICloneable
    {
        static int ID = 0;
        public int establishmentId { get; set; } 
        public string Name { get; set; }
        public string Address { get; set; }
        public bool Opened { get; set; }
        private int _rating { get; set; }
        public int Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                if (value > 3)
                {
                    _rating = 3;
                }
                else if (value < 1)
                {
                    _rating = 1;
                }
                else _rating = value;
            }
        }

        public Establishment()
        {
            establishmentId = ID++;
        }

        public Establishment(string name) : base()
        {
            Name = name;
        }
        public Establishment(string name, string address, bool opened, int rating) : base()
        {
            Name = name;
            Address = address;
            Opened = opened;
            Rating = rating;
        }

        public object Clone()
        {
            return new Establishment(Name)
            {
                establishmentId = establishmentId,
                Address = Address,
                Rating = Rating,
                Opened = Opened
            };
        }
        public void Open()
        {
            Opened = true;
        }
        public void Close()
        {
            Opened = false;
        }
        public void Toggle()
        {
            if(Opened)
            {
                Close();
            }
            else
            {
                Open();
            }
        }
    }
}
