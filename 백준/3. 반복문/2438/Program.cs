using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2438
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string star = string.Empty;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                    star += "*";

                star += "\n";
            }

            Console.WriteLine(star);
        }
    }
}
