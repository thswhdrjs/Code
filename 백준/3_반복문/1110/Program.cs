using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1110
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int origin = n;

            while (true)
            {
                int sum = 0;
                int tens = 0;
                int units = n % 10;

                if (n > 9)
                    tens = n / 10;

                sum = units + tens;
                sum = units * 10 + sum % 10;
                n = sum;
                count++;

                if (sum == origin)
                    break;
            }

            Console.WriteLine(count);
        }
    }
}
