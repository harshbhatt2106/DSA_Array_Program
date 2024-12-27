using System;
using System.Runtime.CompilerServices;

namespace Smallest_subarray_with_sum_greater_than_a_given_value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 10, 5, 2, 7 };
            int x = 51;
            int sum = 0;
            int count = 1;
            int oldcount = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    sum = sum + arr[j];
                    count++;
                    if (sum > x)
                    {
                        if (count < oldcount)
                        {
                            oldcount = count;
                        }
                        break;
                    }
                }
                count = 1;
            }
            if (oldcount == int.MaxValue)
            {
                oldcount = 0;
            }
            Console.WriteLine(oldcount);
            Console.ReadLine();
        }
    }
}
