using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1193
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int level = 1;
            int temp = 1;

            while (temp < n)
            {
                level++;
                temp = temp + level;
            }

            int den = temp - (int)n + 1;

            if (level % 2 == 0)
                Console.WriteLine((level + 1 - den) + "/" + den);
            else
                Console.WriteLine(den + "/" + (level + 1 - den));
        }
    }
}
