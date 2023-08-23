using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2292
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int length = 0;
            int sixMultiple = 0;

            while (sixMultiple < n)
            {
                length++;
                sixMultiple += 6 * length;
            }

            length += 1;
            Console.WriteLine(length);
        }
    }
}
