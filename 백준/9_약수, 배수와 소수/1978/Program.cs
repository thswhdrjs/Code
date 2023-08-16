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
            int[] arr = new int[s.Length];

            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(s[i]);
            }

            int count = 0;

            foreach (int num in arr)
            {
                if (num == 1)
                    continue;

                if (num < 4)
                {
                    count++;
                    continue;
                }

                bool isSelf = true;

                for(int i = 2; i < num / 2 + 1; i++)
                {
                    if (num % i == 0)
                        isSelf = false;
                }

                if (isSelf)
                    count++;
            }

            Console.WriteLine(count);
        }
    }
}
