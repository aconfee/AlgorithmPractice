using Xunit;

namespace AlgorithmsPractice.Tests
{
    public class BuildTreeTests
    {
        [Fact]
        public void Test()
        {
            var inorder = new[] { 4, 2, 1, 5, 3, 6 };
            var preorder = new[] { 1, 2, 4, 3, 5, 6 };

            var thing = BuildTree.Run(inorder, preorder);
        }
    }
}
