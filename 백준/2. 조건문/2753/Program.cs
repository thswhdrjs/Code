using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2753
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int n = int.Parse(s);

            if (n % 4 == 0 && (n % 100 != 0 || n % 400 == 0))
                Console.WriteLine("1");
            else
                Console.WriteLine("0");
        }
    }
}
