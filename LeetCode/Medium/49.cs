public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        string[] sortedStrs = strs.Select(str => new string(str.OrderBy(c => c).ToArray())).ToArray();

        Dictionary<string, List<string>> sortedWordAsKeyAndUnsortedAsValue = new Dictionary<string, List<string>>();

        for (int i = 0; i < strs.Length; i++)
        {
            if (sortedWordAsKeyAndUnsortedAsValue.ContainsKey(sortedStrs[i]))
            {
                sortedWordAsKeyAndUnsortedAsValue[sortedStrs[i]].Add(strs[i]);
                continue;
            }
            List<string> newList = new List<string>();
            newList.Add(strs[i]);
            sortedWordAsKeyAndUnsortedAsValue[sortedStrs[i]] = newList;
        }

        IList<IList<string>> finalList = new List<IList<string>>();;

        foreach (var dic in sortedWordAsKeyAndUnsortedAsValue)
        {
            finalList.Add(dic.Value);
        }

        return finalList;
    }   
}