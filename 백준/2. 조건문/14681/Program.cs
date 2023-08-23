using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14681
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int n = int.Parse(s[0]), n2 = int.Parse(s[1]);

            if (n > 0)
            {
                if (n2 > 0)
                    Console.WriteLine("1");
                else
                    Console.WriteLine("4");
            }
            else
            {
                if (n2 > 0)
                    Console.WriteLine("2");
                else
                    Console.WriteLine("3");
            }
        }
    }
}
