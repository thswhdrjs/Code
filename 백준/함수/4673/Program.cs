using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4673
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] isSelfNumber = new bool[10001];
            int[] selfNumber = new int[10001];

            for (int i = 0; i < selfNumber.Length; i++)
            {
                if (GetSelfNumber(i) < 10001)
                    isSelfNumber[GetSelfNumber(i)] = true;
            }

            for (int i = 0; i < isSelfNumber.Length; i++)
            {
                if (!isSelfNumber[i])
                    Console.WriteLine(i);
            }
        }

        static int GetSelfNumber(int n)
        {
            int sum = n;

            while (true)
            {
                if (n == 0)
                    break;

                sum += n % 10;
                n = n / 10;
            }

            return sum;
        }
    }
}
