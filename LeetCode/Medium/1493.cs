public class Solution {
    public int LongestSubarray(int[] nums) {
        int left = 0; 
        int right = 0; 
        int numberOfZeros = 0;
        int longestSubarraySize = 0;

        while (right < nums.Length)
        {
            if (nums[right] == 0)
                numberOfZeros++;

            while (numberOfZeros > 1)
            {                
                if (nums[left] == 0)              
                    numberOfZeros--; 
                left++; 
            }

            longestSubarraySize = Math.Max(longestSubarraySize, right - left);
            right++;
        }

        return longestSubarraySize;
    }
}