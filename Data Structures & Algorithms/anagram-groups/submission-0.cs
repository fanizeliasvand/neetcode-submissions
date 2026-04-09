public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var map = new Dictionary <string, List<string>>();
        foreach(string word in strs)
        {
            char[] chars = word.ToCharArray();
            Array.Sort(chars);
            string sorted = new string(chars);
            if (!map.ContainsKey(sorted))
            {
                map[sorted] = new List<string>();
            }
            map[sorted].Add(word);
        }
        return new List<List<string>>(map.Values);
    }
}
