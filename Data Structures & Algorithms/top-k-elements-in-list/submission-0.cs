public class Solution 
{
    public int[] TopKFrequent(int[] nums, int k) 
    {
        List<int> distinctNums = nums.Distinct().ToList();
        List<(int num, int occurrences)> mappings = new List<(int num, int occurrences)>();
        List<int> seen = new List<int>();

        foreach (int number in distinctNums)
        {
            if (!seen.Contains(number))
            {
                mappings.Add((number, nums.Count(x => x == number)));
                seen.Add(number);
            }
        }

        mappings = mappings.OrderBy(x => x.occurrences).Reverse().ToList();

        int[] res = new int[k];

        for (int i = 0; i < k; i++)
        {
            res[i] = mappings[i].num;
        } 

        return res;
    }
}
