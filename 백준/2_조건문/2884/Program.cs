using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2884
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int h = int.Parse(s[0]), m = int.Parse(s[1]);

            m -= 45;

            if (m < 0)
            {
                m = 60 - Math.Abs(m);
                h -= 1;

                if (h < 0)
                    h = 23;
            }

            Console.WriteLine(string.Format("{0} {1}", h, m));
        }
    }
}
