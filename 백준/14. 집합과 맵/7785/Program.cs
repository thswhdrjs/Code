using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7785
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<(string, bool)> hash = new HashSet<(string, bool)>();
            
            for(int i = 0; i < n; i ++)
            {
                var s = Console.ReadLine().Split(' ');

                if (s[1].Equals("enter"))
                    hash.Add((s[0], true));
                else
                    hash.Remove((s[0], true));
            }

            hash = hash.OrderByDescending(i => i.Item1).ToHashSet();

            StringBuilder output = new StringBuilder();

            foreach((string, bool) temp in hash)
            {
                output.Append(temp.Item1 + "\n");
            }

            Console.WriteLine(output);
        }
    }
}
