using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10810
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] order = Console.ReadLine().Split(' ');
            int n = int.Parse(order[0]), m = int.Parse(order[1]);
            int[] arr = new int[n + 1];

            for(int i = 0; i < m; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                int tempI = int.Parse(s[0]), tempJ = int.Parse(s[1]), tempK = int.Parse(s[2]);

                for (int j = tempI; j <= tempJ; j++)
                {
                    arr[j] = tempK;
                }
            }
            
            for(int i = 1; i < arr.Length; i++)
                Console.Write(string.Format("{0} ",arr[i]));
        }
    }
}
