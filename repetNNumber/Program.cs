using System;

namespace repetNNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3, 4, 1, 2, 6 };

            int[] DuplicateValue = new int[ints.Length];
            int coutn = 0;

            for (int i = 0; i < ints.Length; i++)
            {
                for (int j = 0; j < ints.Length; j++)
                {
                    if (ints[j] == ints[i])
                    {
                        coutn++;
                    }
                    if (coutn == 2)
                    {
                        DuplicateValue[i] = ints[i];
                    }
                }
            }

            foreach (var item in DuplicateValue)
            {
                Console.Write("  " + item);
            }
            Console.ReadLine();

        }
    }
}
