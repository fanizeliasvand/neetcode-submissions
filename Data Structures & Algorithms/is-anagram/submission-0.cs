public class Solution {
    public bool IsAnagram(string s, string t) {
        var occurance = new Dictionary <char, int>();
        if(s.Length != t.Length) return false;
        foreach(char c in s)
        {
            if (occurance.ContainsKey(c)) occurance[c]++;
            else occurance[c] = 1;
        }
        foreach(char c in t)
        {
            if(occurance.ContainsKey(c) && occurance[c] > 0) occurance[c]--;
            else return false;
        }
        return true;

    }
}
