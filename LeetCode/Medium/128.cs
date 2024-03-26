public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length == 0)
            return 0;

        Array.Sort(nums);
        int count = 1;
        int longestConsecutiveSequence = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i - 1] != nums[i])
            {
                if (nums[i] - nums[i - 1] == 1)
                    count++;
                else
                {
                    longestConsecutiveSequence = Math.Max(longestConsecutiveSequence, count);
                    count = 1;                
                }
            }          
        }
        return Math.Max(longestConsecutiveSequence, count);;
    }
}