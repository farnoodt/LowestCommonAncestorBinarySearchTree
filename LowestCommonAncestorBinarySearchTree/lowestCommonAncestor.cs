using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowestCommonAncestorBinarySearchTree
{
    class lowestCommonAncestor
    {
        public Node FindLowestCommonAncestor(Node root, Node N1, Node N2)
        {
            
            if (root.data > Math.Max(N1.data, N2.data))
                return FindLowestCommonAncestor(root.left, N1, N2);
            else if (root.data < Math.Min( N1.data ,N2.data ))
                return FindLowestCommonAncestor(root.right, N1, N2);
            else 
                return root;

        }
    }
}
