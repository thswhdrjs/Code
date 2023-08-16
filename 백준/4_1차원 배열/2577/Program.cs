using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2577
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()), n2 = int.Parse(Console.ReadLine()), n3 = int.Parse(Console.ReadLine());

            int digit = 0;
            int multiplication = n * n2 * n3;

            for (int i = 8; i < 11; i++)
            {
                if (multiplication / (int)Math.Pow(10, i) == 0)
                {
                    digit = i;
                    break;
                }
            }

            int[] num = new int[10];
            int[] arr = new int[digit];
            arr[0] = multiplication / (int)Math.Pow(10, digit);

            for (int i = 1; i < arr.Length; i++)
                arr[i] = multiplication / (int)Math.Pow(10, digit - i) % 10;

            for (int i = 0; i < arr.Length; i++)
            {
                switch (arr[i])
                {
                    case 0:
                        {
                            num[0]++;
                            break;
                        }
                    case 1:
                        {
                            num[1]++;
                            break;
                        }
                    case 2:
                        {
                            num[2]++;
                            break;
                        }
                    case 3:
                        {
                            num[3]++;
                            break;
                        }
                    case 4:
                        {
                            num[4]++;
                            break;
                        }
                    case 5:
                        {
                            num[5]++;
                            break;
                        }
                    case 6:
                        {
                            num[6]++;
                            break;
                        }
                    case 7:
                        {
                            num[7]++;
                            break;
                        }
                    case 8:
                        {
                            num[8]++;
                            break;
                        }
                    case 9:
                        {
                            num[9]++;
                            break;
                        }
                }
            }

            for (int i = 0; i < num.Length; i++)
                Console.WriteLine(num[i]);
        }
    }
}
