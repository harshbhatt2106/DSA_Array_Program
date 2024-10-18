using System;
namespace MaxiMumHeight
{
    internal class MAXHEIGHT
    {
        static void Main(string[] args)
        {
            int[] arr = { 7, 4, 8, 8, 8, 9 };
            // OutPut = 5;
            // 4 7 8 8 8 9 // 10(4+6) 13(7+6) 14(8+6) 2(8+6) 2(8+6) 15(9+6)
            //int k = 6;
            Array.Sort(arr);

            int[] DecrizedArray = new int[6];


            DecrizedArray[0] = arr[0] + 6;
            DecrizedArray[1] = arr[1] + 6;
            DecrizedArray[2] = arr[2] + 6;
            DecrizedArray[3] = arr[3] + 6;
            DecrizedArray[4] = arr[4] + 6;
            DecrizedArray[5] = arr[5] + 6;
            Array.Sort(DecrizedArray);
            
            int diff = DecrizedArray[5] - DecrizedArray[0];
            
            foreach (var item in DecrizedArray)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine("--------");
            Console.WriteLine(diff);
            Console.ReadLine();

        }
    }
}
