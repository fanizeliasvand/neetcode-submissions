public class Solution {
    public int CharacterReplacement(string s, int k) {
        Dictionary<char, int> window = new Dictionary<char, int>(); 
        int left = 0; 
        int frequent = 0; 
        int longest = 0; 
        for(int right = 0; right < s.Length; right++)
        {
            if(!window.ContainsKey(s[right])) window[s[right]] = 0; 
            window[s[right]]++; 
            frequent = Math.Max(frequent, window[s[right]]); 
            while(right - left + 1 - frequent > k)
            {
                window[s[left]]--; 
                left++; 
            }
            longest = Math.Max(longest, right - left + 1); 
        }
        return longest; 
    }
}
