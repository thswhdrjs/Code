using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10871
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int n = int.Parse(s[0]), x = int.Parse(s[1]);

            string[] a = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                if (int.Parse(a[i]) < x)
                    Console.Write(string.Format("{0} ", int.Parse(a[i])));
            }
        }
    }
}
