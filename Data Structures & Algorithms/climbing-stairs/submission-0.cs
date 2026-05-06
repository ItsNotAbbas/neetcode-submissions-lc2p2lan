public class Solution 
{
    public int ClimbStairs(int n) 
    {     
        if (n == 1)
        {
            return 1;
        }
        else if (n == 2)
        {
            return 2;
        }

        int f_2 = 1;
        int f_1 = 2;

        for (int i = 1; i < n; i++)
        {
            (f_1, f_2) = (f_1 + f_2, f_1);
        }
        return f_2;
    }
}
