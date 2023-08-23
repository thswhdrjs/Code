using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1620
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split(' ');
            int n = int.Parse(s[0]), m = int.Parse(s[1]);

            var dic = new Dictionary<string, int>();
            var list = new List<string>();
            
            for (int i = 0; i < n; i++)
            {
                string temp = Console.ReadLine();
                dic.Add(temp, i + 1);
                list.Add(temp);
            }

            var sb= new StringBuilder();

            for (int i = 0; i < m; i++)
            {
                var str = Console.ReadLine();

                if ((int)str[0] > 64)
                {
                    sb.Append(dic[str] + "\n");   
                }
                else
                {
                    sb.Append(list[int.Parse(str) - 1] + "\n");
                }
            }

            Console.WriteLine(sb);
        }
    }
}
