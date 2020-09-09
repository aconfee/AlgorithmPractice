using Xunit;

namespace AlgorithmsPractice.Tests
{
    public class KthLargestUnorderedTest
    {
        [Fact]
        public void Test()
        {
            var arr = new[] { -1, 2, 0 };

            var thing = kthlargestunordered.Run(arr, 3); // -1
        }
    }
}
