using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subsetofAnotherArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] first = { 10, 5, 2, 23, 19 };
            int[] second = {10,23,23};

            bool IsSubArray = false;

            for (int i = 0; i < second.Length; i++)
            {
                IsSubArray = false;
                for (int j = 0; j < first.Length; j++)
                {
                    if (second[i] == first[j])
                    {
                        IsSubArray = true;
                    }
                }
                if(!IsSubArray)
                {
                    break;
                }
            }
            if (IsSubArray)
            {
                Console.WriteLine("Is Sub array");
            }
            else
            {
                Console.WriteLine("Is not subarray");
            }
            Console.ReadLine();
        }
    }
}
