using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTRecursion
{
    class Node
    {
        public Node left;
        public Node right;
        public int Data { get; set; }

        public int FindTreeHeight(Node node)
        {
            int height = 1;
            if(node == null)
            {
                height = -1;
            }
            else
            {
                int lefth = FindTreeHeight(node.left);
                int righth = FindTreeHeight(node.right);

                if (lefth > righth)
                {
                    height = lefth+1;
                }
                else
                {
                    height = righth+1;
                }
            }

            return height;
        }
    }
}
