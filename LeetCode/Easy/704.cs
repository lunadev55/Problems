public class Solution {
    public int Search(int[] nums, int target) {
        int left = 0; int right = nums.Length - 1; 

        while (left <= right)
        {
            int half = (right + left) / 2;

            if (nums[half] > target)
                right = half - 1;
            else if (nums[half] < target)
                left = half + 1;
            else
                return half;            
        }
        
        return -1;
    }
}