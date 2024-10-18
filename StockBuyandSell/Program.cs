using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace StockBuyandSell
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] prices = { 1, 3, 6, 9, 11 };
            int MinPrice = prices[0];
            int MaxPrice = 0;
            int MinPriceindex = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] <= MinPrice)
                {
                    MinPrice = prices[i];
                    MinPriceindex = i;
                }
            }

            int temp;

            for (int i = MinPriceindex; i < prices.Length; i++)
            {
                temp = prices[i] - MinPrice;
                
                if (temp> MaxPrice)
                {
                    MaxPrice = temp;
                }
            }

            Console.WriteLine(MaxPrice);

            Console.ReadLine();
        }
    }
}
