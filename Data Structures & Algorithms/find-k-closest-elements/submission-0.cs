public class Solution {
    public List<int> FindClosestElements(int[] arr, int k, int x) {
        List<int> res = new List<int>(); 
        int left = 0; 
        res.Add(arr[left]); 
        for(int right = left + 1; right < arr.Length; right++)
        {
            if(Math.Abs(x - arr[right]) < Math.Abs(x - arr[left]) || res.Count < k)
            {
                res.Add(arr[right]); 
                if(res.Count > k)
                {
                    res.RemoveAt(0); 
                    left++; 
                }
            }            
        }
        return res; 
    }
}