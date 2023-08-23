using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1269
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split(' ');
            int a = int.Parse(s[0]), b = int.Parse(s[1]);

            HashSet<int> hash = new HashSet<int>(), hash2 = new HashSet<int>();
            int [] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse), arr2 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            for (int i = 0; i < a; i++)
            {
                hash.Add(arr[i]);
            }

            for (int i = 0; i < b; i++)
            {
                hash2.Add(arr2[i]);
            }

            int count = 0;

            foreach(int temp in arr)
            {
                if (!hash2.Contains(temp))
                {
                    count++;
                }
            }

            foreach (int temp in arr2)
            {
                if (!hash.Contains(temp))
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
