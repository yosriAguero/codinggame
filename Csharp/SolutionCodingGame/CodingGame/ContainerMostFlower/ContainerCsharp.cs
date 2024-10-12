public static class ContainerCsharp
{
    public static int MaxArea()
    {
        int[] height = [1, 8, 6, 2, 5, 4, 8, 3, 7];
        int maxArea = 0;
        int left = 0;
        int right = height.Length - 1;

        while (left < right)
        {
            // Calculate the area with current left and right pointers
            int width = right - left;
            int currentHeight = Math.Min(height[left], height[right]);
            int area = width * currentHeight;

            // Update maxArea if the current area is larger
            maxArea = Math.Max(maxArea, area);

            // Move the pointer of the smaller height inward
            if (height[left] < height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return maxArea;
    }
}
