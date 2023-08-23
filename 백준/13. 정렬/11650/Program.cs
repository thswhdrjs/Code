using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11650
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] num = new int[n][];

            for(int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                num[i] = new int[] { int.Parse(s[0]), int.Parse(s[1]) };
            }

            Array.Sort(num, (a, b) =>
            {
                if (a[0] == b[0])
                    return a[1] - b[1];
                else
                    return a[0] - b[0];
            });

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(string.Format("{0} {1}", num[i][0], num[i][1]));
            }
        }
    }
}
