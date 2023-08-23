using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4344
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = int.Parse(Console.ReadLine());

            for(int i = 0; i < c; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                float average = 0f;
                int count = 0;

                for (int j = 1; j < s.Length; j++)
                {
                    average += int.Parse(s[j]);
                }

                average /= int.Parse(s[0]);

                for(int j = 1; j < s.Length; j++)
                {
                    if (int.Parse(s[j]) > average)
                        count++;
                }

                float percent = count / float.Parse(s[0]) * 100f;
                Console.WriteLine(string.Format("{0:0.000}%", percent));
            }
        }
    }
}
