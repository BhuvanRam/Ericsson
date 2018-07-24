using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ericsson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ericsson.Tests
{
    [TestClass()]
    public class CircularQueueTests
    {
        CircularQueue<int> circularQueue;
        int[] newArray = { 1, 2, 3, 4 };

        [TestInitialize()]
        public void TestPrerquisites()
        {
            circularQueue = new CircularQueue<int>();
            foreach (var item in newArray)
                circularQueue.Enqueue(item);
        }

        [TestMethod()]
        public void EnqueueTest()
        {
            int[] actualResult = { 1, 2, 3, 4, 5 };
            circularQueue.Enqueue(5);
            int[] expectedResult = circularQueue.ReturnPrintedValues();
            CollectionAssert.AreEqual(actualResult, expectedResult);
        }

        [TestMethod()]
        public void DequeueTest()
        {
            int[] actualResult = { 2, 3, 4, 5 };
            circularQueue.Enqueue(5);
            circularQueue.Dequeue();
            int[] expectedResult = circularQueue.ReturnPrintedValues();
            CollectionAssert.AreEqual(actualResult, expectedResult);
        }

        [TestMethod()]
        public void EnqueueDequeueCircularTest()
        {
            int[] actualResult = { 2, 3, 4, 5, 6 };
            circularQueue.Dequeue();
            circularQueue.Enqueue(5);
            circularQueue.Enqueue(6);
            int[] expectedResult = circularQueue.ReturnPrintedValues();
            CollectionAssert.AreEqual(actualResult, expectedResult);

            circularQueue.Dequeue();
            circularQueue.Dequeue();
            circularQueue.Dequeue();
            actualResult = new int[2] { 5, 6 };
            expectedResult = circularQueue.ReturnPrintedValues();
        }
    }
}