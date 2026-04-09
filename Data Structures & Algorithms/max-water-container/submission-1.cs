public class Solution {
    public int MaxArea(int[] heights) {
        int maxArea = 0;
        int left = 0;
        int right = heights.Length - 1;
        while(left < right)
        {   int h = int.Min(heights[left], heights[right]);
            int w = right - left;
            int area = h * w;
            if (area > maxArea) maxArea = area;
            if (heights[left] > heights[right]) right--;
            else left++;
        }
        return maxArea;
    }
}
