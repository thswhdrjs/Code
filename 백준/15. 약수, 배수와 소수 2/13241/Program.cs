using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13241
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
            Array.Sort(arr);

            long i = arr[0], j = arr[1];

            while(j > 0)
            {
                long temp = i;
                i = j;
                j = temp % j;
            }

            Console.WriteLine(arr[0] * arr[1] / i);
        }
    }
}
