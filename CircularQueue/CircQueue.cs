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

        public CircQueue(int size)
        {
            max = size;
            cqueue = new int[max];

        }

        public void CircEnQueue(int item)
        {
            if (end < max)
            {
                cqueue[end] = item;
                end++;
            }
            else
            {
                throw new Exception("QUEUE FULL!");
            }

        }

        public int CircDeQueue()
        {
            if ()
            {

            }
            else
            {
                throw new Exception("CIRCULAR QUEUE EMPTY!");
            }
        }







    }

    
}
