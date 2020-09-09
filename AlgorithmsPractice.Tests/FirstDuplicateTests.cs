using System;
using Xunit;

namespace AlgorithmsPractice.Tests
{
    public class FirstDuplicateTests
    {
        [Fact]
        public void Runs()
        {
            var a = new [] { 2, 1, 3, 5, 3, 2 };

            var firstDuplciate = FirstDuplicate.Run(a);

            Assert.Equal(3, firstDuplciate);
        }
    }
}
