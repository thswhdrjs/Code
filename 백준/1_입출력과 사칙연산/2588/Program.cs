﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2588
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int n = int.Parse(s[0]), n2 = int.Parse(s[1]);

            Console.WriteLine(n * (n2 % 10));
            Console.WriteLine(n * (n2 / 10 % 10));
            Console.WriteLine(n * (n2 / 100));
            Console.WriteLine(n * n2);
        }
    }
}
