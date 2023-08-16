using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1065
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            if (n <= 100)
                count = n;
            else if (n <= 999)
            {
                int[] arr = new int[3];
                count = 99;

                for (int i = 101; i <= n; i++)
                {
                    int temp = i;

                    for (int j = 0; j < 3; j++)
                    {
                        arr[j] = temp % 10;

                        if (temp != 0)
                            temp /= 10;
                    }

                    if (arr[2] - arr[1] == arr[1] - arr[0])
                        count++;
                }
            }
            else
                count = 144;

            Console.WriteLine(count);
        }
    }
}
