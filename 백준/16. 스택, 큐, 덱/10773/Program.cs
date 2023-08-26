using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10773
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();

            int sum = 0;

            for(int i = 0; i < k; i++)
            {
                int n = int.Parse(Console.ReadLine());

                if (n == 0)
                    stack.Pop();
                else
                    stack.Push(n);
            }

            foreach(int temp in stack)
            {
                sum += temp;
            }

            Console.WriteLine(sum);
        }
    }
}
