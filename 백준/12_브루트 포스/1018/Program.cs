using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1018
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int n = int.Parse(s[0]), n2 = int.Parse(s[1]);

            string[] chessBoard = new string[n];

            for (int i = 0; i < n; i++)
            {
                chessBoard[i] = Console.ReadLine();
            }

            int min = -1;
            int blackCount = 0;
            int whiteCount = 0;

            for (int i = 0; i < n - 7; i++)
            {
                for (int j = 0; j < n2 - 7; j++)
                {
                    for (int k = i; k < i + 8; k++)
                    {
                        for (int l = j; l < j + 8; l++)
                        {
                            if (k % 2 == 0)
                            {
                                if (l % 2 == 0)
                                {
                                    if (chessBoard[k][l].Equals('W'))
                                        whiteCount++;
                                    else
                                        blackCount++;
                                }
                                else
                                {
                                    if (chessBoard[k][l].Equals('B'))
                                        whiteCount++;
                                    else
                                        blackCount++;
                                }
                            }
                            else
                            {
                                if (l % 2 == 0)
                                {
                                    if (chessBoard[k][l].Equals('B'))
                                        whiteCount++;
                                    else
                                        blackCount++;
                                }
                                else
                                {
                                    if (chessBoard[k][l].Equals('W'))
                                        whiteCount++;
                                    else
                                        blackCount++;
                                }
                            }
                        }
                    }

                    if (min == -1)
                        min = Math.Min(blackCount, whiteCount);
                    else
                    {
                        if (min > blackCount || min > whiteCount)
                            min = Math.Min(blackCount, whiteCount);
                    }

                    blackCount = 0;
                    whiteCount = 0;
                }
            }

            Console.WriteLine(min);
        }
    }
}
