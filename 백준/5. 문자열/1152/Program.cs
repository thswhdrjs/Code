using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1152
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                    count++;
            }

            Console.WriteLine(count + 1);
        }
    }
}
