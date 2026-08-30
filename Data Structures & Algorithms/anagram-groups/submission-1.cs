public class Solution {
   
    public List<List<string>> GroupAnagrams(string[] strs) {
        //tạo map lưu key + value(key là chuỗi đã sort)
        var map = new Dictionary<string, List<string>>();
        foreach(var str in strs)
        {
            char[] strChar = str.ToCharArray();
            Array.Sort(strChar);
            string sortedStr = new string(strChar);
            if(!map.ContainsKey(sortedStr))
            {
                map[sortedStr] = new List<string>();
            }
            map[sortedStr].Add(str);
        }
        return map.Values.ToList<List<string>>();
    }
}
