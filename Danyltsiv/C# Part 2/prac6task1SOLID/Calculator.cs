using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac6task1
{
    public static class Calculator 
    {
         public static List<Restaurant> getTopRestaurants()
        {
            var sorted = EstablishmentsData.getRestaurants().OrderBy(g => g._Rating).Reverse().ToList();
            var temp = sorted.GetRange(0, 5);
            return temp;
        }

         public static List<Bar> getTopBars()
        {
            var sorted = EstablishmentsData.getBars().OrderBy(g => g._Rating).Reverse().ToList();
            var temp = sorted.GetRange(0, 5);
            return temp;
        }

         public static void showTopRestaurants()
        {
            Console.WriteLine("\n");
            foreach (var rest in Calculator.getTopRestaurants())
                Console.WriteLine(rest);
        }

         public static void showTopBars()
        {
            Console.WriteLine("\n");
            foreach (var bar in Calculator.getTopBars())
                Console.WriteLine(bar);
        }
    }
}
