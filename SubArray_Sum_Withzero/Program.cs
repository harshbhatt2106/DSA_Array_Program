using System;

namespace SubArray_Sum_Withzero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 2,-3, 1, 6 };
            int sum = 0;
            bool? IsTrue = false;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    sum += arr[j];
                    if (sum == 0)
                    {
                        IsTrue = true;
                        break;
                    }
                }
                sum = 0;
            }
            Console.WriteLine(IsTrue);
            Console.ReadLine();
        }
    }
}
