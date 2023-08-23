using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2444
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int total = n * 2 - 1;
            
            for(int i = 1; i < n + 1; i++)
            {
                int point = i * 2 - 1;
                
                for (int j = 0; j < (total - point) / 2; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < point; j++)
                {
                    Console.Write("*");
                }

                for (int j = (total - point) / 2 + 1; j < total; j++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine("");
            }

            for (int i = n; i > 0; i--)
            {
                int point = i * 2 - 1;

                for (int j = 0; j < (total - point) / 2; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < point; j++)
                {
                    Console.Write("*");
                }

                for (int j = (total - point) / 2 + 1; j < total; j++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine("");
            }
        }
    }
}
