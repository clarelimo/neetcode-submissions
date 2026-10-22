public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        var dict = new Dictionary<int, int>();
        int n = nums.Length;

        foreach(int num in nums){
            if(dict.ContainsKey(num)){
                dict[num]++;
            }else{
                dict.Add(num, 1);
            }
        }

        var heap = new PriorityQueue<int, int>();
        foreach(var num in dict){
            heap.Enqueue(num.Key, num.Value);
            if(heap.Count > k){
                heap.Dequeue();
            }
        }
        int [] res = new int[k];

        for(int i=0; i< k;i++){
            res[i] = heap.Dequeue();
        }

        return res;
    }
}
