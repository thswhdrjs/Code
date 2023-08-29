using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11866
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            var q = new Queue<int>();

            for (int i = 1; i <= arr[0]; i++)
            {
                q.Enqueue(i);
            }

            var sb = new StringBuilder();
            sb.Append("<");

            while(q.Count > 0)
            {
                int index = 0, targetIndex = arr[1];
                var tempQ = new Queue<int>(q);

                while (index < targetIndex)
                {
                    index++;
                    int dequeue = q.Dequeue();

                    if (index == targetIndex)
                    {
                        sb.Append(dequeue + (q.Count == 0 ? "" : ", "));
                        break;
                    }
                    else
                    {
                        q.Enqueue(dequeue);
                    }
                }
            }

            sb.Append(">");
            Console.WriteLine(sb);
        }
    }
}
