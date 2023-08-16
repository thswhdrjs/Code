using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1929
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int n = int.Parse(s[0]), n2 = int.Parse(s[1]);

            bool[] isPrime = new bool[n2 + 1];

            for (int i = n; i <= n2; i++)
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

            for (int i = n; i <= n2; i++)
            {
                if (isPrime[i])
                    Console.WriteLine(i);
            }
        }
    }
}
