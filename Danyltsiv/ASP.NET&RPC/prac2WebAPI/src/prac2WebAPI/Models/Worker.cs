using System;
using prac2WebAPI.Storage;
using System.Collections.Generic;
using System.Linq;

namespace prac2WebAPI.Models
{
    public class Worker
    {
        public int WorkerId { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public int AddressId { get; set; }
        public string PhoneNumber { get; set; }
        public string Position { get; set; }
        public int UnitId { get; set; }
        public string Head { get; set; }

        public Worker() { }

        public Worker(int id, string surname, string name, int addressId, string phone,
            string position, int unitId, string head)
        {
            WorkerId = id;
            Surname = surname;
            Name = name;
            AddressId = addressId;
            PhoneNumber = phone;
            Position = position;
            UnitId = unitId;
            Head = head;
        }

        public override string ToString()
        {
            Unit unit = CompanyWorkers.Units.FirstOrDefault(p => p.UnitId == this.UnitId);

            Address address = CompanyWorkers.Addresses.FirstOrDefault(p => p.AddressId == this.UnitId);            

            return String.Format("Surname: {0}, Name: {1}, Address: {2}, Number: {3}, Position: {4}, Head: {5}, Unit: {6}"
                , Surname, Name, address.ToString(), Position, Head, unit.Description);
        }
    }
}