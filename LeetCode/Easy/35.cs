public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int left = 0; int right = nums.Length - 1; 

        while (left <= right)
        {   
            int middle = (right + left) / 2;

            if (nums[middle] > target)
                right = middle - 1;
            else if (nums[middle] < target)
                left = middle + 1;
            else
                return middle;            
        }

        return left;
    }
}