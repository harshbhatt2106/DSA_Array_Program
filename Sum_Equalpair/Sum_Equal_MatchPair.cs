using System;

namespace Sum_Equalpair
{
    internal class Sum_Equal_MatchPair
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number Of element Array  ");
            int a = Convert.ToInt32(Console.ReadLine());

            int[] data = new int[a];
            for (int i = 0; i < a; i++)
            {
                Console.Write("Enter Value Of array:");
                data[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter target Number:");
            int target = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int temp;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = i + 1; j < data.Length; j++)
                {
                    temp = data[i] + data[j];
                    if (temp == target)
                    {
                        Console.WriteLine("sum of : " + data[i] + " and " + data[j] + "==:" + target);
                        sum++;
                    }
                }
                temp = 0;
            }
            Console.WriteLine("Sum Is:{0}", sum);
            Console.ReadLine();
        }
    }
}
