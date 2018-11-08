using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPractice
{
    class Program
    {
      //  static void Main(string[] args)
        //{
        //    string line = "Display the revrese string";
        //    string[] stringArray = line.Split(' ');

        //    string newstring = String.Join(" ", stringArray);
        //    int a = 1;
            //int[] array = new int[] { 9, 1, 8, 2, 7, 3, 6, 4, 5 };
            //SortingAlgorithm bs = new SortingAlgorithm();
            //bs.QuickSort(array);
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write(array[i] + " ");
            //}


            //int[] first = new int[] { 1, 3, 5, 7, 9, 25, 30 };
            //int[] second = new int[] { 2, 4, 6, 8, 10, 12, 14, 16, 21, 23, 24 };
            //SearchAlgorithm sa = new SearchAlgorithm();

            //int[] sample = new int[] { 1,3,5,4,7,5,5 ,3,3};
            //sa.GetMaxReaptedElement2(sample);
            //bool value = sa.BinarySearchUsingRecursion(first, 30,0,first.Length-1);
            //Console.WriteLine("value find is :{0}", value);
            //Console.ReadLine();
           // int[] a = new int[] { 1,9,11,12,13,4, 5, 3 };
           // //Heap hp = new Heap(a);
           // //hp.print();
           // //for (int i = 0; i < a.Length; i++)
           // //{
           // //    Console.WriteLine("pop value :: " + hp.remove());
           // //}

           //// Heap.heapSort(a);
           // Heap hp = new Heap();
           // hp.BuidMaxHeap(a);
           // hp.print();
           // //for (int i = 0; i < a.Length; i++)
           // //{
           // //    Console.WriteLine("value is :: " + a[i]);
           // //}
           // Console.ReadLine();
           // string[] b = new string[] { "banana", "mango", "apple", "grapes" };


            //Graph g = new Graph(6);
            //g.AddEdge(5, 2);
            //g.AddEdge(5, 0);
            //g.AddEdge(4, 0);
            //g.AddEdge(4, 1);
            //g.AddEdge(2, 3);
            //g.AddEdge(3, 1);
            //g.Print();
           // Console.WriteLine("Following is a Topological Sort of the given graph.");
           //// Graph.TopologicalSort(g);
           // Console.ReadLine();

           // HashTableUsingLinkedList ht = new HashTableUsingLinkedList();
           // for (int i = 100; i < 110; i++)
           // {
           //     ht.insert(i);
           // }
           // ht.insert(109);
           // //Console.WriteLine("search 100 :: " + ht.find(100));
           // //Console.WriteLine("remove 100 :: " + ht.delete(100));
           // ht.print();
           // Console.WriteLine("---------------------------");
           // ht.delete(109);
           //// ht.find(100);
           // //ht.find(111);
           // //Console.WriteLine("remove 100 :: " + ht.delete(100));
           // ht.print();
           // Console.ReadLine();
          //  HashTable ht = new HashTable(1000);
          //  ht.InsertNode(89);
          //  ht.InsertNode(18);
          //  ht.InsertNode(49);
          //  ht.InsertNode(58);
          //  ht.InsertNode(89);
          //  ht.Print();
          //  //ht.FindNode(2);
          //  Console.WriteLine("");
          // // ht.DeleteNode(89);
          //  //ht.DeleteNode(18);
          //  //ht.DeleteNode(49);
          //  //ht.DeleteNode(100);
          ////  ht.Print();
          //  Console.ReadLine();
        
            //CircularQueueUsingArray st = new CircularQueueUsingArray();
            //st.Enqueue(1);
            //st.Enqueue(2);
            //st.Enqueue(3);
            //st.Enqueue(4);
            //st.Enqueue(5);
            //st.Enqueue(6);
            //st.Print();
            //st.Dequeue();
            //Console.WriteLine("----------------------------------------");
            //st.Print();
            //Console.ReadLine();

            //QueueUsingArray st = new QueueUsingArray();
            //st.Enqueue(1);
            //st.Enqueue(2);
            //st.Enqueue(3);
            //st.Enqueue(4);
            //st.Enqueue(5);
            //st.Enqueue(6);
            //st.Print();
            //st.Dequeue();
            //Console.WriteLine("----------------------------------------");
            //st.Print();
            //Console.ReadLine();

            //StackUsingArray st = new StackUsingArray();
            //st.push(1);
            //st.push(2);
            //st.push(3);
            //st.push(4);
            //st.push(5);
            //st.push(6);
            //st.print();
            //st.pop();
            //Console.WriteLine("----------------------------------------");
            //st.print();
            //Console.ReadLine();

            //QueueUsingLinkedList qt = new QueueUsingLinkedList();
            //qt.Enqueue(1);
            //qt.Enqueue(2);
            //qt.Enqueue(3);
            //qt.Enqueue(4);
            //qt.Enqueue(5);
            //qt.Enqueue(6);
            //qt.print();
            //qt.Dequeue();
            //qt.print();
            //Console.ReadLine();

            //StackUsingLinkedList st = new StackUsingLinkedList();
            //st.push(1);
            //st.push(2);
            //st.push(3);
            //st.push(4);
            //st.push(5);
            //st.push(6);
            //st.print();
            //st.pop();
            //st.print();
            //Console.ReadLine();

            //LinkedList ll = new LinkedList();
            //ll.AddNodeFront(1);
            //ll.AddNodeFront(2);
            //ll.AddNodeFront(3);
            //ll.AddNodeFront(2);
            //ll.AddNodeFront(1);
            //ll.CheckForPalindrome();
            //ll.detectLoop();
            //ll.printNode();
            //ll.NumberOfOccuranceElement(4);
            //ll.SearchUsingRecur(4);
            //ll.SearchUsingIterative(4);
            //ll.FindNthNodeFromBeg(2);
            //ll.nthNodeFromEnd2(2);
            //Console.WriteLine("-------------------------------");
            //ll.copyList();
           // ll.RemoveDuplicate();
           // ll.printNode();
            //ll.FindNthNodeFromBeg(3);
            //ll.FindLenght();
           // ll.FindLoop();
            //ll.ReverseList();
           // ll.printNode();
          // Console.ReadLine();

            //DoublyLinkedList dl = new DoublyLinkedList();
            //dl.AddNodeFront(1);
            //dl.AddNodeFront(2);
            //dl.AddNodeFront(3);
            //dl.AddNodeFront(4);
            //dl.AddNodeFront(5);
            //dl.ReverseList();
            //dl.printNode();
            //Console.ReadLine();


            //CircularSingleLinkedList dl = new CircularSingleLinkedList();
            //dl.AddNodeFront(1);
            //dl.AddNodeFront(2);
            //dl.AddNodeFront(3);
            //dl.AddNodeFront(4);
            //dl.AddNodeFront(5);
            // dl.DeleteNodeFront();
            // dl.DeleteNodeEnd();
            // dl.ReverseList();
            //dl.printNode();
            //Console.ReadLine();

            //BinarySearchTree bt = new BinarySearchTree();
            //bt.Insert(10);
            //bt.Insert(6);
            //bt.Insert(12);
            //bt.Insert(5);
            //bt.Insert(7);
            //bt.Insert(11);
            //bt.Insert(13);
            //bt.inorder();

            //  Console.WriteLine("-------------\n Find Max {0}",bt.FindMaxrec());
            //Console.WriteLine("-------");
            //bt.LevelOrderTravelsal();
            //   bt.FindSumOfNodes();
            //   bt.LeavesNodesCount();
            // bt.searchNode(50);
            // bt.delete(12);
            //  bt.inorder();
            // Console.ReadLine();

     //   }
    }
}
