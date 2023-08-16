using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11653
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int num = n;
            bool[] isPrime = new bool[n + 1];

            if (num != 1)
            {
                for (int i = 2; i <= num; i++)
                {
                    for (int j = 2; j <= num; j++)
                    {
                        isPrime[i] = true;

                        if (num % j != 0)
                            isPrime[i] = false;

                        if (isPrime[i])
                        {
                            while (num % j == 0)
                            {
                                num /= j;
                                Console.WriteLine(j);
                            }
                        }
                    }
                }
            }
        }
    }
}
