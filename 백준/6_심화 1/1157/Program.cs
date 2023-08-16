using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1157
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int[] capitalLetter = new int[26];
            int[] smallLetter = new int[26];

            int[] capitalMax = new int[3];
            int[] smallMax = new int[3];

            capitalLetter = GetLetter(s, 65, 91);
            smallLetter = GetLetter(s, 97, 123);

            capitalMax = GetMaxValue(capitalLetter);
            smallMax = GetMaxValue(smallLetter);

            if (capitalMax[0] > smallMax[0] || capitalMax[0] == smallMax[0])
                Output(capitalMax);
            else
                Output(smallMax);
        }

        static int[] GetLetter(string s, int startAscii, int endAscii)
        {
            int[] letter = new int[26];

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = startAscii; j < endAscii; j++)
                {
                    if (Convert.ToInt32(s[i]) == j)
                        letter[j - startAscii]++;
                }
            }

            return letter;
        }

        static int[] GetMaxValue(int[] letter)
        {
            int[] max = new int[3];

            for (int i = 0; i < letter.Length; i++)
            {
                if (max[0] < letter[i])
                {
                    max[0] = letter[i];
                    max[1] = i;
                    max[2] = 1;
                }
                else if (max[0] == letter[i])
                    max[2]++;
            }

            return max;
        }

        static void Output(int[] maxValue)
        {

            if (maxValue[2] > 1)
                Console.WriteLine("?");
            else
                Console.WriteLine(Convert.ToChar(maxValue[1] + 65));
        }
    }
}
