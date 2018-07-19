using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ericsson
{
    // Less than the root Node value will be left side node and Greater than the root Node value will be right side node
    class BinarySearchTree
    {
        public static Node InsertNode(Node node, int value)
        {
            if (node == null)
                return new Node(value);

            if (value > node.value)
            {
                if (node.right == null)
                {
                    node.right = new Node(value);
                    return node;
                }
                else
                    InsertNode(node.right, value);
            }
            else if (value < node.value)
            {
                if (node.left == null)
                {
                    node.left = new Node(value);
                    return node;
                }
                else
                    InsertNode(node.left, value);
            }

            return node;
        }

        public static bool SearchNode(Node node, int value)
        {
            bool isSearch = false;
            if (node == null)
                return false;

            if (node != null && node.value == value)
                return true;

            if (value > node.value)
                SearchNode(node.right, value);
            if (value < node.value)
                SearchNode(node.left, value);

            return isSearch;
        }

        // Left - Root - Right
        public static void PrintInOrderTraversal(Node node)
        {
            if (node != null)
            {
                PrintInOrderTraversal(node.left);
                Console.Write("\t {0}", node.value);
                PrintInOrderTraversal(node.right);
            }
        }

        //Root - Left - Right
        public static void PrintPreOrderTraversal(Node node)
        {
            if (node != null)
            {
                Console.Write("\t {0}", node.value);
                PrintPreOrderTraversal(node.left);
                PrintPreOrderTraversal(node.right);
            }
        }

        // Left - Right - Root
        public static void PrintPostOrderTraversal(Node node)
        {
            if (node != null)
            {
                PrintPostOrderTraversal(node.left);
                PrintPostOrderTraversal(node.right);
                Console.Write("\t {0}", node.value);
            }
        }

        /*
         * All Level Order - 14, 5, 30, 4, 16, 15, 35
         */
        public static void PrintAllLevelOrderTraversal(Node node)
        {
            int height = HeightofTheTree(node);
            for (int i = 0; i < height; i++)
            {
                Console.WriteLine("\n");
                PrintValues(node, i);
            }
        }

        private static void PrintValues(Node node, int level)
        {
            if (node == null)
                return;

            if (level == 0)
                Console.Write("\t {0}", node.value);
            else
            {
                PrintValues(node.left, level - 1);
                PrintValues(node.right, level - 1);
            }
        }


        private static int HeightofTheTree(Node node)
        {
            if (node == null)
                return 0;
            else
            {
                int left = HeightofTheTree(node.left);
                int right = HeightofTheTree(node.right);

                if (left > right)
                    return left + 1;
                else
                    return right + 1;
            }
        }

        public int FindTheCommonNode(int aValue,int bValue)
        {
            int commonNode = -1;

            return commonNode;
        }


    }

    public class Node
    {
        public Node left;
        public Node right;
        public int value;
        public Node(int _value)
        {
            value = _value;
        }
    }
}
