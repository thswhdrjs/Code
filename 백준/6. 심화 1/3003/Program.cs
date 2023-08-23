using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3003
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int[] arr = new int[s.Length];
            arr[0] = 1;
            arr[1] = 1;
            arr[2] = 2;
            arr[3] = 2;
            arr[4] = 2;
            arr[5] = 8;

            for (int i = 0; i < s.Length; i++)
            {
                Console.Write(string.Format("{0} ", arr[i] - int.Parse(s[i])));
            }
        }
    }
}
