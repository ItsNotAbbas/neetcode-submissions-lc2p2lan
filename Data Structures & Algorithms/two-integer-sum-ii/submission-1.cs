public class Solution 
{
    public int[] TwoSum(int[] numbers, int target) 
    {
        for (int i = 0; i < numbers.Count(); i++)
        {
            if (numbers.Contains(target - numbers[i]))
            {
                return new int[] { i + 1, GetIndex(numbers, target - numbers[i]) + 1};
            }
        }

        return new int[] { 0, 0 };
    }

    public static int GetIndex(int[] nums, int target)
    {
        for (int i = 0; i < nums.Count(); i++)
        {
            if (nums[i] == target)
            {
                return i;
            }
        }
        return -1;
    }
}
