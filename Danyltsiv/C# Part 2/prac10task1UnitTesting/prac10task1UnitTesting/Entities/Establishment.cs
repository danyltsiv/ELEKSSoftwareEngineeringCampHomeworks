using System;

namespace prac9task1MVC1.Entities
{
    class EstablishmentException : Exception
    {
        public EstablishmentException()
        {

        }
        public EstablishmentException(string message)
            : base(message)
        {

        }
    }

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
                if (value > 3 || value < 1)
                {
                    throw new EstablishmentException("Rating is not correct!");
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
