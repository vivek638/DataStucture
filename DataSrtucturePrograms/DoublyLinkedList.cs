using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPractice
{
    class DoublyLinkedList
    {
        Node head = null;
        Node Tail = null;
        public class Node
        {
            public int data;
            public Node lnext;
            public Node rnext;

         public Node(int d)
            {
                data = d;
                lnext = null;
                rnext = null;
            }
        }

        public void AddNodeFront(int item)
        {
            Node newNode = new Node(item);
            if (head == null)
            {
               Tail = head = newNode;
            }
            else
            {
                newNode.rnext = head;
                head.lnext = newNode;
                head = newNode;
            }
        }

        public void AddNodeLast(int item)
        {
            Node newNode = new Node(item);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.rnext != null)
                {
                    current = current.rnext;
                }
                current.rnext = newNode;
                newNode.lnext = current;
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
            else
            {
                value = head.data;
                head = head.rnext;                      //null,5,100 => 100,6,200
                head.lnext = null;
            }
            Console.WriteLine("Deleted node is {0}", value);
            return value;
        }

        public int DeleteNodeEnd()
        {
            int value = 0;
            if (head == null)
            {
                throw new Exception("List is empty");  // 5 , 100 => 6,null

            }
            else
            {
                Node current = head;
                Node prev = null; 
                while (current.rnext != null && current.rnext.rnext != null)
                {
                    prev = current;
                    current = current.rnext;
                }
                value = current.rnext.data;
                current.rnext = null;
                current.lnext = prev;
                Tail = current;
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
                throw new Exception("List is empty");  // null,5 , 100 => 100,6,200

            }
            else if (current.rnext == null)
            {
                Console.WriteLine("List Containing one node already reversed");
            }
            else
            {
                while (current.rnext != null)
                {
                    next = current.rnext;
                    current.rnext = current.lnext;
                    current.lnext = next;
                    if (current.lnext == null)
                    {
                        Tail = head;
                        head = current;
                     

                    }
                }
                
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
                    while(node.rnext != null)
                        {
                            Console.WriteLine("{0} Node =>",node.data);
                            node = node.rnext;
                        }
                        Console.WriteLine("{0} Node =>",node.data);
                }
            }
        }
    }

