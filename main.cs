public class Solution {
    private readonly Dictionary<char, int> romanValue = new(){{'I', 1},{'V', 5},{'X', 10},{'L', 50},{'C', 100},{'D', 500},{'M', 1000}};
    public int RomanToInt(string s) {
        int conversion = 0;

        for(int i = 0; i < s.Length; ++i)
        {
            if (i == s.Length - 1)
            {
                conversion += romanValue[s[i]];
                break;
            }
            if (romanValue[s[i]] >= romanValue[s[i + 1]])
            {
                conversion += romanValue[s[i]];
            }
            else
            {
                conversion += romanValue[s[i + 1]] - romanValue[s[i]];
                i++;
            }
        }
        return conversion;
    }    
}
