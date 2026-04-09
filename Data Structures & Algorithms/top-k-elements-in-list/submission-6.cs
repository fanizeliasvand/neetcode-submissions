public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var occurance = new Dictionary <int, int>();
        foreach (int num in nums)
        {
            if(!occurance.ContainsKey(num)) occurance[num] = 0;
            occurance[num]++;
        }
        var sorted = new List<KeyValuePair<int, int>>(occurance);
        sorted.Sort((a,b) => b.Value.CompareTo(a.Value));
        int[] res = new int[k];
        for (int i = 0; i < k; i++)
        {
            res[i] = sorted[i].Key;
        }
        return res;
        
    }
}
