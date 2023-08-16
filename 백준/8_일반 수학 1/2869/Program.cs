using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2869
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            long n = long.Parse(s[0]), n2 = long.Parse(s[1]), n3 = long.Parse(s[2]);

            long day = 1;
            long height = n;

            while (height < n3)
            {
                height -= n2;
                day++;
                height += n;
            }

            Console.WriteLine(day);
        }
    }
}
