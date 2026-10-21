public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] ans = new int[2];

        var dict = new Dictionary<int, int>();
        int n = nums.Length;

        for(int i=0;i<n;i++){
            int diff = target - nums[i];
            if(dict.ContainsKey(diff)){
                ans[0] = dict[diff];
                ans[1] = i;
            }else{
                dict.Add(nums[i], i);
            }
        } 

        return ans;

    }
}
