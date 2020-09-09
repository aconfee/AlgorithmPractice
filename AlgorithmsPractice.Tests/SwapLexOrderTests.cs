using Xunit;

namespace AlgorithmsPractice.Tests
{
    public class SwapLexOrderTests
    {
        [Fact]
        public void Test()
        {
            var str = "abdc";
            var pairs = new [] {
                new [] { 1, 4 },
                new [] { 3, 4 }
            };

            var result = SwapLexOrder.Run(str, pairs);

            Assert.Equal("dbca", result);
        }
    }
}
