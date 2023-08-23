using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1011
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < t; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                int n = int.Parse(s[0]), n2 = int.Parse(s[1]);

                int distance = n2 - n;
                int max = (int)Math.Sqrt(distance);

                if (Math.Sqrt(distance) - max == 0)
                    Console.WriteLine(max * 2 - 1);
                else if (distance <= max * max + max)
                    Console.WriteLine(max * 2);
                else
                    Console.WriteLine(max * 2 + 1);
            }
        }
    }
}
