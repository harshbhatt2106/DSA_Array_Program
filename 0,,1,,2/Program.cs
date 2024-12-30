using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0__1__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c0 = 0, c1 = 0, c2 = 0;

            Console.WriteLine("Enter Value of Array");
            int[] arr = new int[5];
            int[] newar = new int[5];
            for (int j = 0; j < 5; j++)
            {
                Console.Write("Enter Elemt of array ");
                arr[j] = int.Parse(Console.ReadLine());
            }

            for (int o = 0; o < arr.Length; o++)
            {
                if (arr[o] == 0)
                {
                    c0 += 1;
                }
                else if (arr[o] == 1)
                {
                    c1 += 1;
                }
                else
                {
                    c2 += 1;
                }
            }

            int idx = 0;

            for (int i = 0; i < c0; i++)
                arr[idx++] = 0;

            for (int i = 0; i < c1; i++)
                arr[idx++] = 1;

            for (int i = 0; i < c2; i++)
                arr[idx++] = 2;

            for (int j = 0; j < arr.Length; j++)
            {
                Console.WriteLine(arr[j]);
            }
        }
    }
}
// its my code 
//Console.Write("Enter the number of elements in the array: ");
//int size = int.Parse(Console.ReadLine());

//int[] Arr = new int[size];

//for (int i = 0; i < size; i++)
//{
//    Console.Write("Enter Elemt of array ");
//    Arr[i] = int.Parse(Console.ReadLine());
//}


//int[] sortedarray = new int[size];

//int indexOfSortedaarray = 0;

//int kthminimum = int.MinValue;
//for (int i = 0; i < Arr.Length; i++)
//{
//    int minium = int.MaxValue;
//    foreach (int j in Arr)
//    {
//        if (j < minium && j > kthminimum)
//        {
//            minium = j;
//        }
//        if (j == kthminimum)
//        {
//            sortedarray[indexOfSortedaarray] = j;
//            indexOfSortedaarray++;
//        }
//    }
//    kthminimum = minium;
//}

//Console.WriteLine("** Sorted Array **");

//foreach (var item in sortedarray)
//{
//    Console.Write("  " + item);
//}
//Console.ReadLine();