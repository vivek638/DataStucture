using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPractice
{
    public class Graph
    {
        int size;
        class AdjNode
        {
            int src;
            public int dest;
            int cost;
            public  AdjNode next;

            public AdjNode(int s, int d)
            {
                src = s;
               dest = d;
                cost = 1;
                next = null;
            }
        }
        class AdjList
        {
          public  AdjNode head;
        }
        AdjList[] glist;
        public Graph(int count)
        {
            size = count;
            glist = new AdjList[6];
            for(int i=0;i<count;i++)
            {
                glist[i] = new AdjList();
                glist[i].head = null;              
            }
        }

        public void AddEdge(int src, int dest)
        {
            AdjNode newNode = new AdjNode(src, dest);
            newNode.next = glist[src].head;
            glist[src].head = newNode;
        }


        public void Print()
        {
            for(int i=0;i<size;i++)
            {
                AdjNode head = glist[i].head;
                if (head != null)
                {
                    while (head != null)
                    {
                        Console.WriteLine("vertex v:"+i+"connected to edge:{0}",head.dest);
                        head = head.next;
                    }
                }
            }
        }
    }
}
