using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularQueue
{
    class CircularQueue<T>
    {
        public T[] arr;

        public int max;
        public int front, rear;

        public CircularQueue(int n)
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
            if(IsFull())
                return;

            rear = (rear + 1) % max;
            arr[rear] = value;
        }

        public T Dequeue()
        {
            if(IsEmpty())
                return default;

            front = (front + 1) % max;
            return arr[front];
        }

        public T Peek()
        {
            if (IsEmpty())
                return default;

            return arr[(front + 1) % max];
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
            var queue = new CircularQueue<int>(10);

            for (int i = 0; i < queue.max; i++)
            {
                queue.Enqueue(i);
            }

            for (int i = queue.front + 1; i != (queue.rear + 1) % queue.max; i = ++i % queue.max)
            {
                Console.Write(queue.arr[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Peek: " + queue.Peek());
            Console.WriteLine("Dequeue: " + queue.Dequeue());

            queue.Enqueue(9);

            for (int i = queue.front + 1; i != (queue.rear + 1) % queue.max; i = ++i % queue.max)
            {
                Console.Write(queue.arr[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Peek: " + queue.Peek());

            queue.Clear();

            for (int i = queue.front + 1; i != (queue.rear + 1) % queue.max; i = ++i % queue.max)
            {
                Console.Write(queue.arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
