public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        
        int n = nums.Length;
        int[] prefixArr = new int[n];
        int prefix = 1;
        prefixArr[0] = prefix;

        for(int i=1; i<n;i++){
            prefix = prefix * nums[i-1];
            prefixArr[i] = prefix;
        }

        int[] suffixArr = new int[n];
        int suff = 1;
        suffixArr[n-1] = suff;
        for(int i = n-2; i>=0;i--){
            suff = suff * nums[i+1];
            suffixArr[i] = suff;
        }

        int prod = 1;
        for(int i=0;i<n;i++){
            prod = prefixArr[i] * suffixArr[i];
            nums[i] = prod;
        }

        return nums;
    }
}
