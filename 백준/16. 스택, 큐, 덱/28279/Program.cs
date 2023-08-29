using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28279
{
    class Deque<T>
    {
        public T[] arr;

        public int max;
        private int front, rear;

        public Deque(int n)
        {
            arr = new T[n];

            max = n;
            front = 0;
            rear = 0;
        }

        public bool IsEmpty()
        {
            return front == rear;
        }

        public bool IsFull()
        {
            return front == (rear + 1) % max;
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

            return arr[(front + 1) % max];
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
            if (IsEmpty())
                return default;

            T value = arr[rear];
            rear = (--rear + max) % max;

            return value;
        }

        public T FrontPeek()
        {
            return arr[(front + 1) % max];
        }

        public T RearPeek()
        {
            return arr[rear];
        }

        public int Size()
        {
            return (rear - front + max) % max;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            var n = int.Parse(sr.ReadLine());
            var deq = new Deque<int>(n);

            var sb = new StringBuilder();

            for(int i = 0; i < n; i++)
            {
                var arr = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

                switch(arr[0])
                {
                    case 1:
                        {
                            deq.FrontEnqueue(arr[1]);
                            break;
                        }
                    case 2:
                        {
                            deq.RearEnqueue(arr[1]);
                            break;
                        }
                    case 3:
                        {
                            sb.AppendLine(deq.Size() > 0 ? deq.FrontDequeue().ToString() : "-1");
                            break;
                        }
                    case 4:
                        {
                            sb.AppendLine(deq.Size() > 0 ? deq.RearDequeue().ToString() : "-1");
                            break;
                        }
                    case 5:
                        {
                            sb.AppendLine(deq.Size().ToString());
                            break;
                        }
                    case 6:
                        {
                            sb.AppendLine(deq.Size() > 0 ? "0" : "1");
                            break;
                        }
                    case 7:
                        {
                            sb.AppendLine(deq.Size() > 0 ? deq.FrontPeek().ToString() : "-1");
                            break;
                        }
                    case 8:
                        {
                            sb.AppendLine(deq.Size() > 0  ? deq.RearPeek().ToString() : "-1");
                            break;
                        }
                }
            }

            sw.Write(sb);
            sw.Close();
        }
    }
}
