public class Solution 
{
    public bool IsHappy(int n) 
    {
        List<int> seen = new List<int>();

        while (n != 1)
        {
            n = GetSquareSum(n);

            if (seen.Contains(n))
            {
                return false;
            }
            else
            {
                seen.Add(n);
            }
        }

        return true;
    }


    public int GetSquareSum(int n)
    {
        int sum = 0;
        foreach (char c in n.ToString().ToCharArray())
        {
            sum += (int)Math.Pow((c - '0'), 2);
        }
        return sum;
    }
}
