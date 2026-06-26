public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> hash = new Dictionary<char, int>(); 
        foreach (char c in s)
        {
            if(!hash.ContainsKey(c)) hash[c] = 0;
            hash[c]++; 
        }
        foreach(char c in t)
        {
            if (hash.ContainsKey(c))
            {
                if(hash[c] > 0) hash[c]--; 
                else return false; 
                if(hash[c] == 0) hash.Remove(c); 
            } 
            else return false; 
            
        }
        
        return hash.Count == 0; 
    }
}
