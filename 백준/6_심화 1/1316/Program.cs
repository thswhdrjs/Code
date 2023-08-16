using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1316
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                bool[] letter = new bool[26];
                count++;

                for(int j = 0; j < s.Length; j++)
                {
                    if (j < s.Length - 1 && s[j].Equals(s[j + 1]))
                        continue;

                    if (letter[Convert.ToInt32(s[j]) - 97])
                    {
                        count--;
                        break;
                    }

                    letter[Convert.ToInt32(s[j]) - 97] = true;
                }
            }

            Console.WriteLine(count);
        }
    }
}
