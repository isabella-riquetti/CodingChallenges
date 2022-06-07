using System;
using System.Collections.Generic;

namespace CodingChallenges.CrakingTheCodingInterviewAlgoExpert.Easy
{
    public static class FindClosestValueInBst
    {
        // Time: O(n)
        // Space: O(1)
        public static int Solution1(BST tree, int target)
        {
            var node = tree;
            int lessDifference = Math.Abs(node.value - target);
            int nodeWithLessDifference = node.value;

            while (node != null)
            {
                if (Math.Abs(target - node.value) < lessDifference)
                {
                    lessDifference = Math.Abs(target - node.value);
                    nodeWithLessDifference = node.value;
                }

                node = target < node.value && node.left != null ? node.left : node.right;
            }

            return nodeWithLessDifference;
        }

        // Time: O(n)
        // Space: O(n)
        public static int Solution2(BST tree, int target)
        {
            return _GetClosest(target, tree.value, tree);
        }

        private static int _GetClosest(int target, int closest, BST node)
        {
            if (Math.Abs(target - closest) > Math.Abs(target - node.value))
                closest = node.value;

            if (target < node.value && node.left != null)
                return _GetClosest(target, closest, node.left);
            if (target > node.value && node.right != null)
                return _GetClosest(target, closest, node.right);

            return closest;
        }


        public class BST
        {
            public int value;
            public BST left;
            public BST right;

            public BST(int value)
            {
                this.value = value;
            }
        }
    }
}
