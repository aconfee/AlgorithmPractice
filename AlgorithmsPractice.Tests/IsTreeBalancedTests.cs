using Xunit;

namespace AlgorithmsPractice.Tests
{
    public class IsTreeBalancedTests
    {
        [Fact]
        public void Test()
        {
            var root = new Tree<int>(1);
            root.left = new Tree<int>(2);
            root.right = new Tree<int>(2);
            root.left.right = new Tree<int>(3);
            root.right.right = new Tree<int>(3);

            var thing = IsTreeBalanced.Run(root);
        }
    }
}
