using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1085
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int x = int.Parse(s[0]), y = int.Parse(s[1]), w = int.Parse(s[2]), h = int.Parse(s[3]);

            int minDistance = x > y ? y : x;
            int distance = h - y > w - x ? w - x : h - y;

            Console.WriteLine(minDistance > distance ? distance : minDistance);
        }
    }
}
