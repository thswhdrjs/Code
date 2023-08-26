using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12789
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Stack<int> stack = new Stack<int>();
            int order = 1;

            foreach (int temp in arr)
            {
                if (temp == order)
                {
                    order++;
                }
                else
                    stack.Push(temp);

                while (stack.Count > 0)
                {
                    if (stack.Peek() != order)
                        break;

                    stack.Pop();
                    order++;
                }
            }

            Console.WriteLine(order == n + 1 ? "Nice" : "Sad");
        }
    }
}
