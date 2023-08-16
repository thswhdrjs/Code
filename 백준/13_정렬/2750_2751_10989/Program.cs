using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2750_2751_10989
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for(int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            QuickSort(arr, 0, arr.Length - 1);

            foreach (int num in arr)
                Console.WriteLine(num);
        }

        static void QuickSort(int[] arr, int start, int end)
        {
            int pivot = GetPivot(arr, start, end);
            int i = start, j = end;

            while(i <= j)
            {
                while(arr[i] < pivot)
                {
                    i++;
                }

                while(arr[j] > pivot)
                {
                    j--;
                }

                if(i <= j)
                {
                    Swap(arr, i, j);
                    i++;
                    j--;
                }
            }

            if(start < j)
            {
                QuickSort(arr, start, j);
            }

            if(end > i)
            {
                QuickSort(arr, i, end);
            }
        }

        static int GetPivot(int[] arr, int start, int end)
        {
            int center = (start + end) / 2;

            if(arr[start] > arr[center])
                Swap(arr, start, center);

            if (arr[start] > arr[end])
                Swap(arr, start, end);

            if (arr[center] > arr[end])
                Swap(arr, center, end);

            return arr[center];
        }

        static void Swap(int[] arr, int n, int n2)
        {
            int temp = arr[n];
            arr[n] = arr[n2];
            arr[n2] = temp;
        }
    }
}
