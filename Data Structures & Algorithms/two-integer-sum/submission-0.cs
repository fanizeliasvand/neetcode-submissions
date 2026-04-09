public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var seen = new Dictionary <int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int current = nums[i];
            int needed = target - current;
            if (seen.ContainsKey(needed))
            {
                return new int[] {seen[needed], i};
            }
            else seen[current] = i;
        }
        return nums;

    }
}
