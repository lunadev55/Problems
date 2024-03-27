
public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        int numsSize = nums.Length;
        
        HashSet<int> set = new HashSet<int>();

        for (int i = 0; i < numsSize; i++)
        {
            if (set.Contains(nums[i]))
                return true;
            else
                set.Add(nums[i]);      
        } 
        return false;        
    }
}