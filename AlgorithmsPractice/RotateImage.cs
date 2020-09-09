namespace AlgorithmsPractice
{
    // O(N) time -- swaps N values once
    // No additional memory -- swaps in place. 
    public static  class RotateImage
    {
        public static int[][] rotateImage(int[][] a)
        {
            for (int layer = 0; layer < a.Length / 2; ++layer)
            {
                int endIndex = (a.Length - 1) - layer;
                for (int offset = 0; layer + offset < endIndex; ++offset) // Offset in any direction, left, right, up, down. 
                {
                    int temp = a[layer][layer + offset];                            // Top left stored
                    a[layer][layer + offset] = a[endIndex - offset][layer];         // Bottom left moves up
                    a[endIndex - offset][layer] = a[endIndex][endIndex - offset];   // Bottom right moves left
                    a[endIndex][endIndex - offset] = a[layer + offset][endIndex];   // Top right moves down
                    a[layer + offset][endIndex] = temp;                             // Top right moves left (to first spot)          
                }
            }

            return a;
        }
    }
}
