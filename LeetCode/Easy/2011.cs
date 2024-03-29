
// First approach
public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        int finalValue = 0;

        foreach (var operation in operations)
        {
            if (operation.Contains("+"))
                finalValue++;
            else
                finalValue--;
        }
        
        return finalValue;
    }
}

// LINQ
public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        return operations.Select(x => x.Contains('+') ? 1 : -1).Sum();
    }
}