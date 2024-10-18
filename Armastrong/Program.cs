using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armastrong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeofarray = int.Parse(Console.ReadLine());
            int[] Arr = new int[sizeofarray];
            for (int i = 0; i < sizeofarray; i++)
            {
                Console.WriteLine("Ennter Number Values of Array " + (i + 1));
                int values = int.Parse(Console.ReadLine());
                Arr[i] = values;
            }
            int Result = 0;
            string orignel = string.Empty;

            Console.WriteLine("-----------------------------------");

            foreach (var item in Arr)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    Result += item * Arr.Length;
                }
            }
            if (Result == 0)
            {

            }
            Console.WriteLine(Result);
            Console.WriteLine(orignel);
            Console.ReadLine();
        }
    }
}
