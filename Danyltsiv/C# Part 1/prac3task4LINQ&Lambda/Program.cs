using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace prac3task4
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

            //zvit.PeretnuliKordonDekilkaRaz();
            //PrintArr(zvit.AvtoZOdnogoRegionu("IB"));
            zvit.Statistic();
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
                IEnumerable<string> spisok = from elem in this.plates
                                             where elem.IndexOf(kod) == 0
                                             select elem;

                return spisok.ToList<string>();
            }

            public void PeretnuliKordonDekilkaRaz()
            {
                var grouped = this.plates.GroupBy(g => g).Select(
                    g => new {nomer = g.Key, kilkist = g.Count()}
                    ).Where(g=>g.kilkist>1).ToDictionary(g=>g.nomer,g=>g.kilkist);
            
                foreach (KeyValuePair<string,int> pair in grouped)
                    Console.WriteLine("Nomerniy znak: {0}, Kilkist peretiniv: {1}", pair.Key, pair.Value);
                 }

            public void Statistic()
            {
                var sorted = this.plates.Distinct().GroupBy(g => g.Substring(0, 2)).Select(
                    g => new {index = g.Key, kilkist = g.Count()}
                    ).OrderBy(g=>g.kilkist).ToDictionary(g=>g.index,g=>g.kilkist).Reverse();

                foreach (var pair in sorted)
                {
                    Console.WriteLine("Region: {0}, Peretnulo avtomobiliv:{1} ", pair.Key,pair.Value);
                }

            }
        }
    }
}
