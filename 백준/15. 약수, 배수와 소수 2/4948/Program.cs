using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4948
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                int n = int.Parse(Console.ReadLine());

                if (n == 0)
                    return;

                int count = 0;

                for(int i = n + 1; i <= n * 2; i++)
                {
                    if(IsSelf(i))
                    {
                        count++;
                    }
                }

                Console.WriteLine(count);
            }
        }

        static bool IsSelf(int n)
        {
            for(int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
    }
}
