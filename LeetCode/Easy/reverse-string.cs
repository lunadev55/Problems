public class Solution {
    public void ReverseString(char[] s) {
        int first = 0; int last = s.Length - 1;

        while (first < last)
        {
            char temp = s[first];
            s[first] = s[last];
            s[last] = temp;

            first++;
            last--;
        }      
    }
}