using System;

namespace MaximumSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { -2, -3, 4, -1, -2, 1, 5, -3 };

            int sum = 0;

            int plush = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

                if (plush < sum)
                {
                    plush = sum;
                }
                else if (sum < 0)
                {
                    sum = 0;
                }
            }
            Console.WriteLine(plush);
            Console.ReadLine();
        }
    }
}
