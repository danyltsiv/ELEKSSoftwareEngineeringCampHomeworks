using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneDirectory
{
    class Program
    {
        static void Main(string[] args)
        {            
            Record record1 = new Record("andriy", "danyltsiv", "0923342342", "vovchynecka");
            Record record2 = new Record("volodia", "danyltsiv", "0923342242", "vovchynecka");
            Record record3 = new Record("vasia", "bedriy", "092334244", "gnatyuka");
         
            ConsolePresent.AddRecord(record1);
            ConsolePresent.AddRecord(record2);
            ConsolePresent.AddRecord(record3);
            ConsolePresent.ShowAllRecords();
            
            Console.Read(); 
        }
    }
}
