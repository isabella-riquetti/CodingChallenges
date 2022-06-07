using System.Collections.Generic;

namespace CodingChallenges.CrakingTheCodingInterviewAlgoExpert.Easy
{
    public static class SumBranch
    {
        public static List<int> Solution1(BinaryTree root)
        {
            var result = new List<int>();
            _SumBranch(result, root, 0);
            return result;
        }

        private static void _SumBranch(List<int> result, BinaryTree node, int sum)
        {
            sum += node.value;
            if (node.right == null && node.left == null)
            {
                result.Add(sum);
                return;
            }
            if (node.left != null)
                _SumBranch(result, node.left, sum);
            if (node.right != null)
                _SumBranch(result, node.right, sum);
        }
        
        public class BinaryTree
        {
            public int value;
            public BinaryTree left;
            public BinaryTree right;

            public BinaryTree(int value)
            {
                this.value = value;
                this.left = null;
                this.right = null;
            }
        }
    }
}
