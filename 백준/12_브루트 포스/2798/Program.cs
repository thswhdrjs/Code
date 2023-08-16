using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2798
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            string[] strM = Console.ReadLine().Split(' ');
            int[] num = new int[int.Parse(s[0])];
            int m = int.Parse(s[1]);

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(strM[i]);
            }

            Array.Sort(num);
            Array.Reverse(num);
            int sum = 0;

            for (int i = 0; i < num.Length - 2; i++)
            {
                for (int j = 0; j < num.Length - 1; j++)
                {
                    if (i == j)
                        continue;

                    for (int k = 0; k < num.Length; k++)
                    {
                        if (i == k || j == k)
                            continue;

                        int sum2 = num[i] + num[j] + num[k];

                        if (sum2 > m)
                            continue;

                        if (sum < sum2)
                            sum = sum2;
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
