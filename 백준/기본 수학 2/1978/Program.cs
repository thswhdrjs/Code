using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1978
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Split(' ');
            int[] arr = new int[n];

            for(int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(s[i]);
            }

            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 1)
                    continue;
                else
                {
                    for (int j = 2; j * j < arr[i]; j++)
                    {
                        if (arr[i] % i == 0)
                            continue;
                    }
                }

                count++;
            }

            Console.WriteLine(count);
        }
    }
}
