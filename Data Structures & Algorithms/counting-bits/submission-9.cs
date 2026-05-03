public class Solution 
{
    public int[] CountBits(int n) 
    {
        int[] res = new int[n + 1];
        res[0] = 0;
        for (int i = 1; i <= n; i++)
        {
            int count = 0;
            int temp = i;
            
            while (temp != 0)
            {
                count += temp % 2;
                temp = temp >> 1;
            }
            res[i] = count;
        }
        return res;
    }
}
