public class Solution {
    public int Search(int[] nums, int target) {
        int right = nums.Length - 1, left = 0; 
        while(left <= right)
        {
            int mid = left + (right - left) / 2;
            if(nums[mid] == target) return mid;
            else if(nums[mid] < target) left = mid + 1;
            else right = mid - 1; 
        }
        return -1;
        
    }
}
