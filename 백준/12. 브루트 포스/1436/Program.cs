using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1436
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 666;
            int count = 0;

            while (true)
            {
                if (num.ToString().Contains("666"))
                    count++;

                if (count == n)
                    break;

                num++;
            }

            Console.WriteLine(num);
        }
    }
}
