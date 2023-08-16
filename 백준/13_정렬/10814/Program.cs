using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10814
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[][] info = new string[n][];

            for(int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                info[i] = new string[] { i.ToString(), s[0], s[1],  };
            }

            Array.Sort(info, (a, b) =>
            {
                if (a[1].Equals(b[1]))
                    return int.Parse(a[0]) - int.Parse(b[0]);
                else
                    return int.Parse(a[1]) - int.Parse(b[1]);
            });

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(string.Format("{0} {1}", info[i][1], info[i][2]));
            }
        }
    }
}
