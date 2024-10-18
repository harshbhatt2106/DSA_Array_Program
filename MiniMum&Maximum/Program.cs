using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMum_Maximum
{
    //public struct MyStruct
    //{
    //    public int min;
    //    public int max;
    //}

    internal class Program
    {
        //static MyStruct GetMy(int[] array, int size)
        //{

        //    MyStruct myStruct = new MyStruct();

        //    Array.Sort(array);
        //    myStruct.max = array[size - 1];
        //    myStruct.min = array[0];

        //    return myStruct;

        //}
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



            //MyStruct a =   GetMy(arrau, arrau.Length);

            Console.WriteLine("min:" + min);
            Console.WriteLine("max:" + max);

            Console.ReadLine();
        }
    }
}
