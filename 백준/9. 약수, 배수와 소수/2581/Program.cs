using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2581
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine()), n = int.Parse(Console.ReadLine());
            int sum = 0, min = 0;

            for(int i = m; i <= n; i++)
            {
                if (i == 1)
                    continue;

                bool isSelf = true;

                for(int j = 2; j < i / 2 + 1; j++)
                {
                    if (i % j == 0)
                    {
                        isSelf = false;
                        break;
                    }
                }

                if(isSelf)
                {
                    sum += i;

                    if (min == 0)
                        min = i;
                }
            }

            if(sum == 0)
                Console.WriteLine(-1);
            else
            {
                Console.WriteLine(sum);
                Console.WriteLine(min);
            }
        }
    }
}
