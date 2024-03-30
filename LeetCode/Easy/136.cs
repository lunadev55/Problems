
public class Solution {
    public int SingleNumber(int[] nums) {
        int result = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            result ^= nums[i];
        }

        return result;
    }
}

// Using LINQ's Aggregate method and the XOR operation
public class Solution {
    public int SingleNumber(int[] nums) {
        return nums.Aggregate((a, b) => a ^ b);
    }
}