using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1934
{
    class Program
    {
        static void Main(string[] args)
        {
            // 유클리드 호제
            var t = int.Parse(Console.ReadLine());
            var sb = new StringBuilder();

            for (int i = 0; i < t; i++)
            {
                var arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                Array.Sort(arr);

                int start = arr[1], end = arr[0];

                while (end > 0)
                {
                    int temp = start;
                    start = end;
                    end = temp % end;
                }

                sb.Append(arr[0] * arr[1] / start + "\n");
            }

            Console.WriteLine(sb);

            // for
            //var t = int.Parse(Console.ReadLine());
            //var sb = new StringBuilder();
            
            //for(int i = 0; i < t; i ++)
            //{
            //    var arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            //    Array.Sort(arr);

            //    int lcm = 1, value = 2;

            //    while(value < arr[0] + 1)
            //    {
            //        if (arr[0] % value == 0 && arr[1] % value == 0)
            //        {
            //            arr[0] /= value;
            //            arr[1] /= value;
            //            lcm *= value;
            //        }
            //        else
            //        {
            //            value++;
            //        }
            //    }

            //    sb.Append(lcm * arr[0] * arr[1] + "\n");
            //}

            //Console.WriteLine(sb);
        }
    }
}
