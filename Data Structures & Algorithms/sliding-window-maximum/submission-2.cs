public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        
        int n = nums.Length;
        var result = new int[n+1-k];

        var deque = new LinkedList<int>();
        int left= 0; int right=0;

        while(right < n){
            while(deque.Count >0 && nums[deque.Last.Value] < nums[right]){
                deque.RemoveLast();
            }
            deque.AddLast(right);

            if(left > deque.First.Value){
                deque.RemoveFirst();
            }

            if((right+1) >=k){
                result[left] = nums[deque.First.Value];
                left++;
            }
            right++;
        }

        return result;
     }  
}
