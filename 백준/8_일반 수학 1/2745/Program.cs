using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2745
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int b = int.Parse(s[1]);
            double sum = 0;

            for(int i = 0; i < s[0].Length; i++)
            {
                int askii = Convert.ToInt32(s[0][i]);
                int value = (64 < askii && askii < 91) ? (askii - 55) : (int.Parse(s[0][i].ToString()));

                sum += value * Math.Pow(b, s[0].Length - i - 1);
            }

            Console.WriteLine(sum);
        }
    }
}
