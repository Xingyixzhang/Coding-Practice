/*
Given a binary array, find the maximum length of a contiguous subarray with equal number of 0 and 1.

Example 1:
Input: [0,1]
Output: 2
Explanation: [0, 1] is the longest contiguous subarray with equal number of 0 and 1.
Example 2:
Input: [0,1,0]
Output: 2
Explanation: [0, 1] (or [1, 0]) is a longest contiguous subarray with equal number of 0 and 1.
Note: The length of the given binary array will not exceed 50,000.
*/

public class Solution {
    public int FindMaxLength(int[] nums) {
        var pairs = new Dictionary<int,int>();
        int count = 0, sum = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            sum += nums[i] == 1? 1 : -1;
            if(sum == 0)    count = i + 1;
            else if(!pairs.ContainsKey(sum))    pairs.Add(sum, i);
            else    count = Math.Max(count, i - pairs[sum]);
        }
        return count;
    }
}
