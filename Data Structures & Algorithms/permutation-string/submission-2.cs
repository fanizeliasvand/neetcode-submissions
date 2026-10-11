public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        Dictionary<char, int> s1Counts = new Dictionary<char, int>(); 
        Dictionary<char, int> windowCount = new Dictionary<char, int>(); 
        int left = 0; 
        foreach(char c in s1)
        {
            s1Counts[c] = s1Counts.GetValueOrDefault(c) + 1; 
        }
        for(int right = 0; right < s2.Length; right++)
        {
            char rightChar = s2[right]; 
            windowCount[rightChar] = windowCount.GetValueOrDefault(rightChar) + 1; 
            while(windowCount[rightChar] > s1Counts.GetValueOrDefault(rightChar))
            {
                windowCount[s2[left]] --; 
                left++;                 
            }
            if(right - left + 1 == s1.Length) return true; 
        }
        return false; 
    }

}
