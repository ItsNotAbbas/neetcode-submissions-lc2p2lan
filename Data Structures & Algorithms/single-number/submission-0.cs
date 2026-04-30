public class Solution 
{
    public int SingleNumber(int[] nums) 
    {
        foreach (int n in nums)
        {
            if (nums.Count(x => x == n) == 1)
            {
                return n;
            }
        }
        return nums[0];
    }
}
