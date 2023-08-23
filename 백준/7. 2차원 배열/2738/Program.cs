using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2738
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int n = int.Parse(s[0]), m = int.Parse(s[1]);
            int[,] arr = new int[n, m], arr2 = new int[n, m], arrSum = new int[n, m];

            for(int i = 0; i < n; i++)
            {
                s = Console.ReadLine().Split(' ');

                for(int j = 0; j < m; j++)
                {
                    arr[i, j] = int.Parse(s[j]);
                }
            }

            for (int i = 0; i < n; i++)
            {
                s = Console.ReadLine().Split(' ');

                for (int j = 0; j < m; j++)
                {
                    arr2[i, j] = int.Parse(s[j]);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    Console.Write(string.Format("{0} ", arr[i, j] + arr2[i, j]));
                }

                Console.WriteLine();
            }
        }
    }
}
