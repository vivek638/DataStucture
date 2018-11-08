using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPractice
{
    class QueueUsingArray
    {
        int[] queue;
        int Capacity = 100;
        int size;
        int front = -1;
        int rear = -1;

      public  QueueUsingArray()
        {
            queue = new int[Capacity];
            size = Capacity;
        }
        bool IsFull()
        {
            if (rear == Capacity) return true;

            return false;
        }
        bool IsEmpty() {
            if (front == -1 && rear == -1) return true;

            return false;
        }
        public void Enqueue(int item)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is full");
            }
            else if (IsEmpty())
            {
                ++front;
                ++rear;
                queue[rear] = item;

            }
            else
            {
                queue[++rear] = item;
            }
        }
        public void Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
            }
            else if (front == rear)
            {

                int value = queue[front];
                --front;
                --rear;
                Console.WriteLine("deleted item from queue is:{0}",value);
            }
            else
            {
                int value = queue[front];
                front++;
                Console.WriteLine("deleted item from queue is:{0}", value);
            }
        }
        public void Print()
        {
          
            if (IsEmpty())
            {
                Console.WriteLine("stack is empty");
            }
            else
            {
                for (int i = front; i <=rear ; i++ )
                {

                    Console.WriteLine("Stack item is:{0}",queue[i]);

                }
            }
        }           
       
    }
}
