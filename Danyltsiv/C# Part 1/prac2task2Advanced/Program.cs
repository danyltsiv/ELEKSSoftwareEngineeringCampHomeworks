using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac2task2
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
            List<int> array1 = new List<int>() {5,9,12,16,28,42,56,114,125,139,149 };
            List<int> array2 = new List<int>() { 1,4, 56, 100};

            PrintArr(TwoSortedArrays.Merge(array1, array2));            
            Console.ReadKey();
        }

        static private class TwoSortedArrays
        {

            static public List<int> Merge(List<int> A, List<int> B)
            {        
                List<int> C = new List<int>();
                int CLength = A.Count + B.Count;
                int IndexA = 0;
                int IndexB = 0;

                for (int i = 0; i < CLength; i++)
                {
                    if (IndexA <= A.Count-1 && IndexB <= B.Count-1)
                        if (A[IndexA] < B[IndexB])
                        {
                            C.Add(A[IndexA]); IndexA++;
                        }
                        else
                        {
                            C.Add(B[IndexB]); IndexB++;
                        }
                    else if (IndexA > A.Count-1)
                    {C.Add(B[IndexB]); IndexB++;}
                    else
                    {C.Add(A[IndexA]); IndexA++; }

                }

                return C;

            }
        }
      }
    }
