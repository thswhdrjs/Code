﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10250
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < t; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                int n = int.Parse(s[0]), n2 = int.Parse(s[1]), n3 = int.Parse(s[2]);
                int floor = n3 % n;
                int nRoom = n3 / n + 1;

                if (nRoom < 10)
                    Console.WriteLine(floor + "0" + nRoom);
                else
                    Console.WriteLine(floor + "" + nRoom);
            }
            
        }
    }
}
