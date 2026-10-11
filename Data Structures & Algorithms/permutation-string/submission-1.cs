public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        Dictionary<char, int> s1Map = new Dictionary <char, int>(); 
        Dictionary<char, int> window = new Dictionary <char, int>(); 
        int left = 0; 
        foreach(char c in s1)
        {
            if(!s1Map.ContainsKey(c)) s1Map[c] = 0; 
            s1Map[c]++; 
        }
        for(int right = 0; right < s2.Length; right++)
        {
            if(!window.ContainsKey(s2[right])) window[s2[right]] = 0; 
            window[s2[right]]++; 
            int allowed = 0; 
            if(s1Map.ContainsKey(s2[right])) allowed = s1Map[s2[right]];
            while(window[s2[right]] > allowed)
            {
                window[s2[left]]--; 
                left++; 
            }
            if(right - left + 1 == s1.Length) return true; 
        }
        return false; 
        
    }
}
