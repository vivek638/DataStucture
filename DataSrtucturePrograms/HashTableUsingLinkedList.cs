using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPractice
{
    class HashTableUsingLinkedList
    {
        int size = 512;
        Node[] list;
        class Node
        {
          public  int data;
           public Node next;
           public Node(int n,Node newNodePointToExisting)
            {
                data = n;
                next = newNodePointToExisting;
            }
        }
       public HashTableUsingLinkedList()
        {
            list = new Node[size];
            for (int i = 0; i < size; i++)
            {
                list[i] = null;
            }
        }
        int computeHash(int item)
        {
            return item % size;
        }
        public void insert(int item)
        {
            int index = computeHash(item);
            list[index] = new Node(item, list[index]);

        }
        public void find(int item)
        {
            int index = computeHash(item);
            Node head = list[index];
            if (head == null)
            {
                Console.WriteLine("Item not present in HashTable");
            }
            else
            {
                if (head.data == item)
                {
                    Console.WriteLine("Item  present in HashTable");
                }
                else
                {
                    while (head.next != null)
                    {
                        if (head.data == item)
                        {
                            Console.WriteLine("Item  present in HashTable");
                            break;
                        }
                        head = head.next;
                    }
                }
            }                 
        }

        public void delete(int item)
        {
            int index = computeHash(item);
            Node head = list[index];
            if (head != null && head.data == item)
            {
                if (head.next == null)
                {
                    list[index] = head.next;
                }
                else
                {
                    Node temp = head;
                    while (temp.next != null)
                    {
                        if (temp.data == item)
                        {
                            list[index] = temp.next;
                            break;
                        }
                        else
                        {
                            temp = temp.next;
                        }
                    }

                }
            }
        }

        public void print()
        {
            for(int i=0;i<size;i++)
            {
                Node head = list[i];
                if (head != null)
                {
                    while (head.next != null)
                    {
                        Console.WriteLine("Hashtable contents are : {0}", head.data);
                        head = head.next;
                    }
                    Console.WriteLine("Hashtable contents are : {0}", head.data);
                }
                
            }
        }
    }
}
