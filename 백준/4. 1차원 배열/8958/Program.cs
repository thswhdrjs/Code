using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8958
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for(int i = 0; i < t; i++)
            {
                string s = Console.ReadLine();
                int sum = 0, score = 0;

                foreach (char c in s)
                {
                    if (c.Equals('O'))
                    {
                        score++;
                        sum += score;
                    }
                    else
                        score = 0;
                }

                Console.WriteLine(sum);
            }
        }
    }
}
