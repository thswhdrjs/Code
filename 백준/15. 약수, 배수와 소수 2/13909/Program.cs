using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13909
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var count = 0;

            for(int i = 1; i * i <= n; i++)
            {
                count++;
            }

            Console.WriteLine(count);
        }
    }
}