using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2581
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()), n2 = int.Parse(Console.ReadLine());

            int sumPrime = -1, min = 0;
            bool[] isPrime = new bool[n2 + 1];


            for (int i = n; i <= n2; i++)
            {
                if (i == 1)
                    continue;

                isPrime[i] = true;

                for (int j = 2; j * j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime[i] = false;
                        break;
                    }
                }

                if (isPrime[i])
                {
                    if (min == 0)
                        min = i;

                    sumPrime += i;
                }
            }

            if (sumPrime != -1)
                Console.WriteLine(sumPrime + 1);
            else
                Console.WriteLine(sumPrime);

            if (min != 0)
                Console.WriteLine(min);
        }
    }
}
