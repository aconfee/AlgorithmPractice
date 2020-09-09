namespace AlgorithmsPractice
{
    public static class AddLargeNumbersLinkedList
    {
        public static ListNode<int> Run(ListNode<int> a, ListNode<int> b)
        {
            // Reverse both lists (In O(N) time, where N is length of longer list.)
            ListNode<int> aPrevious = null;
            ListNode<int> bPrevious = null;
            ListNode<int> aCurrent = a;
            ListNode<int> bCurrent = b;
            while (aCurrent != null || bCurrent != null)
            {
                if (aCurrent != null)
                {
                    ListNode<int> aTemp = aCurrent.next;
                    aCurrent.next = aPrevious;
                    aPrevious = aCurrent;
                    aCurrent = aTemp;
                }

                if (bCurrent != null)
                {
                    ListNode<int> bTemp = bCurrent.next;
                    bCurrent.next = bPrevious;
                    bPrevious = bCurrent;
                    bCurrent = bTemp;
                }
            }

            // Iterate and add (In O(N) time, where N is length of longer list.)
            ListNode<int> resultRoot = null;
            var carry = 0;
            while (aPrevious != null || bPrevious != null || carry != 0)
            {
                var sum = carry;
                if (aPrevious != null)
                {
                    sum += aPrevious.value;
                    aPrevious = aPrevious.next;
                }

                if (bPrevious != null)
                {
                    sum += bPrevious.value;
                    bPrevious = bPrevious.next;
                }

                var newNode = new ListNode<int>();
                newNode.value = sum % 10000;
                newNode.next = resultRoot;
                resultRoot = newNode;

                carry = sum / 10000;
            }

            return resultRoot;
        }
    }
}
