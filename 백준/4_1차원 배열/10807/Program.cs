using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10807
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Split(' ');
            int v = int.Parse(Console.ReadLine());

            int count = 0;

            for(int i = 0; i < t; i++)
            {
                if (int.Parse(s[i]) == v)
                    count++;
            }

            Console.WriteLine(count);
        }
    }
}
