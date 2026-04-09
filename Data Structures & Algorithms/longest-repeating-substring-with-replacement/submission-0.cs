public class Solution {
    public int CharacterReplacement(string s, int k) {
        var seen = new Dictionary<char, int>();
        int longest = 0;
        int left = 0;
        int frequency = 0;
        for(int right = 0; right < s.Length; right++)
        {
            if(!seen.ContainsKey(s[right])) seen[s[right]] = 0;
            seen[s[right]]++;

            if (seen[s[right]] > frequency) frequency = seen[s[right]];
            
            while (right - left + 1 - frequency > k)
            {
                seen[s[left]]--;
                left ++;
            }
            longest = int.Max(longest, right - left + 1);
            

        }
        return longest;
        
    }
}
