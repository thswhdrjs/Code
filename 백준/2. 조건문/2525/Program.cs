using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2525
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int hour = int.Parse(s[0]), minute = int.Parse(s[1]), required = int.Parse(s[2]);

            int requiredTime = minute + required, calculateHour = requiredTime / 60;
            hour += calculateHour;
            minute = requiredTime % 60;

            if (hour + calculateHour > 23)
                hour -= 24;

            Console.WriteLine(string.Format("{0} {1}", hour, minute));
        }
    }
}
