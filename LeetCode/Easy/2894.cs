


// Time Complexity: O(n)
// Space Complexity: O(1)
public class Solution {
    public int DifferenceOfSums(int n, int m) {
        int num1 = 0; int num2 = 0;

        for (int i = 1; i <= n; i++)
        {
            num1 += i % m == 0 ? 0 : i;
            num2 += i % m == 0 ? i : 0;
        }            

        return num1 - num2;
    }
}