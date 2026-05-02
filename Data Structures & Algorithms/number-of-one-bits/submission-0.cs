public class Solution {
    public int HammingWeight(uint n) {
        return Convert.ToString(n, 2).Count(x => x - '0' == 1);
    }
}
