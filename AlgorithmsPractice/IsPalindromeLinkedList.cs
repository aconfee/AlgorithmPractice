namespace AlgorithmsPractice
{
    public static class IsPalindromeLinkedList
    {
        public static bool Run(ListNode<int> l)
        {
            if (l == null || l.next == null) return true;

            // O(N/2) Reverse first half of list and set compare pointers in the middle
            ListNode<int> end = l;
            ListNode<int> previous = null;
            ListNode<int> middle = l;
            while (end?.next != null)
            {
                end = end.next.next;

                // Reverse first half of list 
                ListNode<int> temp = middle.next;
                middle.next = previous;
                previous = middle;
                middle = temp;
            }

            // If odd length, skip single occurance of middle character
            if (end != null)
                middle = middle.next;

            // O(N/2) Palindrome compare
            while (previous != null && middle != null)
            {
                if (previous.value != middle.value) return false;
                previous = previous.next;
                middle = middle.next;
            }

            return true;
        }
    }
}
