using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1764
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split(' ');
            int n = int.Parse(s[0]), m = int.Parse(s[1]);

            var hash = new HashSet<string>(); 
            var list = new List<string>();

            for(int i = 0; i < n; i++)
            {
                hash.Add(Console.ReadLine());
            }

            for (int i = 0; i < m; i++)
            {
                list.Add(Console.ReadLine());
            }

            list = list.OrderBy(name => name).ToList();

            var output = new StringBuilder();
            var count = 0;

            for (int i = 0; i < m; i++)
            {
                if(hash.Contains(list[i]))
                {
                    count++;
                    output.Append(list[i] + "\n");
                }
            }

            Console.WriteLine(count);
            Console.WriteLine(output);
        }
    }
}
