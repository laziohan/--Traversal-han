using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[10, 10];
            Populate(arr);
            display(arr);
            Console.ReadKey();
        }
        public static void Populate(int[,] arr)
        {
            int cycleCount = 0;
            int xm = arr.GetLength(0), ym = arr.GetLength(1);
            //cycleCount = Math.Ceiling(Math.Min(xm, ym) / 2);
            while (xm > 0 && ym > 0)
            {
                cycleCount++;
                xm -= 2;
                ym -= 2;
            }
            for (int i = 0; i < cycleCount; i++)
            {
                for (int j = i; j < arr.GetLength(0) - i; j++)
                {
                    arr[j, i] = i;
                }
                for (int x = i; x < arr.GetLength(1) - (i + 1); x++)
                {
                    arr[i, x+1] = i;
                }
                for (int n = arr.GetLength(0) - (i + 1), m = arr.GetLength(1) - (i + 1); n > i; n--)
                {
                    arr[n, m] = i;
                }
                for (int n = arr.GetLength(0) - (i + 1), m = arr.GetLength(1) - (i + 1); m > i+1; m--)
                {
                    arr[n, m-1] = i;
                }
            }
        }

        private static void display<T>(T[,] arr) {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j]);
                }
                Console.WriteLine("第" + i + "行");
            }
        }
    }
}
