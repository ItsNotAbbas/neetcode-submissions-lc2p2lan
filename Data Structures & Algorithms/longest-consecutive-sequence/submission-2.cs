public class Solution 
{
    public int LongestConsecutive(int[] nums) 
    {
        if (nums.Count() == 0) return 0;
        nums = nums.Distinct().ToArray();
        Array.Sort(nums);
        
        List<int> longestRuns = new List<int>();

        int longestRun = 1;

        for (int i = 0; i < nums.Count() - 1; i++)
        {
            if (nums[i] + 1 == nums[i+1])
            {
                longestRun += 1;
            }
            else
            {
                longestRuns.Add(longestRun);
                longestRun = 1;
            }
        }
        longestRuns.Add(longestRun);
        return longestRuns.Max();
    }
}
