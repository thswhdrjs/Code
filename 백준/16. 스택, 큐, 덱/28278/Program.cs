using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28278
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();

            var sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                var arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                switch (arr[0])
                {
                    case 1:
                        {
                            stack.Push(arr[1]);
                            break;
                        }
                    case 2:
                        {
                            sb.Append((stack.Count == 0 ? -1 : stack.Pop()) + "\n");
                            break;
                        }
                    case 3:
                        {
                            sb.Append(stack.Count + "\n");
                            break;
                        }
                    case 4:
                        {
                            sb.Append((stack.Count == 0 ? 1 : 0) + "\n");
                            break;
                        }
                    case 5:
                        {
                            sb.Append((stack.Count == 0 ? -1 : stack.Peek()) + "\n");
                            break;
                        }
                }
            }

            Console.WriteLine(sb);
        }
    }
}

