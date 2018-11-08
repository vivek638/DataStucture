using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPractice
{
    class SortingAlgorithm
    {
        public virtual void QuickSort(int [] arr)
        {
            int size = arr.Length;
            quickSortUtil(arr, 0, size - 1);
        }

        private void swap(int[] arr, int first, int second)
        {
            int temp = arr[first];
            arr[first] = arr[second];
            arr[second] = temp;
        }

        private void quickSortUtil(int[] arr, int lower, int upper)
        {
            if (upper <= lower)
            {
                return;
            }
            int pivot = arr[lower];
            int start = lower;
            int stop = upper;

            while (lower < upper)
            {
                while (arr[lower] <= pivot && lower < upper)
                {
                    lower++;
                }
                while (arr[upper] > pivot && lower <= upper)
                {
                    upper--;
                }
                if (lower < upper)
                {
                    swap(arr, upper, lower);
                }
            }
            swap(arr, upper, start); //upper is the pivot position

            quickSortUtil(arr, start, upper - 1); //pivot -1 is the upper for left sub array.
            quickSortUtil(arr, upper + 1, stop); // pivot + 1 is the lower for right sub array.
        }

        //MergeSort
        public void MergeSort(int[] array)
        {
            int size = array.Length;
            int[] tempArray = new int[size];
            MergeStart(array, tempArray, 0, size - 1);
        }

        public void MergeStart(int[] array, int[] tempArray, int LowerIndex, int highIndex)
        {
            if (LowerIndex >= highIndex)
            {
                return;
            }
            int MiddleIndex = (LowerIndex + highIndex) / 2;
            MergeStart(array, tempArray, LowerIndex, MiddleIndex);
            MergeStart(array, tempArray, MiddleIndex + 1, highIndex);
            Merge(array, tempArray, LowerIndex, MiddleIndex, highIndex);
        }

        public void Merge(int[] array, int[] tempArray, int LowerIndex, int MiddleIndex, int highIndex)
        {
            int LowerStart = LowerIndex;
            int LowerStop = MiddleIndex;
            int HigherStart = MiddleIndex + 1;
            int HigherStop = highIndex;
            int count = LowerIndex;
            while (LowerStart <= LowerStop && HigherStart<= HigherStop)
            {
                if (array[LowerStart] < array[HigherStart])
                {
                    tempArray[count++] = array[LowerStart++];
                }
                else
                {
                    tempArray[count++] = array[HigherStart++];
                }
            }
            while (LowerStart <= LowerStop)
            {             
                    tempArray[count++] = array[LowerStart++];            
            }
            while (HigherStart <= HigherStop )
            {                
                    tempArray[count++] = array[HigherStart++];               
            }
            for (int i = 0; i <= highIndex; i++)
            {
               array[i]= tempArray[i];
            }
        }

        public static void InsertionSort(int[] arr)
        {
            int temp, j;
            for (int i = 0; i < arr.Length; i++)
            {
                 temp = arr[i];
                for (j = i; j >0 && arr[j-1]>temp; j--)
                {
                   arr[j] = arr[j - 1];
                }
                arr[j] = temp;
            }
        }

        public void BubbleSort(int[] arr)
        {
            int size = arr.Length - 1;
            int swapped = 1;
            for (int i = 0; i < size && swapped == 1; i++)
            {
                swapped = 0;
                for (int j = 0; j < size - i; j++)
                {

                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = 1;
                    }
                }
            }
        }

        public static void Main(string[] args)
        {
            int[] array = { 22, 34, 35, 25, 1, 2, 3, 4, 5, 6, 7, 8, 9, 24 };
            SortQuick(array, 0, array.Length - 1);
           // InsertionSort(array);
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);

            Console.ReadLine();
        }

        public static void SortQuick(int[] array, int low, int high)
        {
            if (low < high)
            {
                int partition = quicksort(array, low, high);
                SortQuick(array, low, partition);
                SortQuick(array, partition + 1, high);
            }
        }
        public static int quicksort(int[] arry, int low, int high)
        {
            int pivot = arry[low];

            while (arry[low] < pivot)
                low++;

            while (arry[high] > pivot)
                high--;

            if (low < high)
            {
                int temp = arry[high];
                arry[high] = arry[low];
                arry[low] = temp;
            }
            else
            {
                return high;
            }
            return -1;
        }
    }
}
