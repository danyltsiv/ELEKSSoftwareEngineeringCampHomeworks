using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace prac7task1
{
    static class Calculator
    {
        static public Timer Timer = new Timer(1000);

        static public List<Restaurant> getTopRestaurants()
        {
            var sorted = EstablishmentsData.getRestaurants().OrderBy(g => g._Rating).Reverse().ToList();
            var temp = sorted.GetRange(0, 5);
            return temp;
        }

        static public List<Bar> getTopBars()
        {
            var sorted = EstablishmentsData.getBars().OrderBy(g => g._Rating).Reverse().ToList();
            var temp = sorted.GetRange(0, 5);
            return temp;
        }

        static public void showTopRestaurants()
        {
            Console.WriteLine("\n");
            foreach (var rest in Calculator.getTopRestaurants())
                Console.WriteLine(rest);
        }

        static public void showTopBars()
        {
            Console.WriteLine("\n");
            foreach (var bar in Calculator.getTopBars())
                Console.WriteLine(bar);
        }

        static public Restaurant RandRestClone(List<Restaurant> list)
        {
            Random rnd = new Random();
            int random = rnd.Next(list.Count);
            Restaurant clone = list[random].Clone() as Restaurant;
            clone._Name = String.Concat(clone._Name, "1");
            return clone;
        }

        static public void UpdateRating()
        {            
            Timer.Elapsed += (sender, args) =>
            {
                Random rnd = new Random();
                int random = rnd.Next(EstablishmentsData.getRestaurants().Count);
                EstablishmentsData.getRestaurants()[random].RatingChange();
            };
            Timer.Start();
            Timer.AutoReset = true;
        }
    }
}
