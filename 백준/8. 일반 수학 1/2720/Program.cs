using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2720
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                int change = int.Parse(Console.ReadLine());
                
                int quater = change / 25;
                change -= quater * 25;
                
                int dime = change / 10;
                change -= dime * 10;
                
                int nickel = change / 5;
                change -= nickel * 5;
                
                int penny = change / 1;
                
                Console.WriteLine(string.Format("{0} {1} {2} {3}", quater, dime, nickel, penny));
            }
        }
    }
}
