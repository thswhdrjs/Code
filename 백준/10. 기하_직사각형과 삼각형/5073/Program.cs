using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5073
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                string[] s = Console.ReadLine().Split(' ');
                int[] n = new int[s.Length];

                for (int i = 0; i < n.Length; i++)
                    n[i] = int.Parse(s[i]);

                if (n[0] == 0 && n[1] == 0 && n[2] == 0)
                    break;

                Array.Sort(n);

                if (n[2] >= n[0] + n[1])
                    Console.WriteLine("Invalid");
                else 
                {
                    if (n[0] == n[1] && n[1] == n[2])
                        Console.WriteLine("Equilateral");
                    else if (n[0] != n[1] && n[0] != n[2] && n[1] != n[2])
                        Console.WriteLine("Scalene");
                    else
                        Console.WriteLine("Isosceles");
                }
            }
        }
    }
}
