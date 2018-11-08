using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPractice
{
    class QueueUsingLinkedList
    {
        Node head;

        class Node
        {
          public  int data;
          public  Node next;

            public Node(int d)
            {
                data = d;
                next = null;
            }

        }
        bool IsEmpty()
        {
            if (head == null) return true;

            return false;
        }

        public void Enqueue(int item)
        {
            Node newNode = new Node(item);
            if (IsEmpty())
            {
                head = newNode;
            }
            else {
                Node temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
        }

        public void Dequeue()
        {
            int value = 0;
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Console.WriteLine("Item deleted from queue is: {0}", head.data);
                head = head.next;
            }
        }

        public void print()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    Console.WriteLine("Queue item is : {0}",temp.data);
                    temp = temp.next;
                }
                Console.WriteLine("Queue item is : {0}", temp.data);
            }
        }
    }
}
