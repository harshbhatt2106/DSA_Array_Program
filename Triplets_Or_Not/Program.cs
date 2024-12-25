using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triplets_Or_Not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 9;
            int[] arr = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; i < arr.Length; j++)
                {
                    for (int k = j + 1; k < arr.Length; k++)
                    {
                        if (arr[i] + arr[j] + arr[k] == sum)
                        {
                            Console.WriteLine($"Triplet is {arr[i]}, {arr[j]}, {arr[k]}");
                        }
                    }
                }
            }
            Console.ReadLine(); 

        }
    }
}
