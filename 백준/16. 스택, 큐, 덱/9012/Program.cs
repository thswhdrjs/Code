using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9012
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = int.Parse(Console.ReadLine());
            var sb = new StringBuilder();

            for(int i = 0; i < t; i++)
            {
                var stack = new Stack<int>();
                var s = Console.ReadLine();

                foreach (char temp in s)
                {
                    stack.Push(temp.Equals('(') ? 1 : -1);
                }

                int sum = 0;

                foreach(int temp in stack)
                {
                    sum += temp;

                    if (sum > 0)
                    {
                        break;
                    }
                }

                sb.Append((sum == 0 ? "YES" : "NO") + "\n");
            }

            Console.WriteLine(sb);
        }
    }
}
