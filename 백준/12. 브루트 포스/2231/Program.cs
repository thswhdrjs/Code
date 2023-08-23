using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2231
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = n;
            int sum = 0;
            int digit = 0;
            int constructor = 0;

            while (true)
            {
                digit += 9;

                if (num / 10 != 0)
                    num /= 10;
                else
                    break;
            }

            for (int i = n - digit; i < n; i++)
            {
                num = i;
                sum = 0;

                while (true)
                {
                    sum += num % 10;

                    if (num / 10 != 0)
                        num /= 10;
                    else
                        break;
                }

                if (i + sum == n)
                {
                    constructor = i;
                    break;
                }
            }

            Console.WriteLine(constructor);
        }
    }
}
