using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25304
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = int.Parse(Console.ReadLine());
            int t = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < t; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                sum += int.Parse(s[0]) * int.Parse(s[1]);
            }
                
            Console.WriteLine(total == sum ? "Yes" : "No");
        }
    }
}
