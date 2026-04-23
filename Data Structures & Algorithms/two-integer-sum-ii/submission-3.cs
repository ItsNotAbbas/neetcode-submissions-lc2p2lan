public class Solution 
{
    public int[] TwoSum(int[] numbers, int target) 
    {
        int left = 0;
        int right = numbers.Count() - 1;

        while (left < right)
        {
            int sum = numbers[left] + numbers[right];

            if (sum < target)
            {
                left++;
            }
            else if (sum > target)
            {
                right--;
            }
            else if (sum == target)
            {
                return new int[] { left + 1, right + 1 };
            }
        }

        return new int[] { 0, 0 };

    }
}
