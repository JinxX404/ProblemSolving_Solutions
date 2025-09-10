public class Solution {
    
        public int FindKthLargest(int[] nums, int k)
        {
            var sortedNums = new PriorityQueue<int, int>();

            foreach (var item in nums)
            {
                sortedNums.Enqueue(item, item);
            }

            while (sortedNums.Count > k)
            {
                sortedNums.Dequeue();
            }


            return sortedNums.Peek();

        }
}