using LinkedListProgram;

namespace TestIntegerLinkedList
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddFirst()
        {
            IntegerLinkedList myList = new IntegerLinkedList();

            myList.AddFirst(3);
            myList.AddFirst(2);
            myList.AddFirst(1);

            Assert.AreEqual(3, myList.Count);
            Assert.AreEqual("1,2,3,", myList.ToString());
        }

        [TestMethod]
        public void TestAddLast()
        {
            IntegerLinkedList myList = new IntegerLinkedList();
            myList.AddFirst(1);
            myList.AddLast(6);
            myList.AddLast(7);
            myList.AddLast(8);

            Assert.AreEqual(4, myList.Count);
            Assert.AreEqual("1,6,7,8,", myList.ToString());
        }

        [TestMethod]
        public void TestAddLastEmpty()
        {
            IntegerLinkedList myList = new IntegerLinkedList();
            myList.AddLast(5);
            myList.AddLast(6);
            myList.AddLast(7);
            myList.AddLast(8);

            Assert.AreEqual(4, myList.Count);
            Assert.AreEqual("5,6,7,8,", myList.ToString());
        }


        [TestMethod]
        public void TestEmptyRemove()
        {
            IntegerLinkedList mylist = new IntegerLinkedList();

            Assert.ThrowsException<Exception>(() =>
            {
                mylist.RemoveLast();
            });
        }


        [TestMethod]
        public void TestOneRemove()
        {
            IntegerLinkedList mylist = new IntegerLinkedList();
            int val = 0;
            mylist.AddLast(42);
            val = mylist.RemoveLast();

            Assert.AreEqual(0, mylist.Count);
            Assert.AreEqual(42, val);
        }



        [TestMethod]
        public void TestMultiRemove()
        {
            IntegerLinkedList mylist = new IntegerLinkedList();
            int val = 0;
            mylist.AddLast(56);
            mylist.AddLast(74);
            mylist.AddLast(92);
            val = mylist.RemoveLast();
            Assert.AreEqual(2, mylist.Count);
            Assert.AreEqual(92, val);
            
            val = mylist.RemoveLast();            
            Assert.AreEqual(1, mylist.Count);
            Assert.AreEqual(74, val);

            val = mylist.RemoveLast();
            Assert.AreEqual(0, mylist.Count);
            Assert.AreEqual(56, val);

            Assert.AreEqual(true, mylist.IsEmpty());            
        }
    }
}