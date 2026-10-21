public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        int n = strs.Length;
        var res = new List<List<string>>();
        bool[] visited = new bool[n]; 

        int i=0;
        while(i < n){
            if(!visited[i]){
                List<string> anagrams = new List<string>(); // [hat]
                anagrams.Add(strs[i]); 
                for(int j = i+1; j< n; j++){
                    if(!visited[j]){
                        bool isAnag = IsAnagram(strs[i], strs[j]);
                        if(isAnag){
                            anagrams.Add(strs[j]);
                            visited[j] = true;;
                        }
                    }
                }
                res.Add(anagrams); // [[act, cat], [pots, tops, stop], hat]
            }
            i++;//6
        }

        return res;
        
    }

    public bool IsAnagram(string s, string t){
        int[] count = new int[26];
        int n = s.Length;
        int m = t.Length;

        if(n != m) return false;

        for(int i=0; i<n; i++){
            count[s[i] - 'a']++;
            count[t[i] - 'a']--;
        }

        foreach(int num in count){
            if(num != 0){
                return false;
            }
        }

        return true;
    }
    /*
    public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var res = new Dictionary<string, List<string>>();
        foreach (var s in strs) {
            int[] count = new int[26];
            foreach (char c in s) {
                count[c - 'a']++;
            }
            string key = string.Join(",", count);
            if (!res.ContainsKey(key)) {
                res[key] = new List<string>();
            }
            res[key].Add(s);
        }
        return res.Values.ToList<List<string>>();
    }
}
    */


}
