public class Solution {
    public bool ContainsDuplicate(int[] nums)
{
    HashSet<int> uniqueNums = [];
    uniqueNums.UnionWith(nums);   
    return uniqueNums.Count != nums.Length;
}
}