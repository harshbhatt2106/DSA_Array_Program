using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocolate_Distribution_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 7, 3, 2, 4, 9, 12, 88 };
            Array.Sort(arr);
            int number_of_Student = 3;

            int min = int.MaxValue;

            for (int i = 0; i < arr.Length - number_of_Student; i++)
            {
                if (arr[i + number_of_Student - 1] - arr[i] < min)
                {
                    min = arr[i + number_of_Student - 1] - arr[i];
                }
            }

            Console.WriteLine(min);
            Console.ReadLine();
        }
    }
}
