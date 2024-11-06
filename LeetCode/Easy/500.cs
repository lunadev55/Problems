public class Solution {
    public string[] FindWords(string[] words) {
        HashSet<char> firstRow = new HashSet<char>
            { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i','o', 'p',
            'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I','O', 'P'};        

        HashSet<char> secondRow = new HashSet<char>
            { 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k','l',
            'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K','L'};

        HashSet<char> thirdRow = new HashSet<char>
            { 'z', 'x', 'c', 'v', 'b', 'n', 'm',
            'Z', 'X', 'C', 'V', 'B', 'N', 'M'};

        var list = new List<string>();

        for (int i = 0; i < words.Length; i++)
        {
            int countFirst = 0; int countSecond = 0; int countThird = 0;

            for (int j = 0; j < words[i].Length; j++)
            {
                if (firstRow.Contains(words[i][j]))            
                    countFirst++;                     
                else if (secondRow.Contains(words[i][j]))               
                    countSecond++;               
                else if (thirdRow.Contains(words[i][j]))                
                    countThird++;               
            }

            if (countFirst == words[i].Length 
                || countSecond == words[i].Length
                || countThird == words[i].Length )
            {
                list.Add(words[i]);
                continue;
            }                        
        }

        return list.ToArray();
    }
}