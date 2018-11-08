using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPractice
{
    class BinarySearchTree
    {
        public Node root = null;

        public class Node
        {
            public int data;
            public Node lnode;
            public Node rnode;
            public Node(int d)
            {
                data = d;
                lnode = null;
                rnode = null;
            }

        }
        public void Insert(int key)
        {
            root = insertRec(root, key);
        }
        Node insertRec(Node root, int key)
        {
            if (root == null)
            {
                root = new Node(key);
                return root;
            }
            if (key < root.data)
                root.lnode = insertRec(root.lnode, key);
            else if (key > root.data)
                root.rnode = insertRec(root.rnode, key);
            return root;
        }

        public void inorder()
        {
            inorderRec(root);
        }
        void inorderRec(Node root)
        {
            if (root != null)
            {

                inorderRec(root.lnode);
                Console.WriteLine(root.data);
                inorderRec(root.rnode);

            }
        }

        Node FindMin(Node root)
        {
            if (root == null)
                return root;

            while (root.rnode != null)
            {
                root = root.rnode;
            }
            return root;
        }

        public void delete(int key)
        {
            root = delete(root, key);
        }
        public Node delete(Node root, int key)
        {
            if (root == null)
            {
                return root;
            }

            //case 1: single node
            else
            {
                if (root.data == key)
                {
                    if (root.lnode == null && root.rnode == null)
                        return root = null;
                    //case 2: one child
                    if (root.rnode == null)
                    {
                        root = root.lnode;

                    }
                    else if (root.lnode == null)
                    {
                        root = root.rnode;
                    }
                    else
                    {
                        // case 3: // children is there for root node
                        Node min = FindMin(root);
                        root.data = min.data;
                        root.rnode = delete(root.rnode, min.data);
                    }
                    return root;
                }

            }
            if (root.data > key)
            {
                root.lnode = delete(root.lnode, key);
            }
            else if (root.data < key)
            {
                root.rnode = delete(root.rnode, key);
            }
            return root;
        }

        public void searchNode(int key)
        {
            bool search = Search(root, key);
            if (search)
            {
                Console.WriteLine("Item found in tree");
            }
            else
            {
                Console.WriteLine("Item found in here not ttree");
            }
        }
        bool Search(Node root, int key)
        {
            bool result = false;

            if (root == null)
                return false;

            if (root.data == key)
                return true;

            else if (root.data < key)
            {
                return Search(root.rnode, key);
            }
            else if (root.data > key)
            {
                return Search(root.lnode, key);
            }
            return result;
        }

        public int FindMaxrec()
        {
            if (root == null)
                return root.data;
            else
            {
                while (root.rnode != null)
                    root = root.rnode;
                return root.data;
            }
        }

        public void FindHeight()
        {
            int data = FindMaxHeight(root);
            Console.WriteLine("Max Height is {0}", data);
        }

        int FindMaxHeight(Node root)
        {
            if (root == null)
                return -1;
            int l = FindMaxHeight(root.lnode);
            int r = FindMaxHeight(root.rnode);

            return (Math.Max(l, r) + 1);
        }
        public void NodesCount()
        {
            int data = NumberOfNodes(root);
            Console.WriteLine("Number of Node  is {0}", data);
        }

        int NumberOfNodes(Node root)
        {
            if (root == null)
            {
                return 0;
            }
            return NumberOfNodes(root.lnode) + NumberOfNodes(root.rnode) + 1;
        }

        public void LeavesNodesCount()
        {
            int data = NumberLeavesOfNodes(root);
            Console.WriteLine("Number of Leave Node  is {0}", data);
        }

        int NumberLeavesOfNodes(Node root)
        {
            if (root == null)
            {
                return 0;
            }
            if (root.lnode == null && root.rnode == null)
            {
                return 1;
            }
            return NumberLeavesOfNodes(root.lnode) + NumberLeavesOfNodes(root.rnode);
        }

        public void FindSumOfNodes()
        {
            int data = FindSum(root);
            Console.WriteLine("Sum of Nodes  is {0}", data);
        }

        int FindSum(Node root)
        {
            if (root == null)
            {
                return 0;
            }

            return FindSum(root.lnode) + FindSum(root.rnode) + root.data;
        }

        public void LevelOrderTravelsal()
        {
          LevelOrder(root);
        }

        void LevelOrder(Node root)
        {
            Queue<Node> qdata = new Queue<Node>();
            qdata.Enqueue(root);
            
            while (qdata.Count != 0)
            {
                Node Current = qdata.Dequeue();
                Console.WriteLine("data is {0} \n",Current.data);
                if (Current.lnode != null)
                {
                    qdata.Enqueue(Current.lnode);
                }
                if (Current.rnode != null)
                {
                    qdata.Enqueue(Current.rnode);
                }
             
            }
        }

    }
}

