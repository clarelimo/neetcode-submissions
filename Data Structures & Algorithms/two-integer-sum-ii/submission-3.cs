public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int n = numbers.Length;
        
        int start = 0;
        int end = n-1;

        while(start <= end){
            int sum = numbers[start] + numbers[end];
            if(sum == target){
                return new int[] {start+1, end+1};
            }else if(sum < target){
                start++;
            }else{
                end--;
            }

        }


        // while(start <= end && start < n){
        //     int diff = target - numbers[start];
        //     while(end < n){
        //         if(numbers[end] == diff){
        //             return new int[] {start+1, end+1};
        //         }
        //         end++;
        //     }
        //     start++;
        //     end = start + 1;
        // }

        return [];
    }
}
