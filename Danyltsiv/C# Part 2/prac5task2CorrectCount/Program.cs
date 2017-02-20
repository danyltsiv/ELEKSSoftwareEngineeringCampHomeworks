using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace prac5task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int words = 0;
            var count = RowCounts("Song.txt", ref words);
            Console.WriteLine("File have {0} lines and {1} words.",count,words);
            Console.ReadLine();
        }

        static int CorrectlyWordCount(string line)
        {
            List<string> words = new List<string>();
            List<char> SingleWord = new List<char>();
            for (int i = 0; i < line.Length; i++)
                if (line[i] != ',' && line[i] != ' ' && line[i] != '!' && line[i] != '.')
                    SingleWord.Add(line[i]);
                else
                {
                    if (SingleWord.Count != 0) { words.Add(SingleWord.ToString()); SingleWord.Clear(); }
                    continue;
                }
            if (SingleWord.Count != 0) words.Add(SingleWord.ToString());
                return words.Count;
        }

        static int RowCounts(string file, ref int words)
        {

            var lns = File.ReadAllLines(file);

            for (int i = 0; i < lns.Length; i++)
            {
                words += CorrectlyWordCount(lns[i]);
            }

            return lns.Length;
        }
    }
}