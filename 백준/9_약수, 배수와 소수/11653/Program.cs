using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11653
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n / 2];
            int index = 0, value = 2;

            while (n > 1)
            {
                if (n % value == 0)
                {
                    arr[index++] = value;
                    n /= value;
                }
                else
                    value++;
            }

            foreach (int num in arr)
            {
                if (num == 0)
                    break;

                Console.WriteLine(num);
            }
        }
    }
}
