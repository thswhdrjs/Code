using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14425
{
    class Program
    {
        static void Main(string[] args)
        {
            // HashSet
            var s = Console.ReadLine().Split(' ');
            int n = int.Parse(s[0]), m = int.Parse(s[1]);

            var str = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                str.Add(Console.ReadLine());
            }

            var str2 = new HashSet<string>();
            int count = 0;

            for (int i = 0; i < m; i++)
            {
                if (str.Contains(Console.ReadLine()))
                    count++;
            }

            Console.WriteLine(count);

            // 이진트리
            //var s = Console.ReadLine().Split(' ');
            //int n = int.Parse(s[0]), m = int.Parse(s[1]);

            //var str = new string[n];

            //for (int i = 0; i < n; i++)
            //{
            //    str[i] = Console.ReadLine();
            //}

            //Array.Sort(str);

            //int count = 0;

            //for (int i = 0; i < m; i++)
            //{
            //    var compare = Console.ReadLine();
            //    count += Binary(str, compare);
            //}

            //Console.WriteLine(count);
        }

        static int Binary(string[] arr, string compare)
        {
            int i = 0, j = arr.Length - 1;
            int mid = 0;

            while(i <= j)
            {
                mid = (i + j) / 2;

                if(arr[mid].Equals(compare))
                {
                    return 1;
                }
                else if(arr[mid].CompareTo(compare) > 0)
                {
                    j = mid - 1;
                }
                else
                {
                    i = mid + 1;
                }
            }

            return 0;
        }
    }
}
