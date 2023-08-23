using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1712
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int n = int.Parse(s[0]), n2 = int.Parse(s[1]), n3 = int.Parse(s[2]);

            if (n2 > n3)
                Console.WriteLine("-1");
            else
            {
                long count = 1, income = 0, cost = 0;

                do
                {
                    income = n3 * count;
                    cost = n + n2 * count;
                    count++;
                }
                while (income < cost);

                Console.WriteLine(count);
            }
        }
    }
}
