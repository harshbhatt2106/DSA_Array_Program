using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOnversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 7, 2, 6, 3};
            int temp = 0;
            int FainlaCount=0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp++;
                    }
                }
                FainlaCount += temp;
                temp = 0;
            }
            Console.WriteLine(FainlaCount);

            Console.ReadLine();
        }
    }
}
