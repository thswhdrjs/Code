using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4153
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                string[] s = Console.ReadLine().Split(' ');
                int n = int.Parse(s[0]), n2 = int.Parse(s[1]), n3 = int.Parse(s[2]);

                if (n == 0 && n2 == 0 && n3 == 0)
                    break;

                int max = GetMax(n, n2);
                max = GetMax(max, n3);

                if (max == n)
                    Console.WriteLine(IsRightTriangle(n2, n3, n) ? "Right" : "Wrong");
                else if (max == n2)
                    Console.WriteLine(IsRightTriangle(n, n3, n2) ? "Right" : "Wrong");
                else
                    Console.WriteLine(IsRightTriangle(n, n2, n3) ? "Right" : "Wrong");
            }
        }

        static int GetMax(int n, int n2)
        {
            return n > n2 ? n : n2;
        }

        static bool IsRightTriangle(int n, int n2, int n3)
        {
            return Math.Pow(n3, 2) == Math.Pow(n, 2) + Math.Pow(n2, 2);
        }
    }
}
