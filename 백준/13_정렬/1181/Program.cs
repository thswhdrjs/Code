using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1181
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] s = new string[n];

            for(int i = 0; i < n; i++)
            {
                s[i] = Console.ReadLine();
            }

            Array.Sort(s, (a, b) =>
            {
                if (a.Length == b.Length)
                {
                    int compare = 0;

                    for (int i = 0; i < a.Length; i++)
                    {
                        if (a[i] == b[i])
                            continue;

                        compare = Convert.ToInt32(a[i]) - Convert.ToInt32(b[i]);
                        break;
                    }

                    return compare;
                }
                else
                    return a.Length - b.Length;
            });

            for (int i = 0; i < s.Length; i++)
            {
                bool isExit = false;

                for (int j = 0; j < i; j++)
                {
                    if (s[i] == s[j])
                    {
                        isExit = true;
                        break;
                    }
                }

                if (isExit)
                    s[i] = "";
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != "")
                    Console.WriteLine(s[i]);
            }
        }
    }
}
