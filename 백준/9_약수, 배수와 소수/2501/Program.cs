using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2501
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int n = int.Parse(s[0]), k = int.Parse(s[1]);
            int[] arr = new int[n];
            int index = 0;

            for(int i = 1; i < n; i++)
            {
                if (n % i == 0)
                    arr[index++] = i;
            }

            Console.WriteLine(arr[k - 1]);
        }
    }
}
