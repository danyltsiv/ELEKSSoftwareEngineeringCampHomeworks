using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac5task3
{
    class Program
    {
        static private void PrintArr<T>(List<T> arr)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                Console.Write(String.Concat(arr[i], " "));
            }
            Console.WriteLine("\n");

        }

        static void Main(string[] args)
        {
            List<int> array1 = new List<int>() { 5, 9, 12, 16, 28, 42, 56, 114, 125, 139, 149 };
            List<int> array2 = new List<int>() { 1, 4, 56, 100};

            PrintArr(TwoSortedArrays.Merge(array1, array2));            
            Console.ReadKey();
        }

        static private class TwoSortedArrays
        {
            static public List<int> Merge(List<int> Arr_A, List<int> Arr_B)
            {        
                List<int> Arr_C = new List<int>();
                int Length_C = Arr_A.Count + Arr_B.Count;
                int Index_A = 0;
                int Index_B = 0;

                for (int i = 0; i < Length_C; i++)
                {
                    if (Index_A <= Arr_A.Count-1 && Index_B <= Arr_B.Count-1)
                        if (Arr_A[Index_A] < Arr_B[Index_B])
                        {
                            Arr_C.Add(Arr_A[Index_A]); Index_A++;
                        }
                            else
                            {
                                Arr_C.Add(Arr_B[Index_B]); Index_B++;
                            }
                     else if (Index_A > Arr_A.Count-1)
                     {
                        Arr_C.Add(Arr_B[Index_B]); Index_B++;
                     }
                        else
                        {
                        Arr_C.Add(Arr_A[Index_A]); Index_A++;
                        }
                }
                return Arr_C;
            }
        }
    }
}
