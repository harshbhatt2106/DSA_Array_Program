using System;
using System.Collections.Generic;

namespace Alternmate_Minus_plush
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int>
            {
                1,2,3,-4,-8,4
            };

            bool flag = true;
            int[] narray = new int[list.Count];

            for (int i = 0; i <= narray.Length; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (flag == true && list[j] > 0)
                    {
                        narray[i] = list[j];
                        list.RemoveAt(j);
                        flag = false;
                        break;
                    }
                    else if (flag == false && list[j] < 0)
                    {
                        narray[i] = list[j];
                        list.RemoveAt(j);
                        flag = true;
                        break;
                    }
                }
            }

            foreach (var val in narray)
            {
                Console.WriteLine(val);
            }

            Console.ReadLine();
        }
    }
}

