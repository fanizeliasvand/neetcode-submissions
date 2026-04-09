public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        foreach(var arr in matrix)
        {
            int left = 0; 
            int right = arr.Length - 1;
            if(target <= arr[right])
            {
                while(left <= right)
                {
                    int mid = left + (right - left) / 2; 
                    if(arr[mid] == target) return true; 
                    else if(arr[mid] < target) left = mid + 1;
                    else right = mid - 1;
                }
            }
        }
        return false;
        
    }
}
