using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_practice
{
    internal class linearsearch
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("Enter Number If You Find Number ");
            int find = Convert.ToInt32(Console.ReadLine());
            int[] linearsearch = { 10, 20, 30 };
            for (i = 0; i < linearsearch.Length; i++)
            {

                if (linearsearch[i] == find)
                {
                    Console.WriteLine("Iteam Found " + linearsearch[i] + "Loaction number is " + i);
                }
            }
            if (linearsearch.Length <= i)
            {
                Console.WriteLine("Iteam Not Found");
            }
            Console.ReadLine();
        }
    }
}
