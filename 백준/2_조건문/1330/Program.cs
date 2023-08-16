using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1330
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int n = int.Parse(s[0]), n2 = int.Parse(s[1]);

            if (n > n2)
                Console.WriteLine(">");
            else if (n < n2)
                Console.WriteLine("<");
            else
                Console.WriteLine("==");
        }
    }
}
