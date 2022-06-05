namespace CodingChallenges.CrakingTheCodingInterviewAlgoExpert.Medium
{
    public static class InvertBinaryTree
    {
        public static void Solution1(BinaryTree tree)
        {
            Swap(tree);
        }

        private static void Swap(BinaryTree node)
        {
            var previousLeft = node.left;
            node.left = node.right;
            node.right = previousLeft;

            if (node.left != null)
                Swap(node.left);
            if (node.right != null)
                Swap(node.right);
        }

        public class BinaryTree
        {
            public int value;
            public BinaryTree left;
            public BinaryTree right;

            public BinaryTree(int value)
            {
                this.value = value;
            }
        }
    }
}