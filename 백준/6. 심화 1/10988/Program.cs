using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10988
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char[] arr = new char[s.Length], tempArr = new char[s.Length];
            bool isPalindrome = true;

            for (int i = 0; i < s.Length; i++)
            {
                arr[i] = s[i];
                tempArr[i] = s[i];
            }

            Array.Reverse(tempArr);

            for(int i = 0; i < s.Length; i++)
            {
                if(!arr[i].Equals(tempArr[i]))
                {
                    isPalindrome = false;
                    break;
                }
            }

            Console.WriteLine(isPalindrome ? 1 : 0);
        }
    }
}
