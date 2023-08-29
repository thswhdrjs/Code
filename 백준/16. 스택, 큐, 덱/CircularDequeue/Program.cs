using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularDequeue
{
    class CircularQueue<T>
    {
        public T[] arr;

        public int max;
        public int front;
        public int rear;

        public CircularQueue(int n)
        {
            arr = new T[n];

            max = n;
            front = 0;
            rear = -1;
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

            rear = (rear + 1) % max;
            arr[rear] = value;
        }

        public void FrontEnqueue(T value)
        {
            if (IsFull())
            {
                Console.WriteLine(value + " Full");
                return;
            }

            arr[front] = value;
            front = (front - 1 + max) % max;
        }

        public void RearEnqueue(T value)
        {
            Enqueue(value);
        }

        public T Dequeue()
        {
            if (IsEmpty())
                return default;

            front = (front + 1) % max;
            T value = arr[front];
            
            return value;
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
            rear = (rear - 1 + max) % max;

            return value;
        }

        public T Peek()
        {
            if (IsEmpty())
                return default;

            return arr[(front + 1) % max];
        }

        public T FrontPeek()
        {
            return Peek();
        }

        public T RearPeek()
        {
            if (IsEmpty())
                return default;

            return arr[rear];
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

            var n = int.Parse(sr.ReadLine());
            var deq = new CircularQueue<int>(n);

            var sb = new StringBuilder();
            sb.AppendLine();

            for (int i = 0; i < n; i++)
            {
                var arr = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

                switch (arr[0])
                {
                    case 1:
                        {
                            deq.FrontEnqueue(arr[1]);
                            Console.WriteLine(deq.front + " / " + deq.rear);
                            break;
                        }
                    case 2:
                        {
                            deq.RearEnqueue(arr[1]);
                            Console.WriteLine(deq.front + " / " + deq.rear);
                            break;
                        }
                    case 3:
                        {
                            sb.AppendLine(deq.Count() > 0 ? deq.FrontDequeue().ToString() : "-1");
                            Console.WriteLine(deq.front + " / " + deq.rear);
                            break;
                        }
                    case 4:
                        {
                            sb.AppendLine(deq.Count() > 0 ? deq.RearDequeue().ToString() : "-1");
                            Console.WriteLine(deq.front + " / " + deq.rear);
                            break;
                        }
                    case 5:
                        {
                            sb.AppendLine(deq.Count().ToString());
                            break;
                        }
                    case 6:
                        {
                            sb.AppendLine(deq.Count() > 0 ? "0" : "1");
                            break;
                        }
                    case 7:
                        {
                            sb.AppendLine(deq.Count() > 0 ? deq.Peek().ToString() : "-1");
                            Console.WriteLine(deq.front + " / " + deq.rear);
                            break;
                        }
                    case 8:
                        {
                            sb.AppendLine(deq.Count() > 0 ? deq.RearPeek().ToString() : "-1");
                            Console.WriteLine(deq.front + " / " + deq.rear);
                            break;
                        }
                }
            }


            sw.Write(sb);
            sw.Close();
        }
    }
}
