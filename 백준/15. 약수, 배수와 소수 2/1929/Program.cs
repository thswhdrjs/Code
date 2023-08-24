using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1929
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            var sb = new StringBuilder();

            for (int i = arr[0]; i <= arr[1]; i++)
            {
                if (i < 2)
                    continue;

                if (IsSelf(i))
                    sb.Append(i + "\n");
            }

            Console.WriteLine(sb);
        }

        static bool IsSelf(int n)
        {
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
    }
}
