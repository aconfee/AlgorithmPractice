using Xunit;

namespace AlgorithmsPractice.Tests
{
    public class FindSubstringsKindOfTests
    {
        [Fact]
        public void Test()
        {
            var words = new[] { "Melon" };
            var parts = new[] { "el", "lon" };

            var thing = FindSubstringsKindOf.Run(words, parts);
        }
    }
}
