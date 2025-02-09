public class Solution {
    public int[] GetSneakyNumbers(int[] nums) {
        Array.Sort(nums);
        List<int> duplicates = new();

        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] == nums[i + 1])
                duplicates.Add(nums[i]);
        }

        return duplicates.ToArray();
    }
}