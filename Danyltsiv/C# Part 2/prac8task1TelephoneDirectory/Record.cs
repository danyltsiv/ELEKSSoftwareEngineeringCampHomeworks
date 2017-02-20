using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneDirectory
{
    public class Record
    {
        public string _Surname;
        public string _Forename;
        public string _Number;
        public string _Address;

        public Record(string Forename, string Surname,string Number, string Address)
        {
            this._Forename = Forename;
            this._Surname = Surname;
            this._Number = Number;
            this._Address = Address;
        }

        public override string ToString()
        {
            return string.Concat(this._Forename," ",this._Surname, " ", this._Number, " ", this._Address);
        }
    }
}
