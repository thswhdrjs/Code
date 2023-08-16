using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2941
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case 'c':
                        {
                            if (s[i + 1] == '=' || s[i + 1] == '-')
                                i++;

                            break;
                        }
                    case 'd':
                        {
                            if (s[i + 1] == '-')
                                i++;
                            else if (s[i + 1] == 'z' && s[i + 2] == '=')
                                i += 2;

                            break;
                        }
                    case 'l':
                        {
                            if (s[i + 1] == 'j')
                                i++;

                            break;
                        }
                    case 'n':
                        {
                            if (s[i + 1] == 'j')
                                i++;

                            break;
                        }
                    case 's':
                        {
                            if (s[i + 1] == '=')
                                i++;

                            break;
                        }
                    case 'z':
                        {
                            if (s[i + 1] == '=')
                                i++;

                            break;
                        }
                }

                count++;
            }

            Console.WriteLine(count);
        }
    }
}
