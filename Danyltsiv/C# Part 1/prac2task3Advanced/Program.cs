using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace prac2task3
{
    class Program
    {
        static private void PrintArr<T>(List<T> arr)
        {
            for (int i = 0; i < arr.Count; i++)           
                Console.WriteLine(arr[i]);
        }

        static void Main(string[] args)
        {
            string currDir = Directory.GetCurrentDirectory() + "\\plates.txt";
            List<string> lines = new List<string>(System.IO.File.ReadAllLines(currDir));

            StatichniyZvit zvit = new StatichniyZvit(lines);

            zvit.PeretnuliKordonDekilkaRaz();
            //PrintArr(zvit.AvtoZOdnogoRegionu("IB"));
            //zvit.Statistic();
            Console.ReadKey();
        }

        public class StatichniyZvit
        {
            public List<string> plates;

            public StatichniyZvit(List<string> lines)
            {
                this.plates = lines;
            }
            public List<string> AvtoZOdnogoRegionu(string kod)
            {
                List<string> spisok = new List<string>();
                for (int i = 0; i < this.plates.Count; i++)
                    if (this.plates[i].IndexOf(kod) == 0)
                        spisok.Add(this.plates[i]);

                return spisok;
            }

            public void PeretnuliKordonDekilkaRaz()
            {
                int k = 1;
                Dictionary<string,int> spisok = new Dictionary<string,int>();
                for (int i = 0; i < this.plates.Count; i++)
                {
                    
                        if (spisok.ContainsKey(this.plates[i])) continue;
                    for (int j = 0; j < this.plates.Count; j++)
                    {
                        if (i == j) continue;
                        if (this.plates[i] == this.plates[j])
                            k++;
                               
                    }
                    if (k > 1) spisok.Add(this.plates[i], k);
                    k = 1;
                }

                foreach(KeyValuePair<string,int> pair in spisok)
                {
                    Console.WriteLine("Nomerniy znak: {0}, kilkist peretyniv: {1}", pair.Key, pair.Value);
                }
            }

            public void Statistic()
            {
                IDictionary<string, int> temp = new Dictionary<string, int>();
                IDictionary<string, int> stat = new Dictionary<string, int>();
                string kod = "";

                for (int i = 0; i < this.plates.Count; i++)
                {
                    kod = this.plates[i].Substring(0, 2);
                    if (temp.ContainsKey(kod)) continue;
                    else temp.Add(kod, UnikalniPeretini(kod));
                }

                foreach (KeyValuePair<string, int> pair in temp.OrderBy(key => key.Value))
                {
                    stat.Add(pair.Key, pair.Value);
                }

                foreach (KeyValuePair<string, int> pair in stat.Reverse()) 
                {
                    Console.WriteLine("Region: {0}, Peretnulo avtomobiliv: {1}", pair.Key, pair.Value);
                }
            }

            private int UnikalniPeretini(string kod)
            {
                List<string> IB = AvtoZOdnogoRegionu(kod);
                List<string> unique = new List<string>();
                for (int i = 0; i < IB.Count; i++)
                {
                    if (unique.Contains(IB[i])) continue;
                    else unique.Add(IB[i]);
                }

                return unique.Count;
            }

        }
    }
}
