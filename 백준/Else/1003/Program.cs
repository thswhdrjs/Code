using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1003
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(DP_Fibonacci(n));

                int[,] arr = new int[100, 2];
                arr[0, 0] = 1;
                arr[1, 1] = 1;

                for (int j = 2; j <= n; j++)
                {
                    arr[j, 0] = arr[j - 1, 0] + arr[j - 2, 0];
                    arr[j, 1] = arr[j - 1, 1] + arr[j - 2, 1];
                }

                Console.WriteLine(string.Format("{0} {1}", arr[n, 0], arr[n, 1]));
            }
        }

        static int? DP_Fibonacci(int n)
        {
            int?[] arr = new int?[100];
            arr[0] = 0;
            arr[1] = 1;

            if (arr[n] == null)
                arr[n] = DP_Fibonacci(n - 1) + DP_Fibonacci(n - 2);

            return arr[n];
        }
    }
}
