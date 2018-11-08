using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPractice
{
    class StackUsingLinkedList
    {
        int top = -1;
        int count = 0;
        Node head;
        public class Node
        {
           public int data;
           public Node next;
            public Node(int n)
            {
                data = n;
                next = null;
            }
        }

        bool IsEmpty()
        {
            if (head == null)
            {
                return true;
            }
            return false;
        }
        public void push(int item)
        {
            Node newNode = new Node(item);
            if (IsEmpty())
            {
                head = newNode;
            }
            else
            {
                newNode.next = head;
                 head = newNode;
            }
        }

        public void pop()
        {
            int value = 0;
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                value = head.data;
                head = head.next;
            }
            Console.WriteLine("Deleted item from Stack is :{0}",value);
        }
        public void print()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    Console.WriteLine(" item in Stack is :{0}", temp.data);
                    temp = temp.next;
                }
                Console.WriteLine(" item in Stack is :{0}", temp.data);
            }
        }

    }
}
