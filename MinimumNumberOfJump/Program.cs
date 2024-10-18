using System;
using System.Data;
using System.Xml.Schema;

namespace MinimumNumberOfJump
{

    internal class Program
    {
       
        static void Main(string[] args)
        {
            int[] Arr = { 1, 3, 5, 8, 9, 2, 6, 7, 6, 8, 9 };

            int NumberOfJump = 0;

            int ArrayLenghth = Arr.Length;

           
            int i = 0;
            int value = 0;

            while (i < ArrayLenghth)
            {
                i = i;

                value = Arr[i];
                
                i = i + value;

                NumberOfJump++;

                if (i >= ArrayLenghth)
                {
                    break;
                }
            }
            Console.WriteLine();
            Console.WriteLine(NumberOfJump);

            Console.ReadKey();
        }
    }
}
