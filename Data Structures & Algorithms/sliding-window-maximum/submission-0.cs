public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        var deque = new LinkedList<int>(); 
        var res = new List<int>(); 
        
        for(int i = 0; i < nums.Length; i++)
        {
            if(deque.Count > 0 && i - k + 1 > deque.First.Value)
            {
                deque.RemoveFirst(); 
                 
            }
            while(deque.Count > 0 && nums[i] > nums[deque.Last.Value])
            {
                deque.RemoveLast();  
            }
            deque.AddLast(i);
            
            if(i >= k - 1) 
            {
                res.Add(nums[deque.First.Value]); 
            }
        }
        return res.ToArray(); 
    }
}
