using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MafiaClassLibrary.Entities
{
    public class Player
    {
        public int id { get; set; }
        public string nickname { get; set; }
        public string status { get; set; }
        public string role { get; set; }
        public string screen { get; set; }
        public List<string> messages = new List<string>();
        public int votes { get; set; }
        public bool rightToVote { get; set; }
        public bool bullet { get; set; }

        public Player() { }

        public override string ToString()
        {
            return String.Format("{0}({1})",nickname,status);
        }
    }
}
