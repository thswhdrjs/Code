using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19532
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int x = 0, y = 0;

            for(int i = -999; i< 1000; i++)
            {
                for (int j = -999; j < 1000; j++)
                {
                    if (arr[0] * i + arr[1] * j == arr[2] && arr[3] * i + arr[4] * j == arr[5])
                    {
                        x = i;
                        y = j;
                        break;
                    }    
                }
            }

            Console.WriteLine(string.Format("{0} {1}", x, y));
        }
    }
}
