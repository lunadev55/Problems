public class Solution {
    public int LengthOfLastWord(string s) {
        var words = s.Trim().Split(' ');
        return words[words.Length - 1].Length;
    }
}