using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneDirectory
{
    class Dictionary
    {
        public List<Record> dictionary = new List<Record>();
        public static int id = 0;

        private Dictionary()
        {

        }

        public static Dictionary GetDictionary()
        {
            id++;
            if (id > 1) return null;
            else return new Dictionary();
        }

        public void AddRecord(Record record)
        {
            foreach(Record rec in this.dictionary)
            {
                if (rec._Number == record._Number)
                    throw new Exception("Record with this number is already exist");
            }
            this.dictionary.Add(record);
        }

        public void RemoveByNumber(string Number)
        {
            for(int i = 0;i<this.dictionary.Count; i++)
            {
                if (this.dictionary[i]._Number == Number)
                    this.dictionary.Remove(this.dictionary[i]);
            }
        }

        public List<Record> GetAllRecords()
        {
            return this.dictionary;
        } 
      }
    }

