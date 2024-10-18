using System;

namespace Sum_Equalpair
{
    internal class Sum_Equal_MatchPair
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number Of Array  ");
            int a = Convert.ToInt32(Console.ReadLine());

            int[] data = new int[a];
            for (int i = 0; i < a; i++)
            {
                Console.Write("Enter Value Of array ");
                data[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter target Number ");
            int target = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < data.Length; i++)
            {
                for (int j = i + 1; j < data.Length; j++)
                {
                    int temp = data[i] + data[j];
                    if (temp == target)
                    {
                        sum++;
                    }
                }
                //Console.WriteLine(sum);
            }
            Console.WriteLine("Sum Is:{0}", sum);
            Console.ReadLine();
        }
    }
}
