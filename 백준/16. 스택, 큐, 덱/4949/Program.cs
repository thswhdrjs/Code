using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4949
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                var s = Console.ReadLine();

                if (s.Equals("."))
                    break;

                var stack = new Stack<char>();
                bool isBalance = true;

                foreach (char temp in s)
                {
                    if (temp.Equals('(') || temp.Equals('['))
                    {
                        stack.Push(temp);
                    }
                    
                    if(temp.Equals(')') || temp.Equals(']'))
                    {
                        if (stack.Count == 0)
                        {
                            isBalance = false;
                            break;
                        }
                    }

                    if (temp.Equals(')'))
                    {
                        if (stack.Pop().Equals('['))
                        {
                            isBalance = false;
                            break;
                        }
                    }

                    if (temp.Equals(']'))
                    {
                        if (stack.Pop().Equals('('))
                        {
                            isBalance = false;
                            break;
                        }
                    }
                }

                Console.WriteLine(isBalance && stack.Count == 0 ? "yes" : "no");
            }
        }
    }
}
