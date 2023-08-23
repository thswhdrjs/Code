using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10798
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = new string[5];

            for(int i = 0; i < 5; i++)
            {
                str[i] = Console.ReadLine();
            }

            int index, index2;

            for (index = 0; ; )
            {
                if (index == 15)
                    break;

                for (index2 = 0; index2 < str.Length; index2++)
                {
                    if (index > str[index2].Length - 1)
                        continue;
                    
                    Console.Write(str[index2][index]);
                }

                index++;
            }
        }
    }
}
