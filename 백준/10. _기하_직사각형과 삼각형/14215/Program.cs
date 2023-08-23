using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14215
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int[] n = new int[s.Length];

            for (int i = 0; i < n.Length; i++)
                n[i] = int.Parse(s[i]);

            Array.Sort(n);

            if(n[0] + n[1] > n[2])
                Console.WriteLine(n[0] + n[1] + n[2]);
            else
                Console.WriteLine(n[0] * 2 + n[1] * 2 - 1);
        }
    }
}
