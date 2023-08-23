using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15552
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int[] sum = new int[t];
            
            for(int i = 0; i < t; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                sum[i] = int.Parse(s[0]) + int.Parse(s[1]);
            }

            for (int i = 0; i < t; i++)
                Console.WriteLine(sum[i]);
        }
    }
}
