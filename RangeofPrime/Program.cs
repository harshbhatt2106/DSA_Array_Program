using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeofPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter First Number:");
            int start = int.Parse(Console.ReadLine());
            
            Console.Write("Enter second Number:");
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i < end; i++)
            {
                bool Istrue = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        Istrue = false;
                        break;
                    }
                }
                if (Istrue)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
