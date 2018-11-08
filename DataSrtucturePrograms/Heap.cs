using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPractice
{
    class Heap
    {
        int heapsize;
        int[] heapArray;
        public void BuidMaxHeap(int[] array)
        {
          heapsize = array.Length;
          for (int i = (heapsize/2)+1; i >=0; i--)
          {
              max_heapify(array, i);
          }
          heapArray = array;
        }
        void max_heapify(int[] array, int i)
        {
            int left;
            int right;
            left = 2 * i;
            right = 2 * i + 1;
            int largest;

            if (left <= heapsize -1 && array[left] > array[i])
            {
                largest = left;
            }
            else
            {
                largest = i;
            }
            if (right <= heapsize -1 && array[right] > array[largest])
            {
                largest = right;
            }
            if (largest != i)
            {
                int temp = array[i];
                array[i] = array[largest];
                array[largest] = temp;
                max_heapify(array, largest);
            }
        }
        public virtual void print()
        {
            for (int i = 0; i <= heapsize -1; i++)
            {
                Console.WriteLine("value is :: " + heapArray[i]);
            }

        }
    }
}
