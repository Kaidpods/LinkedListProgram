namespace LinkedListProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyQueue myQueue = new MyQueue();
            IntegerLinkedList MyList = new IntegerLinkedList();

            QueueTest(myQueue);
            LinkedListTest(MyList);
        }
        public static void QueueTest(MyQueue Queue)
        {
            Queue.Join(4);
            Queue.Join(11);
            Queue.Join(20);
            Queue.Join(8);
            
            Queue.DisplayUI();
        }
        public static void LinkedListTest(IntegerLinkedList List)
        {
            List.AddFirst(4);
            List.AddLast(11);
            List.AddFirst(20);
            List.AddFirst(8);
            
            List.DisplayUI();
        }
    }
}