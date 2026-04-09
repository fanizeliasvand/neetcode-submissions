public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var rows = new HashSet<char>[9];
        var cols = new HashSet<char>[9];
        var boxes = new HashSet<char>[9];
        for (int i = 0; i < 9; i++)
        {
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }
        for (int r = 0; r < 9; r++)
        {
            for(int c = 0; c < 9; c++)
            {
                char n = board[r][c];
                if (n == '.') continue;
                if (!rows[r].Contains(n))
                {
                    rows[r].Add(n);
                }
                else return false;
                if (!cols[c].Contains(n))
                {
                    cols[c].Add(n);
                }
                else return false;
                int b = (r / 3) * 3 + (c / 3);
                if (!boxes[b].Contains(n))
                {
                    boxes[b].Add(n);
                }
                else return false;
            }
        }
        return true;
    }
}
