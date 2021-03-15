using System;

namespace Homework5_5_
{
    class Program
    {
        static void Main(string[] args)
        {
            //2ое задание с использованием массива массивов.

            int[][] arr = new int[3][]

            {
               new int[]        { 2, 45, 89, 7 },
               new int[]        { 45, 12, 4, 97, 34, 69,57},
               new int[]        { 7, 18, 96, 32, 5,89,12,36,1,14 }
            };
                
            for (int y = 0; y < arr.Length; y++)
            {
                int max = 0;
                int maxIndex = -1;
                for (int x = 0; x < arr[y].Length; x++)
                {
                    if (arr[y][x] > max)
                    {
                        max = arr[y][x];
                        maxIndex = x;

                    }

                }

                for (int x = 0; x < arr[y].Length; x++)
                {
                    if (x <= maxIndex)
                    {
                        Console.Write(arr[y][x] + "  ");
                    }
                    else
                        Console.Write(0 + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}
