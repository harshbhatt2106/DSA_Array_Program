using System;
namespace Fibonaki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello");
            int[] fibo = new int[number];

            {
                fibo[0] = 0;
                fibo[1] = 1;
            }
            for (int i = 2; i < number; i++)
            {
                fibo[i] = fibo[i - 1] + fibo[i - 2];
            }
            foreach (var item in fibo)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
