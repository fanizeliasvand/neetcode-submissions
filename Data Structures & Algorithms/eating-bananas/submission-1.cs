public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int left = 1, right = piles.Max();
        int res = right; 
        
        while(left <= right)
        {
            int hours = 0;
            int mid = left + (right - left) / 2; 
            foreach(int pile in piles)
            {
                hours += (int)Math.Ceiling((double) pile / mid);
            }
            if (hours <= h)
            {
                right = mid - 1;
                res = mid; 
            }
            else left = mid + 1; 
        }
        return res; 
        
    }
}
