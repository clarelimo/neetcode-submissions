public class Solution {
    public int LongestConsecutive(int[] nums) {
        int n = nums.Length;
        var hs = new HashSet<int>();

        foreach(int num in nums){
            hs.Add(num); // hs 2,20,4,10,3,4,5
        }

        int max = 0;
        foreach(int num in hs){
            int prev = num - 1;
            if(!hs.Contains(prev)){
                int count = 1;
                int next = num + count;
                while(hs.Contains(next)){
                    count++;
                    next = num + count;
                }
                max = Math.Max(max, count);
            }
        }

        return max;

    }
}
