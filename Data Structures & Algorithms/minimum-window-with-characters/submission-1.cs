public class Solution {
    public string MinWindow(string s, string t) {
        var tCounts = new Dictionary<char, int>(); 
        var windowCounts = new Dictionary<char, int>(); 
        int left = 0; 
        int found = 0; 
        int bestLeft = 0; 
        var shortest = int.MaxValue; 
        foreach(char c in t)
        {
            tCounts[c] = tCounts.GetValueOrDefault(c) + 1; 
        }
        for(int right = 0; right < s.Length; right++)
        {
            char rightChar = s[right]; 
            windowCounts[rightChar] = windowCounts.GetValueOrDefault(rightChar) + 1; 
            if(windowCounts[rightChar] == tCounts.GetValueOrDefault(rightChar)) found++; 
            
            while(found == tCounts.Count) 
            {
                if(right - left + 1 < shortest)
                {
                    shortest = right - left + 1; 
                    bestLeft = left; 
                }
                windowCounts[s[left]]--; 
                if (windowCounts[s[left]] < tCounts.GetValueOrDefault(s[left])) found--;
                left++; 
            }
        }
        if (shortest == int.MaxValue) return "";                                    
        return s.Substring(bestLeft, shortest);
    }
}
