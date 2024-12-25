using System;

namespace FindMinimumAndMaximumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("k min");

            Console.WriteLine("Your Array is { 1, 12, 8, 15, 10 }");
            
            int findK = Convert.ToInt32(Console.ReadLine());
            int[] Arr = { 1, 12, 8, 15, 10 };

            int Kthminimum = int.MinValue;

            for (int count = 0; count < findK; count++)
            {
                int currentMinimum = int.MaxValue;

                foreach (int i in Arr)
                {
                    if (i < currentMinimum && i > Kthminimum)
                    {
                        currentMinimum = i;
                    }
                }

                Kthminimum = currentMinimum;
            }


            Console.WriteLine("Minimum = " + Kthminimum);
            Console.WriteLine("-------------");

            Console.ReadLine();
        }
    }
}