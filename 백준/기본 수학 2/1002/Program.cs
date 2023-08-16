using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1002
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for(int i = 0; i < t; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                int x1 = int.Parse(s[0]), y1 = int.Parse(s[1]), r1 = int.Parse(s[2]), x2 = int.Parse(s[3]), y2 = int.Parse(s[4]), r2 = int.Parse(s[5]);

                //1번 버전
                int distancePow = (int)(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

                // 원이 일치할 때(무한)
                if (x1 == x2 && y1 == y2 && r1 == r2)
                    Console.Write("-1 ");
                // 원이 만나지 않을 때(distancePow > Mathf.Pow(r1 + r2, 2))
                else if (distancePow > Math.Pow(r1 + r2, 2))
                    Console.Write("0 ");
                // 원이 만나지 않을 때(distancePow<Mathf.Pow(r2 -r1, 2))
                else if (distancePow < Math.Pow(r2 - r1, 2))
                    Console.Write("0 ");
                // 원이 내접할 때
                else if (distancePow == Math.Pow(r2 - r1, 2))
                    Console.Write("1 ");
                // 원이 외접할 때
                else if (distancePow == Math.Pow(r1 + r2, 2))
                    Console.Write("1 ");
                else
                    Console.Write("2 ");

                Console.Write("\n");

                //2번 버전
                float distance = (float)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

                if (distance == r1 + r2)
                    Console.Write("1 ");
                else if (distance < r1 + r2 && distance > r1 && distance > r2)
                    Console.Write("2 ");
                else if (x1 == x2 && y1 == y2 && r1 == r2)
                    Console.Write("-1 ");
                else
                    Console.Write("0 ");

                Console.Write("\n");
            }
        }
    }
}
