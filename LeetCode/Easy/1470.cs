


// Time complexity : O(n)
// Space complexity: O(n)
public class Solution { // Solution using LINQ
    public int[] Shuffle(int[] nums, int n) {
        return nums.Select((num, index) => index % 2 == 0 ? nums[index / 2] : nums[index / 2 + n]).ToArray();   
    }
}