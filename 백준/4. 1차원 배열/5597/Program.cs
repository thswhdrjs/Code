using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5597
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[31];
            int count = 0;

            for(int i = 1; i < 29; i++)
            {
                number[int.Parse(Console.ReadLine())] = 1;
            }

            for(int i = 1; i < number.Length; i++)
            {
                if(number[i] == 0)
                {
                    count++;
                    Console.WriteLine(i);

                    if (count == 2)
                        break;
                }
            }
        }
    }
}
