public class Solution {
    public bool IsAnagram(string s, string t) {
        int n = s.Length;
        int m= t.Length;
        if(n != m) return false;

        var dictS = new Dictionary<char, int>();
        var dictT = new Dictionary<char, int>();

        for(int i=0; i<n;i++){
            if(dictS.ContainsKey(s[i])){
                dictS[s[i]]++;
            }else{
                dictS.Add(s[i], 1);
            }

            if(dictT.ContainsKey(t[i])){
                dictT[t[i]]++;
            }else{
                dictT.Add(t[i], 1);
            }
        }

        foreach(var item in dictS){
            if(dictT.ContainsKey(item.Key)){
                if(item.Value != dictT[item.Key]){
                     Console.WriteLine(dictT);
                    return false;
                }
            }else{
                return false;
            }
        }

        return true;
    }
}
