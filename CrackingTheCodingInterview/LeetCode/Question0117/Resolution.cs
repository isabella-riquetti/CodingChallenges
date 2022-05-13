using System.Collections.Generic;

namespace CrackingTheCodingInterview.LeetCode.Question0117
{
    public static class Resolution
    {
        public static Node Solution1(Node root)
        {
            AddNextNode(0, new Dictionary<int, Node>(), root);
            return root;
        }

        public static void AddNextNode(int depth, Dictionary<int, Node> order, Node node)
        {
            if (node == null)
            {
                return;
            }

            order.TryGetValue(depth, out Node next);
            if (next != null)
            {
                node.next = next;
                order[depth] = node;
            }
            else
                order.Add(depth, node);

            if (node.right != null)
            {
                AddNextNode(depth + 1, order, node.right);
            }
            if (node.left != null)
            {
                AddNextNode(depth + 1, order, node.left);
            }
        }
    }
    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node next;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, Node _left, Node _right, Node _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }
}