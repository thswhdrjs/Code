using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1004
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for(int i = 0; i < t; i++)
            {
                string[] coor = Console.ReadLine().Split(' ');
                int n = int.Parse(Console.ReadLine());
                int[][] planet = new int[n][];

                for (int j = 0; j < n; j++)
                {
                    string[] s = Console.ReadLine().Split(' ');
                    planet[j] = new int[] { int.Parse(s[0]), int.Parse(s[1]), int.Parse(s[2]) };
                }

                int count = 0;
                bool in1 = false, in2 = false;

                for (int j = 0; j < planet.Length; j++)
                {
                    in1 = Math.Pow(planet[j][0] - int.Parse(coor[0]), 2) + Math.Pow(planet[j][1] - int.Parse(coor[1]), 2) > Math.Pow(planet[j][2], 2) ? true : false;
                    in2 = Math.Pow(planet[j][0] - int.Parse(coor[2]), 2) + Math.Pow(planet[j][1] - int.Parse(coor[3]), 2) > Math.Pow(planet[j][2], 2) ? true : false;

                    if (in1 != in2)
                        count++;
                }

                Console.WriteLine(count);
            }
        }
    }
}
