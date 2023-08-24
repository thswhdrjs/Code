using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1735
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse), arr2 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int dMultiple = 0;
            int i = arr[1], j = arr2[1];

            while (j > 0)
            {
                int temp = i;
                i = j;
                j = temp % j;
            }

            dMultiple = arr[1] * arr2[1] / i;
            int[] modify = new int[2] { arr2[1] / i, arr[1] / i };
            int numerator = arr[0] * modify[0] + arr2[0] * modify[1];

            i = numerator;
            j = dMultiple;

            while (j > 0)
            {
                int temp = i;
                i = j;
                j = temp % j;
            }

            if (i > 1)
            {
                numerator /= i;
                dMultiple /= i;
            }

            Console.WriteLine(numerator + " " + dMultiple);
        }
    }
}
