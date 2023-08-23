using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25305
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int n = int.Parse(s[0]), k = int.Parse(s[1]);

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Array.Sort(arr);

            Console.WriteLine(arr[n - k]);
        }
    }
}
