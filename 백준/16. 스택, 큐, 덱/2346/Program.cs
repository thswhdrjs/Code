using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2346
{
    class Program
    {
        static void Main(string[] args)
        {
            var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            var sb = new StringBuilder();

            var n = int.Parse(sr.ReadLine()) + 1;
            var inputArr = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

            var arr = new (int, int)[n];
            var isReamin = new bool[n];
            isReamin[0] = true;

            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = (i, inputArr[i - 1]);
            }            

            var value = arr[1];
            isReamin[value.Item1] = true;
            sb.Append(value.Item1);

            for (int i = 1; i < arr.Length - 1; i++)
            {
                int order = value.Item1;

                for (int j = 0; j < Math.Abs(value.Item2);)
                {
                    order = value.Item2> 0 ? ++order % n : (--order + n) % n;

                    if (isReamin[order])
                        continue;

                    j++;
                }                

                value = arr[order];
                isReamin[value.Item1] = true;
                sb.Append(" " + value.Item1);
            }

            sw.Write(sb);
            sw.Close();
        }
        
    }
}