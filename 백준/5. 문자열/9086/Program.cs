using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9086
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for(int i = 0; i < t; i++)
            {
                string s = Console.ReadLine();
                Console.WriteLine(string.Format("{0}{1}", s[0], s[s.Length - 1]));
            }
        }
    }
}
