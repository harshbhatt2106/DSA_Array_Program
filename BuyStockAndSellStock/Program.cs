using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BuyStockAndSellStock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] price = { 10, 22, 5, 75,80, 65 };


            int FirstMinprice = price.Min();
            int sell = price.Max();
            int profit = sell - FirstMinprice;


            Console.WriteLine(profit);
            Console.ReadLine();
        }
    }
}
