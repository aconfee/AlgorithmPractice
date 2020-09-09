using System;
using System.Linq;

namespace AlgorithmsPractice
{
    public static class BuildTree
    {
        public static Tree<int> Run(int[] inorder, int[] preorder)
        {
            if (inorder == null || inorder.Length == 0 || preorder == null || preorder.Length == 0) return null;

            var root = new Tree<int>();
            root.value = preorder[0];

            if (preorder.Length == 1) return root;

            var inorderRootIndex = Array.IndexOf(inorder, preorder[0]);

            if (inorderRootIndex > 0)
            {
                var count = inorderRootIndex;
                var leftInorderArray = inorder.ToList().GetRange(0, count).ToArray();
                var leftPreorderArray = preorder.ToList().GetRange(1, count).ToArray();
                root.left = Run(leftInorderArray, leftPreorderArray);
            }

            if (inorderRootIndex < inorder.Length - 1)
            {
                var count = inorder.Length - (inorderRootIndex + 1);
                var rightInorderArray = inorder.ToList().GetRange(inorderRootIndex + 1, count).ToArray();
                var rightPreorderArray = preorder.ToList().GetRange(preorder.Length - count, count).ToArray();
                root.right = Run(rightInorderArray, rightPreorderArray);
            }

            return root;
        }
    }
}
