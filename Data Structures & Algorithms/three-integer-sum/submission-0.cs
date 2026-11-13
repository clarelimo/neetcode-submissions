public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        var res = new List<List<int>>();
        int n= nums.Length;
        Array.Sort(nums);

        for(int i = 0;i<n;i++){
            if(i > 0 && nums[i] == nums[i-1]) continue;
            int s = i+1;
            int e = n-1;
            while(s < e){
                int sum = nums[i] + nums[s] + nums[e];
                if(sum == 0){
                    res.Add(new List<int> {nums[i], nums[s], nums[e]});
                    s++;
                    e--;
                    while(s < e && nums[s] == nums[s-1]){
                        s++;
                    }
                }else if(sum < 0){
                    s++;
                }else{
                    e--;
                }
            }
        }

        return res;
    }
}
