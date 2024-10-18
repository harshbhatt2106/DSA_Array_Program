using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Common_ThreeElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 10, 5, 96, 78, 44 };
            int[] array2 = { 5, 15, 20, 96 };
            int[] array3 = { 5, 10, 96 };

            int[] comona = new int[array1.Length];
            int index = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    for (int k = 0; k < array3.Length; k++)
                    {
                        if (array1[i] == array3[k] && array1[i] == array2[j])
                        {
                            comona[index] = array1[i];
                            index++;
                        }
                    }
                }
            }
            foreach (var item in comona)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
