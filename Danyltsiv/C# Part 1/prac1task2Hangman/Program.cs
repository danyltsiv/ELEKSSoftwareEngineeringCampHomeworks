using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac1task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "andriy", "vova", "vasia", "dmytro", "kristina", "pavlo", "orest" };
            Random rnd = new Random();
            int nomer = rnd.Next(words.Length);
            string zagadane = words[nomer];
            string prihovane = "";
            int sprob = 0;
            
            for (int i = 0; i < zagadane.Length; i++)
            {
                prihovane += "*";
            }

            Console.WriteLine("Dobrogo dnia! Vidgataite Slovo! U vas 10 sprob!");
            while (prihovane.Contains("*") && sprob<10)
            {
                Console.WriteLine("\nSlovo:\n" + prihovane + "\nVvedit bukvu:");
                string line = Console.ReadLine();
                char bukva = line[0];
                for (int i = 0; i < zagadane.Length; i++)
                {
                    if (zagadane[i] == bukva)
                        prihovane = prihovane.Remove(i, 1).Insert(i, bukva.ToString());
                }
                sprob++;
            }

            if (prihovane == zagadane)
            {
                Console.WriteLine("\nVitayemo z peremogoyu!\nVy vidgadali slovo: "+zagadane);
                Console.WriteLine("Kilkist sprob: " + sprob);
            } else
            {
                Console.WriteLine("\nSproby vycherpano, vi prograly!\nSprobuyte she raz!");
            }
            
            Console.ReadKey();
        }
    }
}
