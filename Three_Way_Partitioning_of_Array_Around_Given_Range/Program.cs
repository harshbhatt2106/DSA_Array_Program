using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three_Way_Partitioning_of_Array_Around_Given_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1,5,4,2,1,3,14,20,20,98,87,32,54
            int[] array = { 1, 14, 5, 20, 4, 2, 54, 20, 87, 98, 3, 1, 32 };


            int low_level = 10;
            int High_level = 20;
            int start = 0;
            int end = array.Length - 1;

            for (int i = 0; i <=end;)
            {
                if (array[i] < low_level)
                {
                    int ne = array[start];
                    array[start] = array[i];
                    array[i] = ne;
                    start++;
                    i++;
                }
                else if (array[i] > High_level)
                {
                    int ne = array[end];
                    array[end] = array[i];
                    array[i] = ne;
                    end--;

                }
                else
                {
                    i++;
                }
                //else if (array[i] >= low_level && array[i] <= High_level)
                //{
                //    temp[start] = array[i];
                //    start++;
                //}
            }

            foreach (var item in array)
            {
                Console.Write("," + item);
            }
            Console.ReadLine();
        }
    }
}
