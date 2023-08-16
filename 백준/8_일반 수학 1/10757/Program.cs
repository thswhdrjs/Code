using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10757
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            string plusStr = string.Empty;
            bool isPlus = false;

            for(int i = s[0].Length - 1; i > -1; i--)
            {
                int plus = int.Parse(s[0][i].ToString()) + int.Parse(s[1][i].ToString()) + (isPlus ? 1 : 0);

                if (i > 0 && plus > 9)
                {
                    plus -= 10;
                    isPlus = true;
                }
                else
                    isPlus = false;

                plusStr = plus + plusStr;
            }

            Console.WriteLine(plusStr);
        }
    }
}
