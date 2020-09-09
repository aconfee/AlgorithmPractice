using System.Collections.Generic;

namespace AlgorithmsPractice
{
    public class Tree<T>
    {
        public T value;
        public Tree<T> left;
        public Tree<T> right;

        public Tree() { }
        public Tree(T val)
        {
            value = val;
        }
    }

    public static class IsTreeBalanced
    {
        public static bool Run(Tree<int> t)
        {
            if (t == null) return true;

            var queue = new Queue<Tree<int>>();
            queue.Enqueue(t);
            var palindromeList = new List<Tree<int>>();
            while (queue.Count > 0)
            {
                // Get all children (one level).
                while (queue.Count > 0)
                {
                    var node = queue.Dequeue();
                    palindromeList.Add(node.right);
                    palindromeList.Add(node.left);
                }

                // Ensure children (level) is a palindrome.
                var palindrome = palindromeList.ToArray();
                for (int start = 0, end = palindrome.Length - 1; start < end; ++start, --end)
                    if (palindrome[start]?.value != palindrome[end]?.value) return false;

                // Queue up next.
                foreach (var node in palindromeList)
                {
                    if (node?.right != null)
                        queue.Enqueue(node.right);

                    if (node?.left != null)
                        queue.Enqueue(node.left);
                }

                palindromeList.Clear();
            }

            return true;
        }
    }
}
