using System;

namespace MargeINtervals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[][]
            {
                new int [] { 1, 3 },
                new int [] { 2, 6 },
                new int [] { 8, 10 },
                new int [] { 15, 18 }
            };

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (true)
                    {
                        Console.WriteLine($"Array {i} and Array {i + 1} are +");
                    }
                }
            }
            Console.ReadLine();

        }
    }
}
