public class Solution {
    public bool IsAnagram(string s, string t) {

        if (s.Length != t.Length){
            return false;
        }

        var dict = new Dictionary<char, int>();

        foreach (char letter in s)
        {
            if (!dict.ContainsKey(letter))
            {
                dict.Add(letter, 1);
            }
            else
            {
                dict[letter] += 1;
            }
        }

        bool flag = true;
        foreach (var kvp in dict)
        {
            char key = kvp.Key;
            int value = kvp.Value;
            if (!(t.Contains(key) && t.Count(x => x == key) == value))
            {
                flag = false;
                break;
            }
        }

        return flag;
    }
}
