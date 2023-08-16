using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10872
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Factorial(n));
        }

        static int Factorial(int n)
        {
            if (n > 1)
                return n * Factorial(n - 1);
            else
                return 1;
        }
    }
}
