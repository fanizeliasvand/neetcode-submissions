public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new Dictionary<int, int>(); 
        int[] res = new int[2]; 
        for (int i = 0; i < nums.Length; i++)
        {
            int curr = nums[i];
            int need = target - curr; 
            if(map.ContainsKey(need))
            {
                res[1] = i; 
                res[0] = map[need]; 
                break; 
            }
            map[curr] = i; 
        }
        return res; 
    }
}
