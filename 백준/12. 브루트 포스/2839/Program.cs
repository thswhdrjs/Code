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

            int count = -1;

            for (int i = 0; i <= n / 3; i++)
            {
                int n2 = n - i * 3;

                if (n2 % 5 != 0)
                    continue;

                count = i + n2 / 5;
                break;
            }

            Console.WriteLine(count);
        }
    }
}
