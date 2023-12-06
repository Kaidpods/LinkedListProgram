using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProgram
{
/// <summary>
/// The MyQueue needs to follow this interface
/// </summary>
    internal interface QueueInterface
    {
        /// <summary>
        /// Adds a Value to the beggining of the queue
        /// </summary>
        /// <param name="value">Value to add</param>
        public void Join(int value);

        /// <summary>
        /// Removes the last Value from the queue and returns the number removed
        /// </summary>
        /// <returns>Value removed</returns>
        public int Leave();

        /// <summary>
        /// Checks to see if the queue is empty and returns based on that
        /// </summary>
        /// <returns>True if empty, else returns fale</returns>
        public bool IsEmpty();

        /// <summary>
        /// Gets the size of the queue
        /// </summary>
        /// <returns>Number of items in queue</returns>
        public int Size();
    }
}
