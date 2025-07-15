public class Solution {
    public int[] PlusOne(int[] digits) {
      int len = digits.Length;

 for (int i = len - 1; i >= 0; i--)
 {
     if (digits[i] < 9)
     {
         digits[i] += 1;
         return digits;
     }
     // 0000
     digits[i] = 0;
 }

 digits = new int[len + 1];
 digits[0] = 1;
 return digits;   
    }
}