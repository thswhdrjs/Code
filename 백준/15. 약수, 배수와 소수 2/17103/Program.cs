using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17103
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            var hash = new HashSet<int>();

            for (int j = 2; j < 1000000; j++)
            {
                if (IsSelf(j))
                    hash.Add(j);
            }

            for (int i = 0; i < t; i++)
            {
                var count = 0;
                var n = int.Parse(Console.ReadLine());

                foreach (int temp in hash)
                {
                    if (temp > n / 2)
                        break;

                    if (hash.Contains(n - temp))
                        count++;
                }

                Console.WriteLine(count);
            }
        }

        static bool IsSelf(int n)
        {
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
    }
}
