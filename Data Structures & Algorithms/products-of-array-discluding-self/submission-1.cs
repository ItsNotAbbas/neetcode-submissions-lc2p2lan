public class Solution {
    public int[] ProductExceptSelf(int[] nums) 
    {
        int[] output = new int[nums.Count()];
        for (int i = 0; i < nums.Count(); i++)
        {
            int current = nums[i];
            int product = 1;
            for (int j = 0; j < nums.Count(); j++)
            {
                if (i != j)
                {
                    product *= nums[j];
                }
            }
            output[i] = product;
        }
        Console.WriteLine(string.Join(",", output));
        return output;
    }
}
