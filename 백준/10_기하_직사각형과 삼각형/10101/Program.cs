using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10101
{
    class Program
    {
        static void Main(string[] args)
        {
            int angle = int.Parse(Console.ReadLine()), angle2 = int.Parse(Console.ReadLine()), angle3 = int.Parse(Console.ReadLine());
            int sum = angle + angle2 + angle3;

            if (sum != 180)
                Console.WriteLine("Error");
            else
            {
                if(angle == angle2 && angle2 == angle3)
                    Console.WriteLine("Equilateral");
                else if(angle != angle2 && angle != angle3 && angle2 != angle3)
                    Console.WriteLine("Scalene");
                else
                    Console.WriteLine("Isosceles");
            }
        }
    }
}
