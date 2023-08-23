using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2566
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] value = new int[3];

            for(int i = 0; i < 9; i++)
            {
                string[] s = Console.ReadLine().Split(' ');

                for(int j = 0; j < 9; j++)
                {
                    if(value[2] < int.Parse(s[j]))
                    {
                        value[0] = i + 1;
                        value[1] = j + 1; 
                        value[2] = int.Parse(s[j]);
                    }
                }
            }

            Console.WriteLine(value[2]);
            Console.Write(string.Format("{0} {1}", value[0], value[1]));
        }
    }
}
