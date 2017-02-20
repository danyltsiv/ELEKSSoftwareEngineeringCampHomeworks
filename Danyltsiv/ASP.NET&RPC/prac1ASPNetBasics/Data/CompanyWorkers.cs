using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using prac1ASPNetBasics.Entities;

namespace prac1ASPNetBasics.Data
{
    static public class CompanyWorkers
    {
        static public List<Worker> Workers = new List<Worker>
        {
            new Worker(0,"Worker1","Worker1", 0,"020","pos1",0,"Head1")
        };

        static public List<Unit> Units = new List<Unit>
        {
            new Unit(0,"UNIT")
        };

        static public List<Address> Addresses = new List<Address>
        {
            new Address(0,"Country1","City1","Street1",2)
        };
    }
}