using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2562
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[9];
            int[] tempArr = new int[9];
            
            for(int i = 0; i < 9; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Copy(arr, tempArr, 9);
            Array.Sort(arr, (a, b) => a > b ? -1 : 1);

            for (int i = 0; i < 9; i++)
            {
                if (tempArr[i] == arr[0])
                {
                    Console.WriteLine(arr[0]);
                    Console.WriteLine(i + 1);
                    break;
                }
            }
        }
    }
}
