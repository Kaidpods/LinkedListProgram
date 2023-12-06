using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProgram
{
    public class MyQueue : QueueInterface
    {
        IntegerLinkedList myQueue = new IntegerLinkedList();

        public void Join(int value)
        {
            myQueue.AddFirst(value);
        }
        
        public bool IsEmpty()
        {
            return myQueue.IsEmpty();
        }
        public int Leave()
        {
            return myQueue.RemoveLast();
        }
        public void DisplayUI()
        {
            myQueue.DisplayUI();
        }

        public int Size() { return myQueue.Count; }

    }
}
