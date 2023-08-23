using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2439
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string star = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j > i; j--)
                    star += (" ");

                for (int k = 0; i > k; k++)
                    star += ("*");

                star += ("\n");
            }

            Console.WriteLine(star);
        }
    }
}
