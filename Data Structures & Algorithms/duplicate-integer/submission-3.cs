public class Solution {
    public bool hasDuplicate(int[] nums) {
        
        List<int> itemsSeen = new List<int>();

        foreach (int item in nums){
            if (!itemsSeen.Contains(item)){
                itemsSeen.Add(item);
            }
            else{
                return true;
            }
        }
        return false;
    }
}