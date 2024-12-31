using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Median_of_two_sorted_arrays_of_same_size
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] FirsrArray = { 10 };
            int[] SecondArray = { 21 };

            int[] sortedarray = new int[FirsrArray.Length + SecondArray.Length];

            int j = 0;
            int i = 0;
            int k = 0;

            while (i < FirsrArray.Length && j < SecondArray.Length)
            {
                if (FirsrArray[i] < SecondArray[j])
                {
                    sortedarray[k] = FirsrArray[i];
                    i++;
                }
                else
                {
                    sortedarray[k] = SecondArray[j];
                    j++;
                }
                k++;
            }
            while (i < FirsrArray.Length)
            {
                sortedarray[k] = FirsrArray[i];
                i++;
                k++;
            }

            while (j < SecondArray.Length)
            {
                sortedarray[k] = SecondArray[j];
                j++;
                k++;
            }

            int mid1 = sortedarray.Length / 2;
            int mid2 = mid1 - 1;
            int median = (sortedarray[mid1] + sortedarray[mid2]) / 2;

            Console.WriteLine(median);
            Console.ReadLine();
        }
    }
}
