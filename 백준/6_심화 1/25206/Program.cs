using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25206
{
    class Program
    {
        static void Main(string[] args)
        {
            float count = 0;
            float score = 0f;

            for(int i = 0; i < 20; i++)
            {
                string[] s = Console.ReadLine().Split(' ');

                if (s[2].Equals("P") || s[2].Equals("F"))
                { 
                    continue;
                }

                count += float.Parse(s[1]);

                switch (s[2])
                {
                    case "A+":
                        {
                            score += float.Parse(s[1]) * 4.5f;
                            break;
                        }
                    case "A0":
                        {
                            score += float.Parse(s[1]) * 4f;
                            break;
                        }
                    case "B+":
                        {
                            score += float.Parse(s[1]) * 3.5f;
                            break;
                        }
                    case "B0":
                        {
                            score += float.Parse(s[1]) * 3f;
                            break;
                        }
                    case "C+":
                        {
                            score += float.Parse(s[1]) * 2.5f;
                            break;
                        }
                    case "C0":
                        {
                            score += float.Parse(s[1]) * 2f;
                            break;
                        }
                    case "D+":
                        {
                            score += float.Parse(s[1]) * 1.5f;
                            break;
                        }
                    case "D0":
                        {
                            score += float.Parse(s[1]);
                            break;
                        }
                }
            }

            Console.WriteLine(score == 0f && count == 0f ? "0.000000": string.Format("{0:0.000000}", score / count));
        }
    }
}
