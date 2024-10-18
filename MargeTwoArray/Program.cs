using System;

namespace MargeTwoArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] FirsrArray = { 1, 3, 4, 5 };
            int[] SecondArray = { 2, 4, 6, 8 };

            int[] FainalArray = new int[FirsrArray.Length+SecondArray.Length];

            int j = 0;
            int i = 0;
            int k = 0;

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

            foreach (int s in FainalArray)
            {
                Console.Write(" " + s);
            }
            Console.ReadLine();
        }
    }
}