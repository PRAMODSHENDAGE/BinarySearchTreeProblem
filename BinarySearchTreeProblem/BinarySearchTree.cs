﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeProblem
{
    public class BinarySearchTree<T> where T : IComparable
    {
        ///Variables
        int count = 0;
        bool result = false;
        Node<T> Root;
        Node<T> Current;
        ///<summary>
        ///UC-1 - Insert Data in Binary Search Tree.
        ///</summary>
        public void InsertData(T data)
        {
            ///Checks the root node is null or not.
            if (Root ==null)
            {
                this.Root = new Node<T>(data);
                this.Current = Root;
                count++;
                return;
            }
            ///If current data is less than data in root then current position node will
            ///point to left else to right.
            if (this.Current.data.CompareTo(data) > 0)
            {
                ///Checks if left node is null.
                if (this.Current.leftNode == null)
                {
                    this.Current.leftNode = new Node<T>(data);
                    this.Current = Root;
                    count++;
                }
                else
                {
                    this.Current = this.Current.leftNode;
                    InsertData(data);
                }
            }
            else
            {
                ///Checks if right node is null.
                if (this.Current.rightNode == null)
                {
                    this.Current.rightNode = new Node<T>(data);
                    this.Current = Root;
                    count++;
                }
                else
                {
                    this.Current = this.Current.rightNode;
                    InsertData(data);
                }
            }
        }
        ///<summary>
        ///Gets the root node.
        ///</summary>
        public Node<T> GetRoot()
        {
            return this.Root;
        }
        ///<summary>
        ///UC-2 - Gets the Size of Binary Search Tree.
        ///</summary>
        public int GetSize()
        {
            return count;
        }
        ///<summary>
        ///UC-3 - Search Element in Binary Search Tree.
        ///</summary>
        public bool SearchTree(int data, Node<T> node)
        {
            if (node == null)
            {
                return false;
            }
            else
            {
                if (this.Current.data.Equals(data))
                {
                    result = true;
                }
                else if (this.Current.data.CompareTo(data) > 0)
                {
                    this.Current = this.Current.leftNode;
                    SearchTree(data, Current);
                }
                return result;
            }
        }
        ///<summary>
        ///Display the Noed Elements from BST.
        ///</summary>
        public void Display (Node<T> node)
        {
            if (node != null)
            {
                Display(node.leftNode);
                Console.WriteLine("Element in Binary Search Tree is: " + node.data);
                Display(node.rightNode);
            }
        }
    }
}
