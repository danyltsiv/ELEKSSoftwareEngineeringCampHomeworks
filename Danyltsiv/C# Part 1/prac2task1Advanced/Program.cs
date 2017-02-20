using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace prac2task1
{
    class Program
    {
        static private void PrintArr<T>(List<T> arr)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                Console.Write(String.Concat(arr[i]," "));
            }
            Console.WriteLine("\n");

        }
        static void Main(string[] args)
        {
            List<int> arr = GenerateArrayList();
            var listCopy = arr.ToList();
            PrintArr(arr);
            var watch = new Stopwatch();
            watch.Start();
            BubbleSort.Sort(arr);
            watch.Stop();
            //var header = string.Concat("buble sorted " , arr.Count , "-elements list");
            //var header = string.Format("Bubble sort takes: {0:hhmmss}", watch.Elapsed);
            var header = $"Bubble sort takes:  {watch.Elapsed}";
            Console.WriteLine(header, "");
            PrintArr(arr);
            Console.ReadKey();
        }
      
        private static List<int> GenerateArrayList()
        {
            var listLength = Convert.ToInt32(Console.ReadLine());
            List<int> myList = new List<int>();
            var rnd = new Random();
            for (int i = 0; i < listLength; i++)
                myList.Add(rnd.Next(100));
            return myList;
        }

        static private class BubbleSort {

           static public void Sort(List<int> arr)
            {
                for (int j = 0; j < arr.Count; j++)
                    for (int i = 0; i < arr.Count - j - 1; i++)
                    {
                        if (arr[i] > arr[i + 1])
                        {
                            var temp = arr[i];
                            arr[i] = arr[i + 1];
                            arr[i + 1] = temp;
                         }                    
                    }                       
            }
        }
    }
}
