public class Solution {

    public string Encode(IList<string> strs) {
        string encoded = "";
        foreach (string str in strs)
        {
            encoded += str.Length + "#" + str;
        }
        return encoded;
    }

    public List<string> Decode(string s) {
        var result = new List<string>();
        for(int i = 0; i < s.Length; i++)
        {
            int j = i;
            while(s[j] != '#')
            {
                j++;
            }
            int length = int.Parse(s.Substring(i, j - i));
            string word = s.Substring(j + 1, length);
            result.Add(word);
            i = j + length;
        }
        return result;

    }
        
}
