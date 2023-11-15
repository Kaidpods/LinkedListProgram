namespace LinkedListProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntegerLinkedList linkList = new IntegerLinkedList();

            linkList.AddLast(4);
            linkList.AddLast(6);
            linkList.AddLast(10);
            linkList.AddLast(3);


            linkList.DisplayUI();
        }
    }
}