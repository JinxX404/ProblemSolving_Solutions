public class Solution {
    public int[] RunningSum(int[] nums) {
     int[] summs = new int[nums.Length];

for (int i = 0; i < nums.Length; i++)
{
    int sum = 0;
    for (int j = 0; j <= i; j++)
    {
        sum += nums[j];
    }
    summs[i] = sum;
}
return summs;   
    }
}