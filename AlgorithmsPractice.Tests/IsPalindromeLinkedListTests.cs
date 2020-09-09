using Xunit;

namespace AlgorithmsPractice.Tests
{
    public class IsPalindromeLinkedListTests
    {
        [Fact]
        public void IsPalindrome()
        {
            var list = new ListNode<int>(1);
            list.next = new ListNode<int>(2);
            list.next.next = new ListNode<int>(3);
            list.next.next.next = new ListNode<int>(2);
            list.next.next.next.next = new ListNode<int>(1);
            var result = IsPalindromeLinkedList.Run(list);

            Assert.True(result);
        }

        [Fact]
        public void IsNotPalindrome()
        {
            var list = new ListNode<int>(1);
            list.next = new ListNode<int>(2);
            list.next.next = new ListNode<int>(3);
            list.next.next.next = new ListNode<int>(4);
            list.next.next.next.next = new ListNode<int>(1);
            var result = IsPalindromeLinkedList.Run(list);

            Assert.False(result);
        }

        [Fact]
        public void SingleNodeIsPalindrome()
        {
            var list = new ListNode<int>(1);
            var result = IsPalindromeLinkedList.Run(list);

            Assert.True(result);
        }

        [Fact]
        public void NullListIsPalindrome()
        {
            var result = IsPalindromeLinkedList.Run(null);

            Assert.True(result);
        }

        [Fact]
        public void TwoNodePalindrome()
        {
            var list = new ListNode<int>(1);
            list.next = new ListNode<int>(1);
            var result = IsPalindromeLinkedList.Run(list);

            Assert.True(result);
        }

        [Fact]
        public void TwoNodeNotPalindrome()
        {
            var list = new ListNode<int>(1);
            list.next = new ListNode<int>(2);
            var result = IsPalindromeLinkedList.Run(list);

            Assert.False(result);
        }
    }
}
