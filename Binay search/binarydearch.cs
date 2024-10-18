using System;

namespace Binay_search
{
    internal class binarydearch
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number ");
            int[] binarySearch = { 10, 20, 30, 40, 50 };
            int mid=0, lp = 0, i, up = binarySearch.Length - 1, iteamfound = Convert.ToInt32(Console.ReadLine());
            Boolean foundornot = false;

            for (i = 0; lp <= up; i++)
            {
                mid = (lp + up) / 2;
                if (binarySearch[mid] == iteamfound)
                {
                    foundornot = true;
                    break;
                }
                if (binarySearch[mid] < iteamfound)
                {
                    lp = mid + 1;
                }
                else
                {
                    up = mid - 1;
                }
            }

            if (foundornot == true)
            {
                Console.WriteLine("iteam found" + mid);
            }
            else
            {
                Console.WriteLine("iteam not found");
            }
            Console.ReadLine();
        }
    }
}