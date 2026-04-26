public class Solution 
{
    public int MaxArea(int[] heights) 
    {
        int left = 0;
        int right = heights.Count() - 1;
        int maxArea = 0;

        while (left < right)
        {
            int width = right - left;
            int height = heights[right] - heights[left] > heights[left] - heights[right] ? heights[left] : heights[right];

            if (width * height > maxArea)
            {
                maxArea = width * height;
            }
            else if (heights[right] < heights[left])
            {
                right--;
            }
            else
            {
                left++;
            }
        }

        return maxArea;
    }
}
