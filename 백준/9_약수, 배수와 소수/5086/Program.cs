using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5086
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                string[] s = Console.ReadLine().Split(' ');
                int n = int.Parse(s[0]), n2 = int.Parse(s[1]);

                if (n == 0 && n2 == 0)
                    break;

                if (n2 % n == 0)
                    Console.WriteLine("Factor");

                if (n % n2 == 0)
                    Console.WriteLine("Multiple");

                if (n2 % n != 0 && n % n2 != 0)
                    Console.WriteLine("Neither");
            }
        }
    }
}
