using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneDirectory
{
    public static class DictionaryFunctions
    {
        static private Dictionary dictionary = Dictionary.GetDictionary();

        static public void AddRecord(Record record)
        {
                dictionary.AddRecord(record);           
        }

        static public void RemoveByNumber(string Number)
        {
            dictionary.RemoveByNumber(Number);
        }

        static public List<Record> GetAllRecords()
        {
            List<Record> temp = new List<Record>();
            temp = dictionary.GetAllRecords();
            try
            {
                if (temp == null)
                {
                    throw new Exception("List is empty!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return temp;
        }
        
        static public List<Record> SearchNumbersByName(string forename, string surname)
        {
            List<Record> temp = new List<Record>();
            try {                
                foreach (Record rec in dictionary.GetAllRecords())
                    if (rec._Surname == surname && rec._Forename == forename)
                        temp.Add(rec);
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return temp;
        }
    }
}
