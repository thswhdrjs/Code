using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10818
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int[] arr = new int[t];

            string[] s = Console.ReadLine().Split(' ');

            for(int i = 0; i < t; i++)
            {
                arr[i] = int.Parse(s[i]);
            }

            Array.Sort(arr);
            Console.WriteLine(string.Format("{0} {1}", arr[0], arr[t - 1]));
        }
    }
}
