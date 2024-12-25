using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMum_Maximum
{

    internal class Program
    {
       
        static void Main(string[] args)
        {

            int min = int.MaxValue;
            int max = int.MinValue;
            int[] arrau = { 8, 7, 5, 69, 8, 4, 1, 2 };

           
            for (int i = 1; i < arrau.Length; i++)
            {
                if (arrau[i] > max)
                {
                    max = arrau[i];
                }
                else if (arrau[i] < min)
                {
                    min = arrau[i];
                }
            }

            Console.WriteLine("min:" + min);
            Console.WriteLine("max:" + max);

            Console.ReadLine();
        }
    }
}
