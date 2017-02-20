using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prac1ASPNetBasics.Entities
{
    public class Unit
    {
        public int UnitId { get; set; }
        public string Description { get; set; }

        public Unit() { }

        public Unit(int id, string description)
        {
            UnitId = id;
            Description = description;
        }
    }
}