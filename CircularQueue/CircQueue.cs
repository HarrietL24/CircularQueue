using System;
using System.Collections.Generic;
using System.Text;

namespace CircularQueue
{
    class CircQueue
    {
        int[] cqueue;
        int front = 0;
        int end = 0;
        int max;
        int count = 0;

        public int values { get { return end; } }

        public CircQueue(int size)
        {
            max = size;
            cqueue = new int[max];

        }

        public void EnQueue(int item)
        {
            if (end < max)
            {
                cqueue[end] = item;
                end++;   
            }
            if (end == max)
            {
                end = 0;
            }
            else
            {
                throw new Exception("QUEUE FULL!");
            }

        }

        public int DeQueue()
        {
            if (front == end && end == count)
            {
                int removeitem = cqueue[front];
                front++;
                count--;
                return removeitem;

            }
            if (front == max)
            {
                front = 0;
                return 0;
           
            }
            else
            {
                throw new Exception("CIRCULAR QUEUE EMPTY!");
            }

            public void Print() 
            {
               /*for (int i = 0; i < ; i++)
                {
                    Console.WriteLine(cqueue[i]);
                }*/

            }


        }







    }

    
}
