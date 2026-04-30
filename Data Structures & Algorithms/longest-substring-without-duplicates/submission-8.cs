public class Solution 
{
    public int LengthOfLongestSubstring(string s) 
    {
        int left = 0;
        int maxLengthFound = 0;

        List<char> seen = new List<char>();

        for (int right = 0; right < s.Length; right++)
        {
            while (seen.Contains(s[right]))
            {
                seen.Remove(s[left]);
                left++;
            }

            seen.Add(s[right]);

            int width = right - left + 1;

            if (width > maxLengthFound)
            {
                maxLengthFound = width;
            }
        }

        return maxLengthFound;
    }
}
