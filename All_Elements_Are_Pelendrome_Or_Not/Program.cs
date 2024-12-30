using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_Elements_Are_Pelendrome_Or_Not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 121, 131, 202 };

            if (MyClass.IsArrayIspele(arr,arr.Length))
            {
                Console.WriteLine("Is pelendrome");
            }
            else
            {
                Console.WriteLine("Is not pelendrome");
            }
            Console.ReadLine();
        }
    }
    public static class MyClass
    {
        public static bool IsArrayIspele(int [] array,int n)
        {
            for (int i = 0; i < n; i++)
            {
                bool abs =  Ispelendrome(array[i]);
                if(abs==false)
                {
                    return false;
                }
               
            }
            return true;
        }
        public static bool Ispelendrome(int N)
        {
            string str = "" + N;
            int len = str.Length;
            for (int i = 0; i < len / 2; i++)
            {
                if (str[i] != str[len - 1 - i])
                    return false;
            }
            return true;
        }
    }

}
