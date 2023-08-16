using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5622
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            int[] time = new int[s.Length];
            int sum = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int dial = 0;

                for (int j = 65; j < 91; j++)
                {
                    if (Convert.ToInt32(s[i]) == j)
                    {
                        int count = 1;

                        for (int k = 65; k < 91; k += 3)
                        {
                            count++;

                            if (k <= j && j < k + 3)
                            {
                                dial = count;
                                break;
                            }
                        }

                        time[i] = dial + 1;
                        break;
                    }
                }
            }

            for (int i = 0; i < time.Length; i++)
                sum += time[i];

            Console.WriteLine(sum);
        }
    }
}
