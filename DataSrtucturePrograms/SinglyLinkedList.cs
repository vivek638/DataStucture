using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPractice
{
    class LinkedList
    {
        Node head = null;

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
                head = newNode;
            }
            else
            {
                newNode.next = head;
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
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = newNode;
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
                head = head.next;
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
                while (current.next != null && current.next.next != null)
                {
                    current = current.next;
                }
                value = current.next.data;
                current.next = null;
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
                while (current != head)
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
                while (node.next != null)
                {
                    Console.Write(" {0} Node =>", node.data);
                    node = node.next;
                }
                Console.Write(" {0} \n", node.data);
            }
        }

        public void FindLoop()
        {
            Node fast = head;
            Node Slow = head;
            if (fast == null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            else
            {
                while (fast.next != null && fast.next.next != null)
                {
                    Slow = Slow.next;
                    fast = fast.next.next;
                    if (fast == Slow)
                    {
                        Console.WriteLine("LinkedList contain cycle");
                        break;
                    }
                    
                }
                Console.WriteLine("LinkedList does not contain cycle");
            }
        }

        public void FindLenght()
        {
            int count = 0;
            if (head == null)
            {
                count = 0;
            }
            while (head.next != null)
            {
                count++;
                head = head.next;
            }
            count++;
            Console.WriteLine("Total number of nodes is {0}", count);
        }

        public void FindNthNodeFromBeg(int index)
        {
            int count = 1;
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("List is empty");
            }
            while (temp.next != null && count != index)   // 
            {
                count++;
                temp = temp.next;
            }
            
            Console.WriteLine("Given index {0} value is : {1}",index,temp.data);
        }

        public void RemoveDuplicate()
        {
           
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("List is epmty");
            }
            while (temp.next != null)   // 
            {
                if (temp.data == temp.next.data)
                {
                    temp.next = temp.next.next;
                }
                temp = temp.next;
            }

        }

        public void copyListReverse()
        {
            LinkedList newLL = new LinkedList();
            while (head != null)
            {
                newLL.AddNodeLast(head.data);
                head = head.next;
            }

            Node temp = newLL.head;
            while (temp.next != null)
            {
                Console.Write(" {0} Node =>", temp.data);
                temp = temp.next;
            }
            Console.Write(" {0} \n", temp.data);
        }

        public void copyList()
        {
            LinkedList newLL = new LinkedList();
            while (head != null)
            {
                newLL.AddNodeFront(head.data);
                head = head.next;
            }

            Node temp = newLL.head;
            while (temp.next != null)
            {
                Console.Write(" {0} Node =>", temp.data);
                temp = temp.next;
            }
            Console.Write(" {0} \n", temp.data);
        }

        public void nthNodeFromBegining(int index)
        {
            int count = 0;
            Node curr = head;
            while (curr != null && count < index - 1)
            {
                count++;
                curr = curr.next;
            }
            if (curr == null)
                 Console.WriteLine("List is empty");

            Console.WriteLine("Value is {0}", curr.data);
        }

        public void nthNodeFromEnd2(int x)
        {

            if (head == null)
                 Console.WriteLine("List is empty");
            if (x < 1)
                 Console.WriteLine("List is empty");
 
            Node lag = head;
            Node lead = head;
 
            //Move the lead pointer up (x-1 positions) while leaving the lag pointer behind
            for (int i = 1; i < x; i++)
                lead = lead.next;
 
            //Move the lag and lead pointers up one at a time until the lead is at the end of the list
            while (lead.next != null)
            {
                lag = lag.next;
                lead = lead.next;
            }
            Console.WriteLine("Value is {0}", lag.data);
        }

        public void SearchUsingIterative(int item)
        {
            Node temp = head;
            while (temp != null)
            {
                if (temp.data == item)
                {
                    Console.Write(" Item : {0} Successfully Found", temp.data);
                }
                temp = temp.next;
            }          
        }

        public void SearchUsingRecur(int item)
        {
            Console.Write(" Item  Found {0}", SearchUsingRecursion(item,head));
        }
        bool SearchUsingRecursion(int item, Node head)
        {
            if (head == null)
                return false;
            else if (head.data == item)
            {
                return true;
            }               
            else
            {
              return SearchUsingRecursion(item, head.next);
            }
        }

         public void NumberOfOccuranceElement(int item)
         {
            int count = 0;
             Node temp = head;
             while (temp != null)
             {
                 if (temp.data == item)
                 {
                     count++;                   
                 }
                 temp = temp.next;
             }
             Console.Write(" Item : {0} occurance count : {1}", item,count);
         }

         public void detectLoop()
         {
             printNode();
             head.next.next.next.next.next = head;

             Node slow = head;
             Node fast = head.next;
             while(fast.next != null && fast.next.next != null)
             {
             if (fast == slow)
             {
                 Console.WriteLine("Loop Detected");
                 break;
             }
             fast=fast.next.next;
             slow=slow.next;
             }
         }

         public void CheckForPalindrome()
         {
             bool isPalin;
             Node slow = head;
             Node Fast = head;
             Stack<Node> newList = new Stack<Node>();
             newList.Push(slow);
           
             while (Fast.next !=null && Fast.next.next!= null)
             {
                 slow = slow.next;
                 Fast = Fast.next.next;
                 newList.Push(slow);
             }
             Node temp = slow;
             while (temp.next != null)
             {
               Node deletedNode = newList.Pop();
               isPalin = IsPalindrome(temp.data, deletedNode.data);
               if (!isPalin) break;
             }
             if (slow == null)
             {
                 Console.WriteLine("Palindrome");
             }
             else
             {
                 Console.WriteLine("Not Palindrome");
             }
         }
         bool IsPalindrome(int a,int b)
         {
             if(a==b) return true;
             else return false;
         }
        
    }
}
