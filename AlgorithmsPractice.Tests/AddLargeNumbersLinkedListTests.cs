using Xunit;

namespace AlgorithmsPractice.Tests
{
    public class AddLargeNumbersLinkedListTests
    {
        [Fact]
        public void Test()
        {
            var listA = new ListNode<int>(9876);
            listA.next = new ListNode<int>(5432);
            listA.next.next = new ListNode<int>(1999);

            var listB = new ListNode<int>(1);
            listB.next = new ListNode<int>(8001);

            AddLargeNumbersLinkedList.Run(listA, listB);
        }

        [Fact]
        public void Test2()
        {
            var listA = new ListNode<int>(0);

            var listB = new ListNode<int>(1234);
            listB.next = new ListNode<int>(123);
            listB.next.next = new ListNode<int>(0);

            AddLargeNumbersLinkedList.Run(listA, listB);
        }
    }
}
