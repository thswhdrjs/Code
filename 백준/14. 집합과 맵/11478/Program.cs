using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11478
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            var hash = new HashSet<string>();

            for (int i = 0; i < s.Length; i++)
            {
                int index = 1;

                for (int j = i; j < s.Length; j++)
                {
                    var sb = new StringBuilder();
                    sb.Append(s.Substring(i, index++));

                    if (!hash.Contains(sb.ToString()))
                    {
                        hash.Add(sb.ToString());
                    }
                }
            }

            Console.WriteLine(hash.Count);
        }
    }
}
