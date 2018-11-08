using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPractice
{
    class SearchAlgorithm
    {
        public void GetMaxReaptedElement2(int[] arr)
        {
            int max =arr[0];
            int curr = arr[0];
            int maxCount=1;
            int currCount =1;
            Array.Sort(arr);
            for(int i=1;i<arr.Length-1;i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    currCount++;
                }
                else
                {
                    currCount = 1;
                    curr = arr[i];
                }
                if (maxCount < currCount)
                {
                    maxCount = currCount;
                    max = curr;
                }
            }
            Console.WriteLine("Max repeating character is {0} occuring {1} times", max, maxCount);
        }



        public void GetMaxReaptedElement(int[] arrr)
        {
            int maxElement =0;
            int count = 0;
            int maxCount =0;
            for (int i = 0; i < arrr.Length; i++)
            {
                for (int j = i+1; j < arrr.Length; j++)
                {
                    if (arrr[i] == arrr[j])
                    {
                        count++;
                        maxElement = arrr[i];
                    }
                }
                if (maxCount < count)
                {
                    maxCount = count;
                    maxElement = arrr[i];
                    count = 0;

                }
            }
            Console.WriteLine("Max repeating character is {0} occuring {1} times", maxElement, maxCount);
        }

        public void printReapitingUsingHash(int[] array)
        {
           HashSet<int> hs = new HashSet<int>();
            
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if(hs.Contains(array[i]))
                {
                    Console.WriteLine("Repeating Charater are {0}", array[i]);
                }
                else{
                    hs.Add(array[i]);
                }

            }
        }

        public void printReapitingInaRRAY2(int[] array)
        {
            Array.Sort(array);
            for (int i = 0; i < array.Length - 1; i++)
            {
                    if (array[i] == array[i+1])
                    {
                        Console.WriteLine("Repeating Charater are {0}", array[i]);
                    }
                
            }
    
        }

        public void printReapitingInaRRAY(int[] array)
        {
            for(int i=0;i<array.Length-1;i++)
             {
               for (int j = i+1; j < array.Length - 1; j++)
                 {
                     if (array[i] == array[j])
                     {
                         Console.WriteLine("Repeating Charater are {0}", array[i]);
                     }
                 }
             }
        }


        // Binary Search Algorithm � Recursive Way 
        public bool BinarySearchUsingRecursion(int[] array, int value, int low, int high)
        {
            int length = array.Length;
            int mid;
            if (low > high)
            {
                return false;
            }
            mid = (low + high) / 2;
            if (array[mid] == value)
            {
                return true;
                //break;
            }
            else if (array[mid] < value)
            {
              return  BinarySearchUsingRecursion(array, value, mid + 1, high);
            }
            else
            {
              return  BinarySearchUsingRecursion(array, value, low, mid - 1);
            }
           
        }
        // Binary Search Algorithm � Iterative Way 
        public bool BinarySearch(int[] array, int value)
        {
            int length = array.Length;
            int low = 0;
            int high = length - 1;
            int mid;
            while (low <= high)
            {
                mid = (low + high) / 2;
                if (array[mid] == value)
                {
                    return true;
                }
                else if (array[mid] < value)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return false;
        }

        public bool linearSearchSorted(int[] arr, int size, int value)
        {
            for (int i = 0; i < size; i++)
            {
                if (value == arr[i])
                {
                    return true;
                }
                else
                {
                    if (arr[i] > value)
                    {
                        return false;
                    }
                }
            } return false;
        }

        public bool linearSearchUnsorted(int[] arr, int size, int value)
        {
            for (int i = 0; i < size; i++)
            {
                if (value == arr[i])
                {
                    return true;
                }
            } return false;
        }
    }
}
