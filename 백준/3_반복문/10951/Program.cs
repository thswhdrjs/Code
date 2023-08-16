using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10951
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                string[] s = Console.ReadLine().Split(' ');
                Console.WriteLine(int.Parse(s[0]) + int.Parse(s[1]));
            }
        }
    }
}
