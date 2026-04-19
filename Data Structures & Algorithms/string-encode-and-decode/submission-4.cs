public class Solution
{

    public string Encode(IList<string> strs)
    {
        if (strs.Count > 0)
        {
            string res = string.Join("⓴", strs);
            Console.WriteLine(res);
            string encoded = "";
            for (int i = 0; i < res.Length; i++)
            {
                char letter = res[i];

                if (char.IsUpper(letter))
                {
                    encoded += (char)('A' + (((letter - 'A') + 13) % 26));
                }
                else if (char.IsLower(letter))
                {
                    encoded += (char)('a' + (((letter - 'a') + 13) % 26));
                }
                else
                {
                    encoded += letter;
                }
            }
            Console.WriteLine(encoded);
            return encoded;
        }
        else
        {
            return "hi";
        }
    }

    public List<string> Decode(string s)
    {
        if (s == "hi")
        {
            return new List<string>();
        }
        string decoded = "";
        for (int i = 0; i < s.Length; i++)
        {
            char letter = s[i];

            if (char.IsUpper(letter))
            {
                decoded += (char)('A' + MakeNonNegative(((letter - 'A') - 13)));
            }
            else if (char.IsLower(letter))
            {
                decoded += (char)('a' + MakeNonNegative(((letter - 'a') - 13))) ;
            }
            else
            {
                decoded += letter;
            }
        }

        Console.WriteLine(decoded);
        return decoded.Split("⓴").ToList();
    }

    public int MakeNonNegative(int num)
    {
        while (num < 0)
        {
            num += 26;
        }
        return num;
    }
}
