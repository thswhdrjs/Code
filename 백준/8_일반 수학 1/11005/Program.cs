using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11005
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int n = int.Parse(s[0]), b = int.Parse(s[1]);

            string str = string.Empty;
            string output = string.Empty;

            while (n > 0)
            {
                int temp = n % b;
                n /= b;

                if (temp > 9)
                {
                    temp += 55;
                    str += (char)temp;
                }
                else
                    str += temp;
            }

            for (int i = str.Length - 1; i > -1; i--)
                output += str[i];

            Console.WriteLine(output);
        }
    }
}
