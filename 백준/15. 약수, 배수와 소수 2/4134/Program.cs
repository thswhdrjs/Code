using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4134
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                long n = long.Parse(Console.ReadLine());

                if(n < 3)
                {
                    Console.WriteLine(2);
                }
                else
                {
                    for (long j = n; j < long.MaxValue; j++)
                    {
                        if (IsPrime(j))
                        {
                            Console.WriteLine(j);
                            break;
                        }
                    }
                }
            }
        }

        static bool IsPrime(long n)
        {
            for (long i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
    }
}
