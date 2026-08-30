public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;

        char[] sArray = s.ToCharArray();
        char[] tArray = t.ToCharArray();

        Array.Sort(sArray);
        Array.Sort(tArray);
        bool areEqual = sArray.SequenceEqual(tArray); 
        if(areEqual) return true;
        return false;
    }
}
