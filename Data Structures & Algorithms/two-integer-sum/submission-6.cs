public class Solution 
{
    public int[] TwoSum(int[] nums, int target) {

        Dictionary<int, int> mappings = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int numberNeeded = target - nums[i];

            if (mappings.ContainsKey(numberNeeded))
            {
                return new int[] { mappings[numberNeeded], i };
            }
            mappings[nums[i]] = i;
        }

        return null;
    }
}
