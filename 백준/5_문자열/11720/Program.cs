using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11720
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();

            int[] arr = new int[n];
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
                arr[i] = (int)Char.GetNumericValue(s[i]);

            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];

            Console.WriteLine(sum);
        }
    }
}
