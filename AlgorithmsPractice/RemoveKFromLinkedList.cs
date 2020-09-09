namespace AlgorithmsPractice
{
    public class ListNode<T>
    {
        public T value { get; set; }
        public ListNode<T> next { get; set; }

        public ListNode(){}

        public ListNode(T val)
        {
            value = val;
        }
    }

    public static class RemoveKFromLinkedList
    {
        public static ListNode<int> RemoveKFromList(ListNode<int> l, int k)
        {
            // Remove all leading values.
            while (l?.value == k)
                l = l.next;

            // Remove all with value.
            ListNode<int> iterator = l;
            while (iterator?.next != null)
            {
                if (iterator.next.value == k)
                    iterator.next = iterator.next.next;
                else
                    iterator = iterator.next;
            }

            return l;
        }
    }
}
