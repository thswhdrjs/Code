using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2908
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]), n2 = int.Parse(input[1]);

            string s = n.ToString();
            string s2 = n2.ToString();

            string changeS = "";
            string changeS2 = "";

            if (!(99 < n && n < 1000) || !(99 < n2 && n2 < 1000) || Discrimination(s) || Discrimination(s2))
                return;

            changeS = Reverse(s);
            changeS2 = Reverse(s2);

            if (Convert.ToInt32(changeS) > Convert.ToInt32(changeS2))
                Console.WriteLine(changeS);
            else
                Console.WriteLine(changeS2);
        }

        static bool Discrimination(string s)
        {
            bool check = false;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Equals("0"))
                    check = true;
            }

            return check;
        }

        static string Reverse(string s)
        {
            string reverse = "";

            for (int i = s.Length - 1; i >= 0; i--)
                reverse += s[i].ToString();

            return reverse;
        }
    }
}
