using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockWiseArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5 };
            int a = arr1.Length - 1;

            int[] ClockWiseArr = new int[arr1.Length];

            ClockWiseArr[0] = arr1[a];

            int c = 0;

            for (int i = 1; i < arr1.Length; i++)
            {
                ClockWiseArr[i] = arr1[c];
                c++;
            }
            //int[] ClockWiseArr = new int[arr1.Length];
            //ClockWiseArr[0] = arr1[arr1.Length - 1];

            //Array.Copy(arr1, 0, ClockWiseArr, 1, arr1.Length - 1);
            foreach (var item in ClockWiseArr)
            {
                Console.Write(" " + item + " ");
            }

            Console.ReadKey();
        }
    }
}
