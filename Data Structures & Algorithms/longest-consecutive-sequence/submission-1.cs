public class Solution {
    public int LongestConsecutive(int[] nums) {
        Array.Sort(nums);
        int max = 0;
        
        // [-1, -1, 0, 1, 3, 4, 5, 6, 7, 8, 9]
        for(int i = 0; i < nums.Length; i++)
        {
            int pre = nums[i];
            int j = i + 1;
            int dupes = 0;
            while(j < nums.Length && (nums[j] == pre || nums[j] == pre + 1))
            {
                if(nums[j] == pre)
                {
                    dupes++;
                }
                pre = nums[j];
                j++;
            }
            int seq = j - i - dupes;
            if (seq > max) max = seq;
            i = j - 1;            
            
        }
        return max;
    }
}
