public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int m = matrix.Length;
        int n = matrix[0].Length; 
        int left = 0, right = m * n - 1;
        while(left <= right)
        {
            int mid = left + (right - left) / 2;
            int col = mid % n; 
            int row = mid / n;
            int value = matrix[row][col];
            if(value == target) return true;
            else if(value < target) left = mid + 1;
            else right = mid - 1;

        }
        return false; 
    }
}
