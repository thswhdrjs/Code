using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3009
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 2차 배열

            //int[,] value = new int[3, 2];
            //int[,] arr = new int[2, 2], arr2 = new int[2, 2];
            //int x = 0, y = 0;

            //for(int i = 0; i < 3; i++)
            //{
            //    string[] s = Console.ReadLine().Split(' ');
            //    value[i, 0] = int.Parse(s[0]);
            //    value[i, 1] = int.Parse(s[1]);
            //}

            //for(int i = 0; i < value.GetLength(0); i++)
            //{
            //    bool isExist = false;

            //    for(int j = 0; j < arr.GetLength(0); j++)
            //    {
            //        if(arr[j, 0] == value[i, 0])
            //        {
            //            arr[j, 1]++;
            //            isExist = true;
            //            break;
            //        }
            //    }

            //    if (!isExist)
            //    {
            //        int index = arr[0, 0] == 0 ? 0 : 1;
            //        arr[index, 0] = value[i, 0];
            //        arr[index, 1]++;
            //    }
            //}

            //for(int i = 0; i < arr.GetLength(0); i++)
            //{
            //    if(arr[i, 1] == 1)
            //    {
            //        x = arr[i, 0];
            //            break;
            //    }
            //}

            //for (int i = 0; i < value.GetLength(0); i++)
            //{
            //    bool isExist = false;

            //    for (int j = 0; j < arr2.GetLength(0); j++)
            //    {
            //        if (arr2[j, 0] == value[i, 1])
            //        {
            //            arr2[j, 1]++;
            //            isExist = true;
            //            break;
            //        }
            //    }

            //    if (!isExist)
            //    {
            //        int index = arr2[0, 0] == 0 ? 0 : 1;
            //        arr2[index, 0] = value[i, 1];
            //        arr2[index, 1]++;
            //    }
            //}

            //for (int i = 0; i < arr2.GetLength(0); i++)
            //{
            //    if (arr2[i, 1] == 1)
            //    {
            //        y = arr2[i, 0];
            //        break;
            //    }
            //}

            //Console.WriteLine(string.Format("{0} {1}", x, y));

            #endregion

            int[] xValue = new int[3], yValue = new int[3];
            int x = 0, y = 0;

            for (int i = 0; i < 3; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                xValue[i] = int.Parse(s[0]);
                yValue[i] = int.Parse(s[1]);
            }

            if (xValue[0] == xValue[1])
                x = xValue[2];
            else if (xValue[0] == xValue[2])
                x = xValue[1];
            else
                x = xValue[0];

            if (yValue[0] == yValue[1])
                y = yValue[2];
            else if (yValue[0] == yValue[2])
                y = yValue[1];
            else
                y = yValue[0];

            Console.WriteLine(string.Format("{0} {1}", x, y));
        }
    }
}
