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

            Console.Write("Enter the number of elements in the array: ");
            int size = int.Parse(Console.ReadLine());

            int[] Arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter Elemt of array ");
                Arr[i] = int.Parse(Console.ReadLine());
            }


            int[] sortedarray = new int[size];

            int indexOfSortedaarray = 0;

            int kthminimum = int.MinValue;
            for (int i = 0; i < Arr.Length; i++)
            {
                int minium = int.MaxValue;
                foreach (int j in Arr)
                {
                    if (j < minium && j > kthminimum)
                    {
                        minium = j;
                    }
                    if (j == kthminimum)
                    {
                        sortedarray[indexOfSortedaarray] = j;
                        indexOfSortedaarray++;
                    }
                }
                kthminimum = minium;
            }

            Console.WriteLine("** Sorted Array **");

            foreach (var item in sortedarray)
            {
                Console.Write("  " + item);
            }
            Console.ReadLine();
        }
    }
}
