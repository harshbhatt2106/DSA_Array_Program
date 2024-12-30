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
                Console.WriteLine(array[n - 1 - i]);
            }
          
            Console.ReadLine();
        }
    }
}
// programe wrriten by geeksforgeeks 

//class GfG
//{

//    static void reverseArray(int[] arr)
//    {
//        int n = arr.Length;

//        int[] temp = new int[n];

//        for (int i = 0; i < n; i++)
//            temp[i] = arr[n - i - 1];

//        for (int i = 0; i < n; i++)
//            arr[i] = temp[i];
//    }

//    static void Main()
//    {
//        int[] arr = { 1, 4, 3, 2, 6, 5 };

//        reverseArray(arr);

//        for (int i = 0; i < arr.Length; i++)
//            Console.Write(arr[i] + " ");
//    }
//}