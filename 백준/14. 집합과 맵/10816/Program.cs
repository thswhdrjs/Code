using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10816
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> dic = new Dictionary<int, int>();

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            foreach(int temp in arr)
            {
                if (dic.ContainsKey(temp))
                    dic[temp]++;
                else
                    dic.Add(temp, 1);
            }

            int m = int.Parse(Console.ReadLine());
            int[] arr2 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            StringBuilder sb = new StringBuilder();

            foreach(int temp in arr2)
            {
                if (dic.ContainsKey(temp))
                    sb.Append(dic[temp] + " ");
                else
                    sb.Append(0 + " ");
            }
            
            Console.WriteLine(sb);
        }
    }
}
