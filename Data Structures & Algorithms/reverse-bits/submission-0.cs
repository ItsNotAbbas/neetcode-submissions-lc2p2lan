public class Solution 
{
    public uint ReverseBits(uint n) 
    {
        var bits = Convert.ToString(n, 2).PadLeft(32, '0').ToArray();
        Array.Reverse(bits);
        return (uint)Convert.ToInt32(new string(bits), 2);
    }
}
