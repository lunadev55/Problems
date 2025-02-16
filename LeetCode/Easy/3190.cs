public class Solution {
    public int MinimumOperations(int[] nums) {
        int numberOfOperations = nums.Length;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 3 == 0)
                numberOfOperations--;
        }
        return numberOfOperations;
    }
}