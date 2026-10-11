public class Solution {
    public string MinWindow(string s, string t) {
        var sCounts = new Dictionary<char, int>(); 
        var windowCounts = new Dictionary<char, int>(); 
        int left = 0; 
        int found = 0; 
        int longest = int.MaxValue; 
        var res = new List<int[]>(); 
        foreach(char c in t)
        {
            sCounts[c] = sCounts.GetValueOrDefault(c) + 1; 
        }
        for(int right = 0; right < s.Length; right++)
        {
            char rightChar = s[right]; 
            windowCounts[rightChar] = windowCounts.GetValueOrDefault(rightChar) + 1; 
            if(windowCounts[rightChar] == sCounts.GetValueOrDefault(rightChar)) found++; 
            if(found == sCounts.Count)
            {
                while(sCounts.GetValueOrDefault(s[left]) < windowCounts[s[left]])
                {
                windowCounts[s[left]]--; 
                left++; 
                }
                if(right - left + 1 < longest)
                {
                    res.Add(new int[] {left, right, right - left + 1}); 
                    longest = right - left + 1; 
                }
                windowCounts[s[left]]--; 
                left++; 
                found--; 
            }

        }
        if(res.Count == 0) return ""; 
        int[] shortest = res[0];  
        foreach(var ans in res)
        {
            if(ans[2] < shortest[2]) shortest = ans; 
        }
        
        string result = s.Substring(shortest[0], shortest[2]);
        return result; 
    }
}
