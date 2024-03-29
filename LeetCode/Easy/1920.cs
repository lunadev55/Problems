
// First approach
public class Solution {
    public int[] BuildArray(int[] nums) {
        int[] arr = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)        
            arr[i] = nums[nums[i]];

        return arr;
    }
}

// Solution with O(1) extra memory.
public class Solution {
    public int[] BuildArray(int[] nums) {
        int n = nums.Length;
        for (int i = 0; i < n; i++) {
            nums[i] += (nums[nums[i]] % n) * n;
        }
        for (int i = 0; i < n; i++) {
            nums[i] /= n;
        }
        return nums;
    }    
}   