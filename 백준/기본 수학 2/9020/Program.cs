using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9020
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for(int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());

                int[] goldbach = new int[2];
                bool[] isPrime = new bool[n + 1];

                for (int j = n / 2; j <= n; j++)
                {
                    isPrime[j] = true;

                    for (int k = 2; k < j; k++)
                    {
                        if (j % k == 0)
                        {
                            isPrime[j] = false;
                            break;
                        }
                    }

                    if (isPrime[j])
                    {
                        goldbach[0] = n - j;
                        goldbach[1] = j;

                        if (goldbach[0] % 3 == 0 && goldbach[0] < 4)
                            break;
                        else if (goldbach[0] % 3 != 0)
                            break;
                    }
                }

                Console.WriteLine(goldbach[0] + " " + goldbach[1]);
            }
        }
    }
}
