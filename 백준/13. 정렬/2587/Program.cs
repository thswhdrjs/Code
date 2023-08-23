using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2587
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                sum += arr[i];
            }

            Array.Sort(arr);
            Console.WriteLine(sum / 5 + " " + arr[2]);
        }
    }
}
