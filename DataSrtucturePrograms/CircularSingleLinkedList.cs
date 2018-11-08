using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPractice
{
    class CircularSingleLinkedList
    {
            Node head = null;
            Node Tail = null;
            public class Node
            {
                public int data;
                public Node next;
                public Node(int d)
                {
                    data = d;
                    next = null;
                }
                Node(int d, Node n)
                {
                    data = d;
                    next = n;
                }
            }

            public void AddNodeFront(int item)
            {
                Node newNode = new Node(item);
                if (head == null)
                {
                    Tail =newNode;
                    Tail.next = newNode;
                }
                else
                {
                    newNode.next = Tail.next;                  
                    Tail.next = newNode;

                }
            }

            public void AddNodeLast(int item)
            {
                Node newNode = new Node(item);
                if (head == null)
                {
                   Tail= head = newNode;
                }
                else
                {
                    newNode.next = Tail.next;
                    Tail.next = newNode;
                    Tail = newNode;
                }
            }
            public int DeleteNodeFront()
            {
                int value = 0;
                if (head == null)
                {
                    throw new Exception("List is empty");

                }
                value = Tail.next.data;
               if (Tail == Tail.next)
                {
                    Tail = null;
                }
                else
                {
                    Tail = Tail.next.next;
                }
                Console.WriteLine("Deleted node is {0}", value);
                return value;
            }          

            public void ReverseList()
            {
                Node prev = null;
                Node next = null;
                Node current = head;
                if (head == null)
                {
                    throw new Exception("List is empty");  // 5 , 100 => 6,null

                }
                else if (current.next == null)
                {
                    Console.WriteLine("List Containing one node already reversed");
                }
                else
                {
                    while (current != null)
                    {
                        next = current.next;
                        current.next = prev;
                        prev = current;
                        current = next;
                    }
                    head = prev;
                }

            }

            public void printNode()
            {
                Node node = head;
                if (node == null)
                {
                    Console.WriteLine("LinkedList is empty");
                }
                else
                {
                    while (node.next != head)
                    {
                        Console.WriteLine("{0} Node =>", node.data);
                        node = node.next;
                    }
                    Console.WriteLine("{0} Node =>", node.data);
                }
            }
        }
    
}
