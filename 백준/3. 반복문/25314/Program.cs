using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25314
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string output = "int";

            for (int i = 0; i < n / 4; i++)
            {
                output = "long " + output;
            }

            Console.WriteLine(output);
        }
    }
}
