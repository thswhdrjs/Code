using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2675
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < t; i++)
            {
                string[] s = Console.ReadLine().Split(' ');

                for(int j = 0; j < s[1].Length; j++)
                {
                    for (int k = 0; k < int.Parse(s[0]); k++)
                        Console.Write(s[1][j]);
                }

                Console.WriteLine();
            }
        }
    }
}
