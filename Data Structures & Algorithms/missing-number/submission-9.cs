public class Solution 
{
    public int MissingNumber(int[] nums) 
    {
        int len = nums.Length;
        for (int i = 0; i < nums.Length; i++)
        {
            len += i - nums[i];
        }

        return len;
    }
}
