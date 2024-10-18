using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int n = array.Length;

            int[] temp = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                //temp[i] = array[n - 1 - i];
                Console.WriteLine(array[n - 1 - i]);
            }
          
            Console.ReadLine();
        }
    }
}
