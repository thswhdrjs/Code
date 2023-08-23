using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10809
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int?[] alphabet = new int?[26];
            string output = "";


            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 97; j < 123; j++)
                {
                    if (Convert.ToInt32(s[i]) == j && alphabet[j - 97] == null)
                        alphabet[j - 97] = i;
                }
            }

            for (int i = 0; i < alphabet.Length; i++)
            {
                if (alphabet[i] == null)
                    alphabet[i] = -1;

                output += alphabet[i];
                output += " ";
            }

            Console.WriteLine(output);
        }
    }
}
