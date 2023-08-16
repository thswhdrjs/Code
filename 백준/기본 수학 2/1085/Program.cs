using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1085
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int n = int.Parse(s[0]), n2 = int.Parse(s[1]), n3 = int.Parse(s[2]), n4 = int.Parse(s[3]);

            int min = 1000;
            int[] condition = new int[4];
            condition[0] = n;
            condition[1] = n2;
            condition[2] = n3 - n;
            condition[3] = n4 - n2;

            for (int i = 0; i < 4; i++)
            {
                if (condition[i] < min)
                    min = condition[i];
            }

            Console.WriteLine(min);
        }
    }
}
