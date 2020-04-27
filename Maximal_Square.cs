/*
Given a 2D binary matrix filled with 0's and 1's, find the largest square containing only 1's and return its area.

Example:

Input: 

1 0 1 0 0
1 0 1 1 1
1 1 1 1 1
1 0 0 1 0

Output: 4
*/

public class Solution {
    public int MaximalSquare(char[][] matrix) {
        var n = matrix.Length;
        if (n == 0) return 0;
        var m = matrix[0].Length;
        var dp = new int[n, m];
        var maxlen = 0;
        for (int i = 0; i < n; i++) {
            dp[i, 0] = matrix[i][0] == '1' ? 1 : 0;
            maxlen = Math.Max(maxlen, dp[i, 0]);
        }

        for (int j = 0; j < m; j++) {
            dp[0, j] = matrix[0][j] == '1' ? 1 : 0;
            maxlen = Math.Max(maxlen, dp[0, j]);
        }

        for (int i = 1; i < n; i++) {
            for (int j = 1; j < m; j++) {
                if (matrix[i][j] == '1') {
                    dp[i, j] = Math.Min(dp[i - 1, j - 1], Math.Min(dp[i - 1, j], dp[i, j - 1])) + 1;
                    maxlen = Math.Max(maxlen, dp[i, j]);
                }
            }
        }

        return maxlen * maxlen;
    }
}
