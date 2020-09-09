using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsPractice
{
    public static class kthlargestunordered
    {
        public static int Run(int[] nums, int k)
        {
            var pq = new MinPriorityQueue(k);
            for (int i = 0; i < k; ++i)
                pq.Insert(nums[i]);

            for (int i = k; i < nums.Length; ++i)
            {
                if (nums[i] > pq.Peek())
                {
                    pq.Pop();
                    pq.Insert(nums[i]);
                }
            }

            return pq.Pop();
        }

        class MinPriorityQueue
        {
            private List<int> heap;

            public MinPriorityQueue(int capacity)
            {
                heap = new List<int>(capacity);
            }

            public void Insert(int value)
            {
                heap.Add(value);
                Swim(heap.Count - 1);
            }

            public int Peek()
            {
                if (heap.Count == 0) throw new InvalidOperationException();

                return heap[0];
            }

            public int Pop()
            {
                var value = heap[0];
                Swap(0, heap.Count - 1);
                heap.RemoveAt(heap.Count - 1);
                Sink(0);

                return value;
            }

            private void Swim(int idx)
            {
                while (idx > 0 && heap[((idx + 1) / 2) - 1] > heap[idx])
                {
                    Swap(((idx + 1) / 2) - 1, idx);
                    idx /= 2;
                }
            }

            private void Sink(int idx)
            {
                while ((2 * (idx + 1)) - 1 < heap.Count)
                {
                    var child = (2 * (idx + 1)) - 1;
                    if (child + 1 < heap.Count && heap[child + 1] < heap[child]) child++; // right if right is greater child

                    if (heap[idx] < heap[child]) break; // if parent is less than largest child, we're good.

                    Swap(idx, child);
                    idx = child;
                }
            }

            private void Swap(int a, int b)
            {
                var temp = heap[a];
                heap[a] = heap[b];
                heap[b] = temp;
            }
        }
    }
}
