using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac3task3
{
    class Program
    {
        static private void PrintArr<T>(IEnumerable<T> arr)
        {
            var num = arr.GetEnumerator();
            
            foreach(T elem in arr)
                Console.Write(String.Concat(elem, " "));
            
            Console.WriteLine("\n");

        }
        static void Main(string[] args)
        {
            List<int> A = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            IEnumerable<int> B = new List<int>();
            int D = 8;
            
            
            int i=0;

            for (i = 0; i < A.Count; i++)
                if (A[i] > D)
                {
                         B = 
                        from elem in A.Reverse<int>().Take(A.Count - i).ToList()
                        where elem % 2 == 1
                        select elem;
                    break;
                }
            PrintArr(B);
            Console.Read();
           
        }
    }
}
