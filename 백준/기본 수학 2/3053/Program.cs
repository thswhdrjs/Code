using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3053
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            decimal pie = 3.14159265359m;
            decimal euclidArea = (decimal)Math.Round(n * n * pie, 6);
            double taxiArea = Math.Round(n * n * 2d, 6);

            Console.WriteLine(string.Format("{0:F6}", euclidArea));
            Console.WriteLine(string.Format("{0:F6}", taxiArea));
        }
    }
}
