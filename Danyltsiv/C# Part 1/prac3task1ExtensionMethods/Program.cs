using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extension;
namespace Extension
{
    public static class SortExtension
    {
        public static List<int> SortListExtension(this List<int> arr)
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
            return arr;
        }
        
    }
}

namespace prac3task1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = new List<int>() { 5, 4, 6, 3, 0, 4, 2, 3, 4 };            
            PrintArr(array.SortListExtension());
            Console.Read();
        }

        static private void PrintArr<T>(List<T> arr)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                Console.Write(String.Concat(arr[i], " "));
            }
            Console.WriteLine("\n");

        }
    }
}
