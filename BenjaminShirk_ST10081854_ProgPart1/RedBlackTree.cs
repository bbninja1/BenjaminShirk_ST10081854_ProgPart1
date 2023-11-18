﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenjaminShirk_ST10081854_ProgPart1
{
    enum RedBlack
    {
        Red,
        Black
    }
    internal class RedBlackTree
    {
        public class Node
        {
            public RedBlack colour;
            public Node left;
            public Node right;
            public Node parent;
            public int data;
            public string desc;

            public Node(int data) { this.data = data; }
            public Node(RedBlack colour) { this.colour = colour; }
            public Node(int data, RedBlack colour) { this.data = data; this.colour = colour; }
            public Node(int data, string desc) { this.data = data; this.desc = desc; }

        }

        private Node root;

        public RedBlackTree()
        {
        }

        private void LeftRotate(Node X)
        {
            Node Y = X.right; // set Y
            X.right = Y.left;//turn Y's left subtree into X's right subtree
            if (Y.left != null)
            {
                Y.left.parent = X;
            }
            if (Y != null)
            {
                Y.parent = X.parent;//link X's parent to Y
            }
            if (X.parent == null)
            {
                root = Y;
            }
            if (X == X.parent.left)
            {
                X.parent.left = Y;
            }
            else
            {
                X.parent.right = Y;
            }
            Y.left = X; //put X on Y's left
            if (X != null)
            {
                X.parent = Y;
            }

        }

        private void RightRotate(Node Y)
        {
            // right rotate is simply mirror code from left rotate
            Node X = Y.left;
            Y.left = X.right;
            if (X.right != null)
            {
                X.right.parent = Y;
            }
            if (X != null)
            {
                X.parent = Y.parent;
            }
            if (Y.parent == null)
            {
                root = X;
            }
            if (Y == Y.parent.right)
            {
                Y.parent.right = X;
            }
            if (Y == Y.parent.left)
            {
                Y.parent.left = X;
            }

            X.right = Y;//put Y on X's right
            if (Y != null)
            {
                Y.parent = X;
            }
        }

        public void DisplayTree()
        {
            if (root == null)
            {
                Console.WriteLine("Nothing in the tree!");
                return;
            }
            if (root != null)
            {
                InOrderDisplay(root);
            }
        }

        public Node Find(int key)
        {
            bool isFound = false;
            Node temp = root;
            Node item = null;
            while (!isFound)
            {
                if (temp == null)
                {
                    break;
                }
                if (key < temp.data)
                {
                    temp = temp.left;
                }
                if (key > temp.data)
                {
                    temp = temp.right;
                }
                if (key == temp.data)
                {
                    isFound = true;
                    item = temp;
                }
            }
            if (isFound)
            {
                Console.WriteLine("{0} was found", key);
                return temp;
            }
            else
            {
                Console.WriteLine("{0} not found", key);
                return null;
            }
        }

        public void Insert(int item)
        {
            Node newItem = new Node(item);
            if (root == null)
            {
                root = newItem;
                root.colour = RedBlack.Black;
                return;
            }
            Node Y = null;
            Node X = root;
            while (X != null)
            {
                Y = X;
                if (newItem.data < X.data)
                {
                    X = X.left;
                }
                else
                {
                    X = X.right;
                }
            }
            newItem.parent = Y;
            if (Y == null)
            {
                root = newItem;
            }
            else if (newItem.data < Y.data)
            {
                Y.left = newItem;
            }
            else
            {
                Y.right = newItem;
            }
            newItem.left = null;
            newItem.right = null;
            newItem.colour = RedBlack.Red;//colour the new node red
            InsertFixUp(newItem);//call method to check for violations and fix
        }

        private void InOrderDisplay(Node current)
        {
            if (current != null)
            {
                InOrderDisplay(current.left);
                Console.Write("({0}) ", current.data);
                InOrderDisplay(current.right);
            }
        }
  
        private void InsertFixUp(Node item)
        {
            //Checks Red-Black Tree properties
            while (item != root && item.parent.colour == RedBlack.Red)
            {
                /*We have a violation*/
                if (item.parent == item.parent.parent.left)
                {
                    Node Y = item.parent.parent.right;
                    if (Y != null && Y.colour == RedBlack.Red)//Case 1: uncle is red
                    {
                        item.parent.colour = RedBlack.Black;
                        Y.colour = RedBlack.Black;
                        item.parent.parent.colour = RedBlack.Red;
                        item = item.parent.parent;
                    }
                    else //Case 2: uncle is black
                    {
                        if (item == item.parent.right)
                        {
                            item = item.parent;
                            LeftRotate(item);
                        }
                        //Case 3: recolour & rotate
                        item.parent.colour = RedBlack.Black;
                        item.parent.parent.colour = RedBlack.Red;
                        RightRotate(item.parent.parent);
                    }

                }
                else
                {
                    //mirror image of code above
                    Node X = null;

                    X = item.parent.parent.left;
                    if (X != null && X.colour == RedBlack.Black)//Case 1
                    {
                        item.parent.colour = RedBlack.Red;
                        X.colour = RedBlack.Red;
                        item.parent.parent.colour = RedBlack.Black;
                        item = item.parent.parent;
                    }
                    else //Case 2
                    {
                        if (item == item.parent.left)
                        {
                            item = item.parent;
                            RightRotate(item);
                        }
                        //Case 3: recolour & rotate
                        item.parent.colour = RedBlack.Black;
                        item.parent.parent.colour = RedBlack.Red;
                        LeftRotate(item.parent.parent);

                    }

                }
                root.colour = RedBlack.Black;//re-colour the root black as necessary
            }
        }

        public void Delete(int key)
        {
            //first find the node in the tree to delete and assign to item pointer/reference
            Node item = Find(key);
            Node X = null;
            Node Y = null;

            if (item == null)
            {
                Console.WriteLine("Nothing to delete!");
                return;
            }
            if (item.left == null || item.right == null)
            {
                Y = item;
            }
            else
            {
                Y = TreeSuccessor(item);
            }
            if (Y.left != null)
            {
                X = Y.left;
            }
            else
            {
                X = Y.right;
            }
            if (X != null)
            {
                X.parent = Y;
            }
            if (Y.parent == null)
            {
                root = X;
            }
            else if (Y == Y.parent.left)
            {
                Y.parent.left = X;
            }
            else
            {
                Y.parent.left = X;
            }
            if (Y != item)
            {
                item.data = Y.data;
            }
            if (Y.colour == RedBlack.Black)
            {
                DeleteFixUp(X);
            }

        }

        private void DeleteFixUp(Node X)
        {

            while (X != null && X != root && X.colour == RedBlack.Black)
            {
                if (X == X.parent.left)
                {
                    Node W = X.parent.right;
                    if (W.colour == RedBlack.Red)
                    {
                        W.colour = RedBlack.Black; //case 1
                        X.parent.colour = RedBlack.Red; //case 1
                        LeftRotate(X.parent); //case 1
                        W = X.parent.right; //case 1
                    }
                    if (W.left.colour == RedBlack.Black && W.right.colour == RedBlack.Black)
                    {
                        W.colour = RedBlack.Red; //case 2
                        X = X.parent; //case 2
                    }
                    else if (W.right.colour == RedBlack.Black)
                    {
                        W.left.colour = RedBlack.Black; //case 3
                        W.colour = RedBlack.Red; //case 3
                        RightRotate(W); //case 3
                        W = X.parent.right; //case 3
                    }
                    W.colour = X.parent.colour; //case 4
                    X.parent.colour = RedBlack.Black; //case 4
                    W.right.colour = RedBlack.Black; //case 4
                    LeftRotate(X.parent); //case 4
                    X = root; //case 4
                }
                else //mirror code from above with "right" & "left" exchanged
                {
                    Node W = X.parent.left;
                    if (W.colour == RedBlack.Red)
                    {
                        W.colour = RedBlack.Black;
                        X.parent.colour = RedBlack.Red;
                        RightRotate(X.parent);
                        W = X.parent.left;
                    }
                    if (W.right.colour == RedBlack.Black && W.left.colour == RedBlack.Black)
                    {
                        W.colour = RedBlack.Black;
                        X = X.parent;
                    }
                    else if (W.left.colour == RedBlack.Black)
                    {
                        W.right.colour = RedBlack.Black;
                        W.colour = RedBlack.Red;
                        LeftRotate(W);
                        W = X.parent.left;
                    }
                    W.colour = X.parent.colour;
                    X.parent.colour = RedBlack.Black;
                    W.left.colour = RedBlack.Black;
                    RightRotate(X.parent);
                    X = root;
                }
            }
            if (X != null)
                X.colour = RedBlack.Black;
        }

        private Node Minimum(Node X)
        {
            while (X.left.left != null)
            {
                X = X.left;
            }
            if (X.left.right != null)
            {
                X = X.left.right;
            }
            return X;
        }

        private Node TreeSuccessor(Node X)
        {
            if (X.left != null)
            {
                return Minimum(X);
            }
            else
            {
                Node Y = X.parent;
                while (Y != null && X == Y.right)
                {
                    X = Y;
                    Y = Y.parent;
                }
                return Y;
            }
        }

    }
}

