using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2164
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var queue = new Queue<int>();

            for(int i = 1; i <= n; i++)
            {
                queue.Enqueue(i);
            }
            
            while (queue.Count > 1)
            {
                queue.Dequeue();

                if (queue.Count == 1)
                    break;

                queue.Enqueue(queue.Dequeue());
            }

            Console.WriteLine(queue.Peek());
        }
    }
}
