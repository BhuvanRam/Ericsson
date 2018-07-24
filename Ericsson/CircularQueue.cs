using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ericsson
{
    public class CircularQueue<T>
    {
        int first = 0, rear = 0, arrayCount = 0;
        T[] queueData;
        int size = 5;

        public CircularQueue()
        {
            queueData = new T[size];
        }

        public void Enqueue(T data)
        {
            if (arrayCount == size)
                throw new Exception("Queue is full");

            if (rear == size)
                rear = 0;

            queueData[rear] = data;
            rear++;
            arrayCount++;
        }

        public T Dequeue()
        {
            if (arrayCount == 0)
                throw new Exception("Queue is Empty");

            if (first == size && arrayCount > 0)
                first = 0;

            T removedElement = queueData[first];
            queueData[first] = default(T);
            first++;
            arrayCount--;
            return removedElement;
        }

        public T[] ReturnPrintedValues()
        {
            if (arrayCount == 0)
                throw new Exception("No Values to Print");

            T[] resultArray = new T[arrayCount];
            int resultIndex = 0;

            if (arrayCount > 0)
            {

                if (first <= 0) // first is not in repetition
                {
                    for (int i = first; i < arrayCount; i++)
                        resultArray[resultIndex++] = queueData[i];
                }
                else if (first > 0)
                {
                    // Older Elements
                    for (int i = rear; i < queueData.Length; i++)
                        resultArray[resultIndex++] = queueData[i];

                    // Newer Elements
                    for (int i = 0; i < first; i++)
                        resultArray[resultIndex++] = queueData[i];

                }

            }
            return resultArray;
        }

    }
}
