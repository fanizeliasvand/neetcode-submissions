public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        HashSet<int> window = new HashSet<int>(); 
        int left = 0;
        for(int right = left; right < nums.Length; right++)
        {
            if(right - left > k)
            {
                window.Remove(nums[left]); 
                left++;  
            }
            if(window.Contains(nums[right])) return true;  
            window.Add(nums[right]); 
        }
        return false; 
    }
}