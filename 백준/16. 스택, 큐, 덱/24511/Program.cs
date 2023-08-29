using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24511
{
    class MyDequeue<T>
    {
        public T[] arr;

        public int max;
        public int front, rear;

        public MyDequeue(int n)
        {
            arr = new T[n];

            max = n;
            front = 0;
            rear = 0;
        }

        public bool IsFull()
        {
            return front == (rear + 1) % max;
        }
        
        public bool IsEmpty()
        {
            return front == rear;
        }

        public void Enqueue(T value)
        {
            if (IsFull())
                return;

            rear = ++rear % max;
            arr[rear] = value;
        }

        public T Dequeue()
        {
            if (IsEmpty())
                return default;

            front = ++front % max;
            return arr[front];
        }

        public T Peek()
        {
            if (IsEmpty())
                return default;

            return arr[rear];
        }

        public void FrontEnqueue(T value)
        {
            if (IsFull())
                return;

            arr[front] = value;
            front = (--front + max) % max;
        }

        public void RearEnqueue(T value)
        {
            Enqueue(value);
        }

        public T FrontDequeue()
        {
            return Dequeue();
        }

        public T RearDequeue()
        {
            if(IsEmpty())
                return default;

            T value = arr[rear];
            rear = (--rear + max) % max;

            return value;
        }

        public T FrontPeek()
        {
            if (IsEmpty())
                return default;

            return arr[front + 1];
        }

        public T RearPeek()
        {
            return Peek();
        }

        public int Count()
        {
            return (rear - front + max) % max;
        }

        public void Clear()
        {
            front = rear;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            var sb = new StringBuilder();

            var n = int.Parse(sr.ReadLine());
            var dtArr = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
            var arr = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

            var m = int.Parse(sr.ReadLine());
            var insertArr = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

            var dq = new MyDequeue<int>((n > m ? n : m) + 1);

            for(int i = 0; i < n; i++)
            {
                if(dtArr[i] == 0)
                    dq.RearEnqueue(arr[i]);
            }

            for (int i = 0; i < m; i++)
            {
                dq.FrontEnqueue(insertArr[i]);
                sb.Append(dq.RearDequeue() + " ");
            }

            sw.Write(sb);
            sw.Close();
        }
    }
}