public class Solution 
{
    public List<List<int>> ThreeSum(int[] nums) 
    {
        List<List<int>> res = new List<List<int>>(); 

        for (int i = 0; i < nums.Count(); i++)
        {
            Dictionary<int, int> seen = new Dictionary<int, int>();
            int target = - nums[i];

            for (int j = i + 1; j < nums.Length; j++)
            {
                int complement = target - nums[j];

                if (seen.ContainsKey(complement))
                {
                    List<int> tempList = new List<int> { nums[i], complement, nums[j] };
                    tempList.Sort();
                    if (!res.Any(triplet => triplet.SequenceEqual(tempList)))
                    {
                        res.Add(tempList);
                    }
                }

                seen[nums[j]] = j;
            }
        }

        return res;
    }
}
