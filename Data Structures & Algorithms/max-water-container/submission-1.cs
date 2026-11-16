public class Solution {
    public int MaxArea(int[] heights) {
        int maxArea = 0;
        int minHeight = 0;
        int n = heights.Length;
        int start = 0;
        int end = n-1;

        while(start < end){
            int width = end - start;
            minHeight = Math.Min(heights[start], heights[end]);
            int area = width * minHeight;
            maxArea = Math.Max(area, maxArea);

            if(heights[start] < heights[end]) {
                start++;
            }else{
                end--;
            }
        }

        return maxArea;
        
    }
}
