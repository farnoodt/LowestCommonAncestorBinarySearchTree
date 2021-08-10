using System;

namespace LowestCommonAncestorBinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node tree = new Node(10);
            tree.left = new Node(-10);
            tree.left.right = new Node(8);
            tree.left.right.left = new Node(6);
            tree.left.right.right = new Node(9);
            tree.right = new Node(30);
            tree.right.left = new Node(25);
            tree.right.left.right = new Node(28);
            tree.right.right = new Node(60);
            tree.right.right.right = new Node(78);

            lowestCommonAncestor LCA = new lowestCommonAncestor();

            Console.WriteLine(LCA.FindLowestCommonAncestor(tree, tree.right.right.right, tree.right.left ).data);
        }
    }
}
