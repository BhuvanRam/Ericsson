using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ericsson
{
    class Program
    {
        static void Main(string[] args)
        {
            Node rootNode = new Node(14);

            BinarySearchTree.InsertNode(rootNode, 30);
            BinarySearchTree.InsertNode(rootNode, 15);
            BinarySearchTree.InsertNode(rootNode, 35);
            BinarySearchTree.InsertNode(rootNode, 5);
            BinarySearchTree.InsertNode(rootNode, 4);
            BinarySearchTree.InsertNode(rootNode, 6);

            BinarySearchTree.PrintAllLevelOrderTraversal(rootNode);
            Console.ReadKey();
            //Console.WriteLine("\n");
            //BinarySearchTree.PrintInOrderTraversal(rootNode);
            //Console.WriteLine("\n");
            //BinarySearchTree.PrintPreOrderTraversal(rootNode);
            //Console.WriteLine("\n");
            //BinarySearchTree.PrintPostOrderTraversal(rootNode);
            //Console.ReadKey();




            //PossibleStringPallindrome oPossibleStringPallindrome = new PossibleStringPallindrome();
            //oPossibleStringPallindrome.PerformStringCombinations("level");


            /*
            MergeSortedArray oMergeSortedArray = new MergeSortedArray();
            int[] aSortedArray = { 1, 3, 5, 7, 9 };
            int[] bSortedArray = { 2, 4, 6, 8, 10 };
            int[] result = oMergeSortedArray.MergeSortedArrays(aSortedArray, bSortedArray);
            foreach (var itemResult in result)
            {
                Console.Write("\t {0}", itemResult);
            }
            */

            /*
            GenericList<int> iGenericList = new GenericList<int>();
            iGenericList.Add(1);
            iGenericList.Add(2);
            iGenericList.Add(3);
            iGenericList.Add(4);
            iGenericList.Add(5);
            iGenericList.PrintValues();
            iGenericList.Add(6);
            iGenericList.PrintValues();            
            iGenericList.Remove(5);
            iGenericList.PrintValues();
            */

            /*
            GenericStack<int> iGenericStack = new GenericStack<int>();
            iGenericStack.Push(1);
            iGenericStack.Push(2);
            iGenericStack.Push(3);
            iGenericStack.Push(4);
            iGenericStack.Push(5);
            iGenericStack.Print();
            iGenericStack.Push(6);
            iGenericStack.Print();
            iGenericStack.Pop();
            iGenericStack.Print();
            Console.ReadKey();
            */

            /*
            GenericDictionary<int, int> gDictionary = new GenericDictionary<int, int>();
            gDictionary.Add(1, 1);
            gDictionary.Add(2, 2);
            gDictionary.Add(3, 3);
            gDictionary.Add(4, 4);
            gDictionary.Add(5, 5);
            gDictionary.print();
            gDictionary.Add(6, 5);
            gDictionary.print();
            gDictionary.Remove(6);
            gDictionary.Remove(1);
            gDictionary.Remove(3);
            gDictionary.print();
            Console.ReadKey();
            */

            /*
            GenericQueue<int> queueData = new GenericQueue<int>();
            queueData.Enqueue(1);
            queueData.Enqueue(2);
            queueData.Enqueue(3);
            queueData.Enqueue(4);
            queueData.Enqueue(5);
            queueData.Print();
            queueData.Dequeue();
            queueData.Dequeue();
            queueData.Print();
            Console.ReadKey();
            */
        }
    }
}
