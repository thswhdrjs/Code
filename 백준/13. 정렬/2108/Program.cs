using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2108
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

            int arithmeticMean = 0, medianValue = 0, mode = 0, range = 0;
            QuickSort(arr, 0, arr.Length - 1);

            arithmeticMean = GetArithmeticMean(arr);
            medianValue = arr[arr.Length / 2];
            mode = arr.Length == 1 ? arr[arr.Length - 1] : GetMode(arr);
            range = arr.Length == 1 ? 0 : arr[arr.Length - 1] - arr[0];

            Console.WriteLine(arithmeticMean);
            Console.WriteLine(medianValue);
            Console.WriteLine(mode);
            Console.WriteLine(range);
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

        static int GetArithmeticMean(int[] arr)
        {
            int sum = 0;

            foreach (int n in arr)
                sum += n;

            return (int)Math.Round((float)sum / arr.Length);
        }

        static int GetMode(int[] arr)
        {
            int[] arr2 = new int[4001 + arr[arr.Length - 1]];
            int check = 0;
            int mode = 0;

            for (int i = 0; i < arr.Length; i++)
                arr2[4000 + arr[i]]++;

            for (int i = 4000 + arr[0]; i < arr2.Length; i++)
            {
                if (arr2[i] == arr2[arr2.Length - 1])
                    check++;

                if (check == 2)
                {
                    mode = i - 4000;
                    break;
                }
            }

            return mode;
        }
    }
}
