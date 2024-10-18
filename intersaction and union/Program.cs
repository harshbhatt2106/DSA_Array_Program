using System;
using System.Collections;

namespace intersaction_and_union
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = { 3, 4, 5, 6, 7, 8 };
            int[] union = new int[arr1.Length + arr2.Length];

            Console.WriteLine("Your First Array");
            foreach (var item in arr1)
            {
                Console.Write(" "+item+" ");
            }
            
            Console.WriteLine();
            
            Console.WriteLine("Your Second Array");
            foreach (var item in arr2)
            {
                Console.Write(" " + item + " ");
            }
            
            int index = 0;

            foreach (int i in arr1)
            {
                union[index] = i;
                index++;
            }

            foreach (int array2iteam in arr2)
            {
                bool Ispresent = false;
            
                for (int i = 0; i < union.Length - arr1.Length; i++)
                {
                    if (union[i] == array2iteam)
                    {
                        Ispresent = true;
                        break;
                    }
                }

                if (Ispresent == false)
                {
                    union[index] = array2iteam;

                    index++;
                }
            }
            Console.WriteLine();

            Console.WriteLine("----------union----------");
            foreach (int item in union)
            {
                Console.Write(" " + item + " ");
            }
            Console.WriteLine();

            Console.WriteLine("----------interaction----------");

            ArrayList interation = new ArrayList();
            int iterationindex = 0;

            foreach (int array1 in arr1)
            {
                foreach (int array2 in arr2)
                {
                    if (array1 == array2)
                    {
                        interation.Add(array2);
                        iterationindex++;   
                    }
                }
            }

            foreach (int item in interation)
            {
                Console.Write(" " + item + " ");
            }

            Console.ReadLine();
        }
    }
}
