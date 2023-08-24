using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2485
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var arr = new int[n];

            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            var arr2 = new int[n - 1];

            for(int i = arr2.Length - 1; i > -1; i--)
            {
                arr2[i] = arr[i + 1] - arr[i];
            }

            Array.Sort(arr2);

            int gcd = GetGCD(arr2[0], arr2[1]);

            for(int i = 2; i < arr2.Length; i++)
            {
                gcd = GetGCD(gcd, arr2[i]);
            }

            int count = 0;

            foreach(int temp in arr2)
            {
                if (temp == gcd)
                    continue;

                count += temp / gcd - 1;
            }

            Console.WriteLine(count);
        }
        
        static int GetGCD(int a, int b)
        {
            int start = a, end = b;

            while (end > 0)
            {
                int temp = start;
                start = end;
                end = temp % end;
            }

            return start;
        }
    }
}
