using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3052
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            for(int i = 0; i < 10; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
                
            int[] num = new int[42];
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (num[arr[i] % 42] == 0)
                    num[arr[i] % 42]++;
            }

            for (int i = 0; i < num.Length; i++)
                sum += num[i];

            Console.WriteLine(sum);
        }
    }
}
