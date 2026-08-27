public class Solution {
    public int[][] Merge(int[][] intervals) {
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0])); 
        int[] curr = intervals[0];
        List<int[]> res = new List<int[]>(); 
        for(int i = 1; i < intervals.Length; i++)
        {
            int[] next = intervals[i]; 
            if(curr[1] >= next[0]) curr[1] = Math.Max(curr[1], next[1]); 
        
            else
            {
                res.Add(curr);
                curr = next; 
            }
        }
        res.Add(curr); 
        return res.ToArray(); 
    }
}
