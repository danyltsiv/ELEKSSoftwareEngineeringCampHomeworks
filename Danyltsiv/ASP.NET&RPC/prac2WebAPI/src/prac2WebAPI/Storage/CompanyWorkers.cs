using System;
using System.Collections.Generic;
using System.Linq;
using prac2WebAPI.Models;

namespace prac2WebAPI.Storage
{
    static public class CompanyWorkers
    {
        static public List<Worker> Workers = new List<Worker>
        {
            new Worker(0,"Worker1","Worker1", 0,"020","pos1",0,"Head1"),
            new Worker(1,"Worker2","Worker2", 1,"040","pos2",1,"Head1"),
            new Worker(2,"Worker3","Worker3", 1,"060","pos3",2,"Head2")
        };

        static public List<Unit> Units = new List<Unit>
        {
            new Unit(0,"UNIT1"),
            new Unit(1,"UNIT2"),
            new Unit(2,"UNIT3")
        };

        static public List<Address> Addresses = new List<Address>
        {
            new Address(0,"Country1","City1","Street1",2),
            new Address(1,"Country2","City2","Street2",4)
        };
    }
}