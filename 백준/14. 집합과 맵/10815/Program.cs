using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10815
{
    class Program
    {
        static void Main(string[] args)
        {
            // HashSet
            int n = int.Parse(Console.ReadLine());
            HashSet<string> arr = new HashSet<string>();
            string[] nArr = Console.ReadLine().Split(' ');

            foreach (string temp in nArr)
            {
                arr.Add(temp);
            }

            int m = int.Parse(Console.ReadLine());
            string[] mArr = Console.ReadLine().Split(' ');

            StringBuilder output = new StringBuilder();

            foreach (string temp in mArr)
            {
                output.Append(arr.Contains(temp) ? "1 " : "0 ");
            }

            Console.WriteLine(output);

            //// 이분트리
            //int n = int.Parse(Console.ReadLine());
            //int[] nArr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            //Array.Sort(nArr);

            //int m = int.Parse(Console.ReadLine());
            //int[] mArr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            //StringBuilder output = new StringBuilder();

            //for(int i = 0; i < m; i++)
            //{
            //    output.Append(Binary(nArr, mArr[i]) + " ");
            //}

            //Console.WriteLine(output);
        }

        static int Binary(int[] arr, int compare)
        {
            int i = 0, j = arr.Length - 1;
            int mid = 0;

            while (i <= j)
            {
                mid = (i + j) / 2;

                if (arr[mid] == compare)
                {
                    return 1;
                }
                else if (arr[mid] > compare)
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
