public class Solution 
{
    public int Search(int[] nums, int target) 
    {
        int lower = 0;
        int upper = nums.Count() - 1;
        int middleIndex = nums.Count() / 2;

        while (lower <= upper)
        {
            int middleValue = nums[middleIndex];
            
            if (target == middleValue)
            {
                return middleIndex;
            }
            else if (middleValue < target)
            {
                lower = middleIndex + 1;
                middleIndex = (upper + lower) / 2;
            }
            else if (target < middleValue)
            {
                upper = middleIndex - 1;
                middleIndex = (upper + lower) / 2;
            }
        }
        return -1;
    }
}