/*
 * Given a range [m, n] where 0 <= m <= n <= 2147483647,
 * return the bitwise AND of all numbers in this range, inclusive.
 * Example 1:
 * Input: [5,7]
 * Output: 4
 * Example 2:
 * Input: [0,1]
 * Output: 0
 */

// The idea is not to loop all numbers in-between or recursive
// Thinking in this way:
//   1. Binary counter has only 1 or 0 at each bit,
//       so once it was changed once, the result on this bit must be 0,
//       therefore we are looking for the bits which were changed in-between the 2 numbers.
//   2. To find out the changed bits, we need only a ^ operation between m and n, for
//         it's reflecting the 2 numbers difference as well as the bits part changed.
//         Below sample shows the m^n result and we are interested in the leftest position of 1
//       A sample: m: 00000001,10101010,00101011,11010111
//                 n: 00000001,10101010,00110001,01111001
//                m^n:00000000,00000000,00011010,10101110
//   3. Next step is to find out the leftest position of 1 in m^n, and this is going to be done by a 
//        for loop and a counter. Counter will be used clear 0 in m
//   4. Right shift m the counter times then shift left back same counter times,
//         as is to clear all changed parts to 0.


public int RangeBitwiseAnd(int m, int n) {
    int count = 0;
    for(int changed = m^n; changed > 0; changed /= 2, count++); //Counting length
    return m >> count << count; //Clear 0s at changed bits
}
