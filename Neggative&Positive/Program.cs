using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neggative_Positive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int indexOfSortedaarray = 0;

            int[] Arr = { 2, 8, -9, 5, 7, -1, -2};
            int[] SorteedArr = new int[Arr.Length];

            foreach (var item in Arr)
            {
                if (item < 0)
                {
                    Arr[indexOfSortedaarray] = item;
                    indexOfSortedaarray++;
                }
            }
          
            foreach (var item in Arr)
            {
                if (item > 0)
                {
                    Arr[indexOfSortedaarray] = item;
                    indexOfSortedaarray++;
                }
            }

            foreach (var data in Arr)
            {
                Console.WriteLine(data);
            }
            Console.ReadLine();
        }
    }
}
