using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2839
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int big = 0, small = 0, total = 0;

            if (n % 5 % 3 == 0)
            {
                big = n / 5;
                small = n % 5 / 3;
                total = big + small;
            }
            else if (n > 5 && (n % 5 + 5) % 3 == 0)
            {
                big = n / 5 - 1;
                small = (n % 5 + 5) / 3;
                total = big + small;
            }
            else if (n % 3 == 0)
                total = n / 3;
            else
                total = -1;

            Console.WriteLine(total);
        }
    }
}
