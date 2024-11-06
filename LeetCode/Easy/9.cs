public class Solution {
    public bool IsPalindrome(int x) {
        string number = x.ToString();

        int left = 0; int right = (number.Length - 1);
        while (left < right)
        {
            if (number[left] != number[right])
                return false;
            left++;
            right--;
        }

        return true;
    }
}