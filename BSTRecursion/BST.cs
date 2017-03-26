using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTRecursion
{
    class BST
    {
        Node root = null;

        public void Insert(int value)
        {
            if (root != null)
            {
                bool foundPlaceToInsert = false;
                Node newNode = new Node();
                newNode.Data = value;

                Node pointer = root;

                while (foundPlaceToInsert == false)
                {
                    if (pointer.Data > value)
                    {
                        if (pointer.left != null)
                        {
                            pointer = pointer.left;
                        }
                        else
                        {
                            pointer.left = newNode;
                            foundPlaceToInsert = true;
                        }
                    }
                    else
                    {
                        if (pointer.right != null)
                        {
                            pointer = pointer.right;
                        }
                        else
                        {
                            pointer.right = newNode;
                            foundPlaceToInsert = true;
                        }
                    }
                }
            }
            else
            {
                root = new Node();
                root.Data = value;
            }
        }

        public void InsertRecursively(int value)
        {
            InsertRecursively(ref root, value);
        }

        private void InsertRecursively(ref Node pointer, int value)
        {
            if (pointer != null)
            {
                if (pointer.Data > value)
                {
                    InsertRecursively(ref pointer.left, value);
                }
                else
                {
                    InsertRecursively(ref pointer.right, value);

                }
            }
            else
            {
                Node newNode = new Node();
                newNode.Data = value;
                pointer = newNode;
            }
        }

        public bool Search(int value)
        {
            Node pointer = root;
            bool foundData = false;

            while (pointer != null && foundData == false)
            {
                if (pointer.Data > value)
                {
                    pointer = pointer.left;
                }
                else if (pointer.Data < value)
                {
                    pointer = pointer.right;
                }
                else
                {
                    foundData = true;
                }
            }

            return foundData;
        }

        public bool SearchRecursively(int value)
        {
            return SearchRecursively(root, value);
        }

        private bool SearchRecursively(Node pointer, int value)
        {
            bool foundData = false;

            if (pointer != null)
            {
                if (pointer.Data < value)
                {
                    foundData = SearchRecursively(pointer.right, value);
                }
                else if (pointer.Data > value)
                {
                    foundData = SearchRecursively(pointer.left, value);
                }
                else
                {
                    foundData = true;
                }
            }

            return foundData;
        }

        public int HighestValue()
        {
            int maxValue = -1;
            Node pointer = root;

            while (pointer != null)
            {
                maxValue = pointer.Data;
                pointer = pointer.right;
            }

            return maxValue;
        }

        public int HighestValueRecursive()
        {
            return HighestValueRecursive(root);
        }

        private int HighestValueRecursive(Node pointer)
        {
            if(pointer.right == null)
            {
                return pointer.Data;
            }
            else
            {
                return HighestValueRecursive(pointer.right);
            }
        }

        public List<int> InOrder()
        {
            return InOrder(root);
        }

        private List<int> InOrder(Node pointer)
        {
            List<int> listInOrder = new List<int>();
            if(pointer != null)
            {
                listInOrder.AddRange(InOrder(pointer.left));
                listInOrder.Add(pointer.Data);
                listInOrder.AddRange(InOrder(pointer.right));
            }
            return listInOrder;
        }

        public List<int> LevelOrder()
        {
            return LevelOrder(root);
        }

        private List<int> LevelOrder(Node pointer)
        {
            List<int> listInLevelOrder = new List<int>();

            int height = pointer.FindTreeHeight(pointer)+1;

            for(int i = 1; i<= height; i++)
            {
                listInLevelOrder.AddRange(PrintGivenLevel(pointer, i));
            }

            return listInLevelOrder;
        }

        private List<int> PrintGivenLevel(Node pointer, int level)
        {
            List<int> listOfLevelData = new List<int>();

            if(pointer != null)
            {
                if(level == 1)
                {
                    listOfLevelData.Add(pointer.Data);
                }
                else
                {
                    listOfLevelData.AddRange(PrintGivenLevel(pointer.left, level - 1));
                    listOfLevelData.AddRange(PrintGivenLevel(pointer.right, level - 1));
                }
            }

            return listOfLevelData;
        }

    }
}
