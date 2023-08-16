using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10870
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci(int.Parse(Console.ReadLine())));
        }

        static int Fibonacci(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
