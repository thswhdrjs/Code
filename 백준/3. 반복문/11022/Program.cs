using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11022
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

                Console.WriteLine(string.Format("Case #1: {0} + {1} = {2}", n, n2, n + n2));
            }
        }
    }
}
