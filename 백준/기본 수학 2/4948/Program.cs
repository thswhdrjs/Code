using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4948
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                int n = int.Parse(Console.ReadLine());

                if (n == 0)
                    break;

                int count = 0;
                bool[] isPrime = new bool[2 * n + 1];

                for (int i = n + 1; i <= 2 * n; i++)
                {
                    if (i == 1)
                        continue;

                    isPrime[i] = true;

                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime[i] = false;
                            break;
                        }
                    }
                }

                for (int i = n + 1; i <= 2 * n; i++)
                {
                    if (isPrime[i])
                        count++;
                }

                Console.WriteLine(count);
            }
        }
    }
}
