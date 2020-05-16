/*
Given a non-negative integer num represented as a string, remove k digits from the number so that the new number is the smallest possible.

Note:
The length of num is less than 10002 and will be ≥ k.
The given num does not contain any leading zero.
Example 1:

Input: num = "1432219", k = 3
Output: "1219"
Explanation: Remove the three digits 4, 3, and 2 to form the new number 1219 which is the smallest.
Example 2:

Input: num = "10200", k = 1
Output: "200"
Explanation: Remove the leading 1 and the number is 200. Note that the output must not contain leading zeroes.
Example 3:

Input: num = "10", k = 2
Output: "0"
Explanation: Remove all the digits from the number and it is left with nothing which is 0.
*/

public class Solution {
    public string RemoveKdigits(string num, int k) {
        var stack = new Stack<char>();
    
        //Remove the largest digits from the left
        for( int i = 0; i < num.Length; i++){
            char digit =  num[i];
            while(stack.Count > 0 && k > 0 && stack.Peek() > digit){
                stack.Pop();
                k--;
            }
            stack.Push(digit);
        }
    
        // Remove additional digits if k > 0
        for(int i = 0; i < k; i++) stack.Pop();
        
        // Form answering string
        var arr = stack.ToArray();
        Array.Reverse(arr); //Leading zero is at the bottom of the stack, so reverse it here
        StringBuilder sb = new StringBuilder();
        bool isZeroLead = true;
        for( int i = 0; i < arr.Length; i++){
            char digit = arr[i];
            if(digit != '0') isZeroLead = false;
            if( !isZeroLead ) sb.Append(digit);
        }

        if( sb.Length == 0) return "0";
        
        return sb.ToString();
    }
}
