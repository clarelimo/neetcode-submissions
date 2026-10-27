public class Solution {
    public bool IsPalindrome(string s) {
        s = s.ToLower();
        int n = s.Length;
        int start = 0;
        int end = n-1;
        while(start < end){
            while(!char.IsLetterOrDigit(s[start]) && start < end){
                start++; // 1
            }

            while(!char.IsLetterOrDigit(s[end]) && start < end){
                end--; // 0
            }

            if(s[start] != s[end]){
                return false;
            }
            start++;
            end--;
        }

        return true;
    }
}
