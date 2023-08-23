using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10430
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int n = int.Parse(s[0]), n2 = int.Parse(s[1]), n3 = int.Parse(s[2]);

            Console.WriteLine((n + n2) % n3);
            Console.WriteLine(n % n3 + n2 % n3 % n3);
            Console.WriteLine(n * n2 % n3);
            Console.WriteLine((n % n3) * (n2 % n3) % n3);
        }
    }
}
