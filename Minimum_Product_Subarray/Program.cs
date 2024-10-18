using System;

namespace Minimum_Product_Subarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 6, -3, -10, 0, 2 };//180
            int[] arr = { -1, -3, -10, 0, 60 };//60
            int Maximum = int.MinValue;

            int total = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int k = i; k < arr.Length; k++)
                {
                    total = total * arr[k];
                    if (total > Maximum)
                    {
                        Maximum = total;
                    }
                }
            }

            Console.WriteLine("Maximum:" + Maximum);
            Console.ReadLine();
        }
    }
}
