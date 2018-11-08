using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPractice
{
    class StackUsingArray
    {
        int top = -1;
        int CAPACITY = 100;
        int[] stack;
        int size;
      public StackUsingArray()
        {
            stack = new int[CAPACITY];
            size = CAPACITY;
        }

        StackUsingArray(int newsize)
        {
            stack = new int[newsize];
            size = newsize;
        }

        bool IsEmpty()
        {
            if (top == -1)
            {
                return true;
            }
            return false;
        }

        bool IsFull()
        {
            if (top == size)
            {
                return true;
            }
            return false;
        }

        public void push(int item)
        {
            if (IsFull())
            {
                Console.WriteLine("stack is full");
            }
            else
            {
                ++top;
                stack[top] = item;             
            }
        }
        public void pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("stack is empty");
            }
            else
            {
               int value = stack[top];
               Console.WriteLine("Deleted item from stack is {0}:",value);
                top--;
            }
        }
        public void print()
        {
            if (IsEmpty())
            {
                Console.WriteLine("stack is empty");
            }
            else
            {
                for (int i = top; i > -1;i-- )
                {

                    Console.WriteLine("Stack item is:{0}", stack[i]);

                }
            }
        }
    }
}
