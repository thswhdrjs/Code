using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2903
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 2;

            for(int i = 0; i < n; i++)
            {
                sum = sum * 2 - 1;
            }

            Console.WriteLine((int)Math.Pow(sum, 2));
        }
    }
}
