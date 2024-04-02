
// Time complexity: O(jewels * stones) 
// Space complexity: O(1) 
public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        int myJewels = 0;

        for (int i = 0; i < jewels.Length; i++)
        {
            for (int j = 0; j < stones.Length; j++)
            {
                if (jewels[i] == stones[j])
                    myJewels++;
            }
        }       
        return myJewels;
    }
}

// Time complexity: O(jewels + stones) 
// Space complexity: O(jewels)
public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        int myJewels = 0;

        HashSet<char> set = new HashSet<char>(jewels);

        for (int i = 0 ; i < stones.Length; i++)
        {
            if (set.Contains(stones[i]))
                myJewels++;
        }
    
        return myJewels;
    }
} 
