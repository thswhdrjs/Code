using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7568
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] physical = new int[n, 2];

            for(int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                physical[i, 0] = int.Parse(s[0]);
                physical[i, 1] = int.Parse(s[1]);
            }

            int[,] ranking = new int[physical.GetLength(0), 2];
            int[] order = new int[physical.GetLength(0)];

            for (int i = 0; i < physical.GetLength(0); i++)
            {
                int weightOrder = 0;
                int heightOrder = 0;

                for (int j = 0; j < physical.GetLength(0); j++)
                {
                    if (i == j)
                        continue;

                    for (int k = 0; k < 2; k++)
                    {
                        if (physical[i, k] < physical[j, k])
                        {
                            if (k == 0)
                                weightOrder++;
                            else
                                heightOrder++;
                        }
                    }
                }

                ranking[i, 0] = ++weightOrder;
                ranking[i, 1] = ++heightOrder;
            }

            for (int i = 0; i < physical.GetLength(0); i++)
            {
                int currOrder = 0;

                for (int j = 0; j < physical.GetLength(0); j++)
                {
                    if (i == j)
                        continue;

                    if (ranking[i, 0] > ranking[j, 0] && ranking[i, 1] > ranking[j, 1])
                        currOrder++;
                }

                order[i] = ++currOrder;
            }

            string output = order[0].ToString();

            for (int i = 1; i < physical.GetLength(0); i++)
                output += " " + order[i];

            Console.WriteLine(output);
        }
    }
}
