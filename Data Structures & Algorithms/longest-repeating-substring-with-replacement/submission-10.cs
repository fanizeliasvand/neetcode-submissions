public class Solution {
    public int CharacterReplacement(string s, int k) {
        var occurance = new Dictionary<char, int>();
        int longest = 0; 
        int left = 0;
        int frequency = 0;
        if(s.Length - 1 <= k) return s.Length;
        for(int right = 0; right < s.Length; right++)
        {
            char c = s[right];
            if (!occurance.ContainsKey(c)) occurance[c] = 0;
            occurance[c]++;
            frequency = Math.Max(frequency, occurance[c]);
            while(right - left + 1 - frequency > k)
            {
                occurance[s[left]]--;
                left++;
            }
            longest = Math.Max(longest, right - left + 1);

        }
        return longest;
        
    }
}
