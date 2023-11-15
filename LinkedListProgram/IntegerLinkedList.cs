using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedListProgram
{
    public class IntegerLinkedList
    {
        private int count;
        private Node? start;
        public IntegerLinkedList() 
        { 
            ResetLinkedList();
        }
        private void ResetLinkedList()
        {
            count = 0;
            start = null;
        }
        public int Count { get => count;}


        /// <summary>
        /// Add something to the start of the Linked List
        /// </summary>
        /// <param name="value">Data value to add</param>
        public void AddFirst(int value) 
        {
            count++;

            //Creates a new node for adding to the linked list
            Node newNode = new Node(value);

            //Is there any other node present?
            if (IsEmpty())
            {  
                start = newNode;
            }
            else
            {
                newNode.next = start;
                start = newNode;
            }
        }
        /// <summary>
        /// Adds something to the end of the Linked List
        /// </summary>
        /// <param name="value">Data value to add</param>
        public void AddLast(int value)
        {

            //Creates a new node for adding to the linked list
            Node newNode = new Node(value);

            //Is there any other node present?
            if (IsEmpty())
            {
                start = newNode;
                
            }
            else
            {
                //Start
                Node? nodeCurrent = start;

                //Loop through all the nodes until Node.next == null
                while (nodeCurrent.next != null) 
                {
                    nodeCurrent = nodeCurrent.next;
                }

                nodeCurrent.next = newNode;
            }
            count++;
        }
        /// <summary>
        /// Removes all nodes from the list and resets it
        /// </summary>
        public void Destroy()
        {
            ResetLinkedList();
        }
        /// <summary>
        /// Display the contents of the linked list from start to end
        /// </summary>
        public void DisplayUI()
        {
            
            if (!IsEmpty())
            {
                Console.WriteLine("Count: {0}", Count);

                //output the value in the first node
                Console.Write(start.value + ",");

                //get the next node
                Node? nextNode = start.next;

                //start and keeping looping until the next node points to null(end of the list)
                while (nextNode != null)
                {
                    Console.Write(nextNode.value + ",");
                    nextNode = nextNode.next;
                }
            }
            else
            {
                Console.WriteLine("Nothing to show");
            }
            Console.WriteLine("\nEnd of the list");
        }
        /// <summary>
        /// Checks to see if the list is empty
        /// </summary>
        /// <returns>True if empty</returns>
        public bool IsEmpty()
        {
            return count==0;
        }
        /// <summary>
        /// Removes the first of the linked list
        /// </summary>
        /// <returns>The removed number</returns>
        public int RemoveFirst()
        {
            
            int returnedNumber = start.value;

            //Is there any other node present?
            if (IsEmpty())
            {
                throw new Exception("There is nothing to remove");
            }
            else
            {
                
                start = start.next;
            }
            count--;
            return returnedNumber; ;
        }
        /// <summary>
        /// Removes the last of the linked list
        /// </summary>
        /// <returns>The removed number</returns>
        public int RemoveLast()
        {

            //Is there any other node present?
            if (IsEmpty())
            {
                throw new Exception("There is nothing to remove");
            }
            else
            {
                //Start
                Node? nodeCurrent = start;

                //Loop through all the nodes until on the last node
                for (int i = 1; i < count; i++)
                {
                    nodeCurrent = nodeCurrent.next;
                }
                int returnedNumber = nodeCurrent.value;
                nodeCurrent.next = null;
                count--;
                return returnedNumber;
            }

        }
        override public string ToString()
        {
            string output = "";
            if (!IsEmpty())
            {
                output = start.value + ",";

                Node nextNode = start.next;

                //loop until nextNode == null
                while (nextNode != null)
                {
                    output = output + nextNode.value + ",";
                    nextNode = nextNode.next;
                }
            }
            return output;
        }
        private class Node
        {
            public int value;
            public Node? next;

            public Node(int n)
            {
                value = n;
                next = null;
            }
        }
    }
}
