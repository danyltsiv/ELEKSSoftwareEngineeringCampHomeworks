using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneDirectory
{
    static public class ConsolePresent
    {
        static public void AddRecord(Record record)
        {
            DictionaryFunctions.AddRecord(record);
        }

        static public void RemoveByNumber(string Number)
        {
            DictionaryFunctions.RemoveByNumber(Number);
        }

        static public void ShowAllRecords()
        {
            foreach (Record rec in DictionaryFunctions.GetAllRecords())
                Console.WriteLine(rec);
        }

        static public void ShowNumbersByName(string forename, string surname)
        {
            List<Record> temp = new List<Record>();
            temp = DictionaryFunctions.SearchNumbersByName(forename, surname);
            foreach (Record rec in temp)
                Console.WriteLine(rec);
        }
    }
}
