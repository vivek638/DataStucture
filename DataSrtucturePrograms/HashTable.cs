using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPractice
{
    class HashTable
    {
        int DELETED = -2;
        int EMPTY = -1;
        int FILLED = 0;
        int tablesize;

        int[] array;
        int[] flag;
        public HashTable(int size)
        {
            array = new int[size+1];
            flag = new int[size+1];
            tablesize = size;
            for(int i=0;i<=size;i++)
            {
                    array[i]=EMPTY;
                    flag[i]=EMPTY;
            }
        }
        int computeHash(int key)
        {
            return key % tablesize;
        }
        public void InsertNode(int item)
        {
            int hashvalue = computeHash(item);
            for (int i = 0; i <= tablesize; i++)
            {
                if (flag[hashvalue] == EMPTY || flag[hashvalue] == DELETED)
                {
                    array[hashvalue] = item;
                    flag[hashvalue] = FILLED;
                    break;
                }
                else
                {
                    hashvalue = hashvalue + i;
                    hashvalue = hashvalue % tablesize;
                }
            }
        }
        public void DeleteNode(int item)
        {
            int hashvalue = computeHash(item);
            for (int i = 0; i <= tablesize; i++)
            {
                if (flag[hashvalue] == FILLED)
                {
                    array[hashvalue] = EMPTY;
                    flag[hashvalue] = DELETED;
                    break;
                }
                else
                {
                    hashvalue = hashvalue + i;
                    hashvalue = hashvalue % tablesize;
                }
            }
        }
        internal  bool FindNode(int value)
        {
            int hashValue = computeHash(value);
            for (int i = 0; i < tablesize; i++)
            {
                if (flag[hashValue] == EMPTY)
                {
                    return false;
                }

                if (flag[hashValue] == FILLED && array[hashValue] == value)
                {
                    return true;
                }

                hashValue = hashValue + i;
                hashValue = hashValue % tablesize;
            }
            return false;
        }

        public void Print()
        {
    
            for (int i = 0; i <= tablesize; i++)
            {
                if (flag[i] == FILLED)
                {
                    Console.WriteLine("HashTable item is : {0} ", array[i]);
                }
            }
        }
    }
}
