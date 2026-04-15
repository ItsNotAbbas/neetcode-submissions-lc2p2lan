public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        List<(int, int)> map = new List<(int, int)>();

        int index = 0;

        foreach (var number in nums)
        {
            map.Add((number, index));
            index++;
        }

        List<(int, int)> sortedList = map.OrderBy(i => i.Item1).ToList();

        int left = 0;
        int right = nums.Length - 1;
        int i;
        int j;

        while (left < right)
        {
            int sum = sortedList[left].Item1 + sortedList[right].Item1;
            if (sum > target)
            {
                right--;
            }
            else if (sum < target)
            {
                left++;
            }
            else
            {
                if (sortedList[left].Item2 < sortedList[right].Item2)
                {
                    i = sortedList[left].Item2;
                    j = sortedList[right].Item2;
                }
                else
                {
                    j = sortedList[left].Item2;
                    i = sortedList[right].Item2;
                }

                if (i != j)
                {
                    return new int[] { i, j };
                }
            }

        }

        return null;
    }
}
