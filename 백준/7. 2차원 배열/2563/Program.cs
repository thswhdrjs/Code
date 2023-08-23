using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2563
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int[,] arr = new int[101, 101];
            int sum = 0;

            for(int i = 0; i < t; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                int x = int.Parse(s[0]), y = int.Parse(s[1]);

                for(int j = x; j < x + 10; j++)
                {
                    for (int k = y; k < y + 10; k++)
                    {
                        arr[j, k]++;
                    }
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] != 0)
                        sum++;
                }
            }

            Console.WriteLine(sum);
        }
    }
}