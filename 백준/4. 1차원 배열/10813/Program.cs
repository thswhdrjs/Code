using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10813
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] t = Console.ReadLine().Split(' ');
            int n = int.Parse(t[0]), m = int.Parse(t[1]);
            int[] arr = new int[n + 1];
            
            for(int i = 1; i< n + 1; i++)
            {
                arr[i] = i;
            }

            for(int i = 0; i < m; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                int tmp = arr[int.Parse(s[0])];
                arr[int.Parse(s[0])] = arr[int.Parse(s[1])];
                arr[int.Parse(s[1])] = tmp;
            }

            for(int i = 1; i < n + 1; i++)
                Console.Write(arr[i]);
        }
    }
}
