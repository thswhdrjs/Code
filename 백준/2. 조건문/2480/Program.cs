using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2480
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int n = int.Parse(s[0]), n2 = int.Parse(s[1]), n3 = int.Parse(s[2]);
            int same = 0, sameScore = 0;

            if (n == n2)
            {
                same += 1;
                sameScore = n;
            }

            if (n == n3)
            {
                same += 1;
                sameScore = n;
            }

            if (n2 == n3)
            {
                same += 1;
                sameScore = n2;
            }

            switch (same)
            {
                case 0:
                    {
                        Console.WriteLine(100 * Math.Max(n, Math.Max(n2, n3)));
                        break;
                    }
                default:
                    {
                        Console.WriteLine(1000 + sameScore * 100);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine(10000 + sameScore * 1000);
                        break;
                    }
            }

        }
    }
}
