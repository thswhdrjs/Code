using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11729
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Pow(2, n) - 1);
            Hanoi(n, 1, 3, 2);
        }

        static void Hanoi(int n, int start, int to, int via)
        {
            if (n == 1)
            {
                Console.WriteLine(string.Format("{0} {1}", start, to, n));
                return;
            }

            Hanoi(n - 1, start, via, to);
            Console.WriteLine(string.Format("{0} {1}", start, to, n));
            Hanoi(n - 1, via, to, start);
        }
    }
}
