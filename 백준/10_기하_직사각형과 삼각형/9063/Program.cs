using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9063
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] x = new int[n], y = new int[n]; 

            for(int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                x[i] = int.Parse(s[0]);
                y[i] = int.Parse(s[1]);
            }

            Array.Sort(x);
            Array.Sort(y);

            int area = (x[n - 1] - x[0]) * (y[n - 1] - y[0]);
            Console.WriteLine(area);
        }
    }
}
