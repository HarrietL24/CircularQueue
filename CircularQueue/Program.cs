using System;

namespace CircularQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            CircQueue c = new CircQueue(10);

            c.EnQueue(90);
            c.EnQueue(78);
            c.EnQueue(2);
            c.EnQueue(4);
            c.DeQueue();
            c.DeQueue();


        }
    }
}
