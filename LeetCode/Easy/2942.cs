
// Time Complexity: O(n) => n = words[] length
// Space Complexity: O(m) => m = number of words containing character 'x'
public class Solution {
    public IList<int> FindWordsContaining(string[] words, char x) {
        return words.Select((word, index) => new { Index = index, ContainsX = word.Contains(x) })
                        .Where(item => item.ContainsX)
                        .Select(item => item.Index)
                        .ToList();
    }
}