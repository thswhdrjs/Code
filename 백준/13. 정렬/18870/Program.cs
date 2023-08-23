using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18870
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] x = Console.ReadLine().Split(' ');
            int[] num = new int[n];

            for (int i = 0; i < n; i++)
            {
                num[i] = int.Parse(x[i]);
            }

            int order = 0;
            int[] arr = new int[num.Length];

            for (int i = 0; i < num.Length; i++)
                arr[i] = num[i];

            QuickSort(arr, 0, arr.Length - 1);

            for (int i = 0; i < num.Length - 1; i++)
            {
                for (int j = i + 1; j < num.Length; j++)
                {
                    if (arr[i] == arr[j])
                        arr[j] = 0;
                }
            }

            for (int i = 0; i < num.Length; i++)
            {
                if (arr[i] == 0)
                    continue;

                for (int j = 0; j < num.Length; j++)
                {
                    if (arr[i] == num[j])
                        num[j] = order;
                }

                order++;
            }

            for (int i = 0; i < num.Length; i++)
                Console.Write(string.Format("{0} ", num[i]));

            Console.Write("\n");
        }

        static void Swap(int[] arr, int n, int n2)
        {
            int temp = arr[n];
            arr[n] = arr[n2];
            arr[n2] = temp;
        }

        static int GetPivot(int[] arr, int start, int end)
        {
            int center = (start + end) / 2;

            if (arr[start] > arr[center])
                Swap(arr, start, center);

            if (arr[start] > arr[end])
                Swap(arr, start, end);

            if (arr[center] > arr[end])
                Swap(arr, center, end);

            return arr[center];
        }

        static void QuickSort(int[] arr, int start, int end)
        {
            int pivot = GetPivot(arr, start, end);
            int i = start, j = end;

            while (i <= j)
            {
                while (arr[i] < pivot)
                    i++;

                while (arr[j] > pivot)
                    j--;

                if (i <= j)
                {
                    Swap(arr, i, j);
                    i++;
                    j--;
                }
            }

            if (start < j)
                QuickSort(arr, start, j);

            if (end > i)
                QuickSort(arr, i, end);
        }
    }
}
