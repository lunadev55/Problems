public class Solution {
    public string DefangIPaddr(string address) {       
        return string.Concat(address.Select(x => (x == '.') ? "[.]" : x.ToString()));
    }
}