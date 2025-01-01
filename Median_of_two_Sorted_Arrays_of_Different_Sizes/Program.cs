using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Median_of_two_Sorted_Arrays_of_Different_Sizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] FirsrArray = { 0 };
            int[] SecondArray = { 2, 4, 5, 6 };

            int j = 0;
            int i = 0;
            int k = 0;

            int[] FainalArray = new int[FirsrArray.Length + SecondArray.Length];

            while (i < FirsrArray.Length && j < SecondArray.Length)
            {
                if (FirsrArray[i] < SecondArray[j])
                {
                    FainalArray[k] = FirsrArray[i];
                    i++;
                }
                else
                {
                    FainalArray[k] = SecondArray[j];
                    j++;
                }
                k++;
            }
            while (i < FirsrArray.Length)
            {
                FainalArray[k] = FirsrArray[i];
                i++;
                k++;
            }

            while (j < SecondArray.Length)
            {
                FainalArray[k] = SecondArray[j];
                j++;
                k++;
            }


            int median = FainalArray.Length / 2;

            Console.WriteLine(FainalArray[median]);

            Console.ReadLine();
        }
    }
}
