using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3009
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 2];

            for(int i = 0; i < 3; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                arr[i, 0] = int.Parse(s[0]);
                arr[i, 1] = int.Parse(s[1]);
            }

            int minus = 0;
            int common = 0;
            int rest = 0;
            int big = 0;

            for (int i = 0; i < arr.GetLength(0) - 1; i++)
            {
                for (int j = i + 1; j < arr.GetLength(0); j++)
                {
                    if (arr[i, 0] == arr[j, 0])
                    {
                        common = arr[i, 0];
                        big = arr[i, 1] > arr[j, 1] ? arr[i, 1] : arr[j, 1];
                        minus = Math.Abs(arr[i, 1] - arr[j, 1]);
                        break;
                    }

                    if (common != 0)
                        break;
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (arr[i, 0] == common)
                    continue;

                minus *= arr[i, 1] < big ? 1 : -1;
                rest = arr[i, 1] + minus;
                Console.WriteLine(arr[i, 0] + " " + rest);
            }
        }
    }
}
