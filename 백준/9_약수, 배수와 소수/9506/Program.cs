using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9506
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                int n = int.Parse(Console.ReadLine());

                if (n == -1)
                    break;

                int[] arr = new int[n / 2];
                int index = 0, sum = 0;

                for(int i = 1; i <= arr.Length; i++)
                {
                    if (n % i == 0)
                    {
                        arr[index++] = i;
                        sum += i;
                    }
                }

                if(n == sum)
                {
                    sum = 0;

                    Console.Write(string.Format("{0} = ", n));
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (n == sum)
                            break;

                        sum += arr[i];
                        Console.Write(string.Format(n == sum ? "{0}" : "{0} + ", arr[i]));
                    }

                    Console.WriteLine();
                }
                else
                    Console.WriteLine(string.Format("{0} is not perfect.", n));
            }
        }
    }
}
