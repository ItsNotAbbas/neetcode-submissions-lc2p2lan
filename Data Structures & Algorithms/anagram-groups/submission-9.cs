public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

        List<(string original, string standardised)> pairs = new List<(string, string)>();

        foreach (string s in strs)
        {
            var chars = s.ToCharArray();
            Array.Sort(chars);
            pairs.Add( (s, new string(chars)) );
        }

        List<List<string>> res = new List<List<string>>();

        // If the index has been visited, add it in here
        List<int> visited = new List<int>();

        for (int i = 0; i < strs.Length; i++)
        {
            var firstTuple = pairs[i];

            if (visited.Contains(i)) continue;

            List<string> temp = new List<string>();
            temp.Add(firstTuple.original);
            visited.Add(i);

            for (int j = i + 1; j < strs.Length; j++)
            {
                if (pairs[i].standardised == pairs[j].standardised && !visited.Contains(j))
                {
                    temp.Add(pairs[j].original);
                    visited.Add(j);
                }
            }
            res.Add(temp);
            Console.WriteLine(string.Join(", "), temp);

        }
        return res;
    }
}
