using Xunit;

namespace AlgorithmsPractice.Tests
{
    public class SimplifyPathTests
    {
        [Fact]
        public void Test()
        {
            var path = "/home/a/./x/../b//c/";

            var thing = SimplifyPath.Run(path);
        }
    }
}
