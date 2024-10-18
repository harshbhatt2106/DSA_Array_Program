using System;
using System.Numerics;

namespace FactorialOF_largeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Find = 100;
            BigInteger sum = Find;
            
            for (int i = Find - 1; i > 0; i--)
            {
                sum = i * sum;
            }   
            
            Console.WriteLine(sum);
           
            Console.ReadLine();
        }
    }
}
