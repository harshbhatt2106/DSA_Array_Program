using System;
using System.Collections;

namespace MoreThan1_K__Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            int[] array = { 3, 3, 3, 3, 4, 7, 7, 9, 7, 6, 2 };
            int k = 4;
            int n = array.Length;
            int AfterDevide = n / k;
            int Times = 1;


            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        Times++;
                    }
                    if (Times > AfterDevide)
                    {
                        arrayList.Add(array[i]);
                    }
                }
                Times = 1;
            }
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
