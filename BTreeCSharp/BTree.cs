using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace BTreeCSharp
{
    class BTreeNode
    {
        public int data;
        public BTreeNode left;
        public BTreeNode right;
        public BTreeNode(int d)
        {
            data = d;
            left = null;
            right = null;
        }
    };
    class BTree
    {
        // function constructBTree: generate search binary tree with root = 1, 2,...,n 
        // 2 paramaters: start = 1, and n is number of nodes 
        // using vector<BTreeNode*> to store all binary tree that can generate
        // using vectors because their size can change dynamically

        public ArrayList constructBTree(int start, int n)
        {
            ArrayList result = new ArrayList();
            if (start > n)
            {
                // function push_back : add element at the end
                result.Add(null);

                return result;
            }
            int i = start;
            // Build all possible search binary tree with root = 1, 2, ..., n
            while (i <= n)
            {
                ArrayList left = constructBTree(start, i - 1);
                ArrayList right = constructBTree(i + 1, n);

                for (int l = 0; l < left.Count; l++)
                {
                    for (int r = 0; r < right.Count; r++)
                    {
                        BTreeNode node = new BTreeNode(i);
                        node.left = (BTreeNode)left[l];
                        node.right = (BTreeNode)right[r];
                        result.Add(node);
                    }
                }
                i++;
            }
            return result;
        }


        // Output binary trees by preorder

        public void outputTree(BTreeNode t)
        {
            if (t != null)
            {
                Console.Write(t.data);
                outputTree(t.left);
                outputTree(t.right);
            }
        }

    }

}
