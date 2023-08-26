using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18258
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var queue = new Queue<int>();

            var last = 0;
            var sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                var s = Console.ReadLine().Split(' ');

                if (s.Length > 1)
                {
                    last = int.Parse(s[1]);
                }

                switch (s[0])
                {
                    case "push":
                        {
                            queue.Enqueue(last);
                            break;
                        }
                    case "pop":
                        {
                            sb.AppendLine(queue.Count > 0 ? queue.Dequeue().ToString() : "-1");
                            break;
                        }
                    case "size":
                        {
                            sb.AppendLine(queue.Count.ToString());
                            break;
                        }
                    case "empty":
                        {
                            sb.AppendLine(queue.Count > 0 ? "0" : "1");
                            break;
                        }
                    case "front":
                        {
                            sb.AppendLine(queue.Count > 0 ? queue.Peek().ToString() : "-1");
                            break;
                        }
                    case "back":
                        {
                            sb.AppendLine(queue.Count > 0 ? last.ToString() : "-1");
                            break;
                        }
                }
            }

            Console.WriteLine(sb);
        }
    }
}
