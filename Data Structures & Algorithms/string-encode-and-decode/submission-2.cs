public class Solution {

    public string Encode(IList<string> strs) {
     
        // create a string to hold the res
        // loop through the array
        // get length of string[i] - use it as key
        // add the length to result and then the # then strn[i]
        // return res
        int n = strs.Count;
        StringBuilder result = new StringBuilder();
        for(int i=0;i<n;i++){
            int m = strs[i].Length;
            string res = m +"#"+ strs[i];
            result.Append(res);
        }

        
        return result.ToString();
        
    }

    public List<string> Decode(string s) {
        List<string> results = new List<string>();
        int n = s.Length;
        Console.WriteLine(s);
        int i =0;
        while(i < n){
            int index =s.IndexOf('#', i);
            int len = int.Parse(s.Substring(i, index - i));
            string res = s.Substring(index+1, len);
            results.Add(res);
            i= index +1+len;
            
        }

        return results;

   }
}
