using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2775
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for(int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine()), n2 = int.Parse(Console.ReadLine());

                //재귀
                Console.WriteLine(GetRoomPerson(n, n2));

                //이차 배열
                int[,] room = new int[n + 1, n2];

                for (int j = 1; j < n + 1; j++)
                    room[j, 0] = 1;

                for (int j = 0; j < n2; j++)
                    room[0, j] = j + 1;

                for (int j = 1; j < n + 1; j++)
                {
                    for (int k = 1; k < n2; k++)
                        room[j, k] = room[j, k - 1] + room[j - 1, k];
                }

                Console.WriteLine(room[n, n2 - 1]);
            }
        }

        static int GetRoomPerson(int floor, int nRoom)
        {
            if (floor == 0)
                return nRoom;
            else if (nRoom == 1)
                return 1;

            return GetRoomPerson(floor, nRoom - 1) + GetRoomPerson(floor - 1, nRoom);
        }
    }
}
