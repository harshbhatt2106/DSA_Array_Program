using System;

namespace LongestConsicutiveSubsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 9, 3, 10, 40, 20, 2, 6, 8, 4 };

            Array.Sort(ints);
            int count = 0;
            int temp = 0;

            for (int j = 0; j < ints.Length; j++)
            {
                temp = ints[j];
                if (temp + 1 == ints[j + 1])
                {
                    count++;
                    Console.WriteLine(temp);
                }
                else
                {
                    Console.WriteLine(temp);
                    count++;
                    break;
                }
            }

            Console.WriteLine("Count:" + count);
            Console.ReadLine();

        }
    }
}
