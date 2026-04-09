public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] result = new int[nums.Length];
        int product = 1;
        int zeroCount = 0;
        foreach(int num in nums)
        {
            if (num != 0) product *= num;
            else zeroCount++;
            
        }
        for(int i = 0; i < result.Length; i++)
        {
            if(zeroCount > 1) 
            {
                result[i] = 0;
            }
            else if(zeroCount == 1)
            {
                if(nums[i] == 0)
                {
                    result[i] = product;
                }
                else result[i] = 0;
            }
            else 
            {
                int current = product / nums[i];
                result[i] = current;
            }
            
           
        }
        return result;
        
    }
}
