public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
    var result = new List<List<int>>();
    Array.Sort(nums);
    for(int still = 0; still < nums.Length - 2; still++)
    {
        if (still > 0 && nums[still] == nums[still - 1]) continue;
        int left = still + 1;
        int right = nums.Length - 1;
        while (left < right)
        {
            int sum = nums[still] + nums[right] + nums[left];
            if(sum == 0)
            {
                result.Add(new List<int> { nums[still], nums[left], nums[right] });
                right--;
                left++;
                while(left < right && nums[left] == nums[left - 1]) left++;
                while(left < right && nums[right] == nums[right + 1]) right--;
            }
            else if(sum > 0) right--;
            else left++;
        }
    }

        return result;
    }
}
