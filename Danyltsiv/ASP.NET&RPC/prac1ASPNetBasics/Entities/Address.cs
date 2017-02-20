using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prac1ASPNetBasics.Entities
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string  Street { get; set; }
        public int BuildingNumber { get; set; }

        public Address() { }

        public Address(int id, string country, string city, string street, int buildnum)
        {
            AddressId = id;
            Country = country;
            City = city;
            Street = street;
            BuildingNumber = buildnum;
        }

        public override string ToString()
        {
            return String.Format("Address: {0}, {1} city, {2} street, building:{3}",Country,City,Street,BuildingNumber);
        }
    }
}