using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1546
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Split(' ');

            float[] changesScores = new float[t];
            float sum = 0;

            int max = 0;

            for (int i = 0; i < t; i++)
            {
                if (max < int.Parse(s[i]))
                    max = int.Parse(s[i]);
            }

            for (int i = 0; i < t; i++)
                changesScores[i] = (float)int.Parse(s[i]) / max * 100f;

            for (int i = 0; i < changesScores.Length; i++)
                sum += changesScores[i];

            Console.WriteLine(string.Format("{0:0.0}", sum / changesScores.Length));
        }
    }
}
