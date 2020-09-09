using System;

namespace AlgorithmsPractice
{
    /// <summary>
    /// Assuming array values are between 1 and Length.
    /// </summary>
    public static class FirstDuplicate
    {
        // O(N) time -- N
        // No additional memory -- Mark in place since values are constrained within bounds of indices.
        public static int Run(int[] a)
        {
            for (int i = 0; i < a.Length; ++i)
            {
                var value = Math.Abs(a[i]);
                if (a[value - 1] < 0) 
                    return value;

                a[value - 1] *= -1;
            }

            return -1;
        }
    }
}
