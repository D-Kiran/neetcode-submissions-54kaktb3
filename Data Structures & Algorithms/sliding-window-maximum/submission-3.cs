public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        
        int[] result = new int[nums.Length-k+1];
        var indicesdeq = new LinkedList<int>();

        int left=0; int right=0;
        while(right < nums.Length){
            while(indicesdeq.Count >0 && nums[indicesdeq.Last.Value] < nums[right]){
                indicesdeq.RemoveLast();   //always maintain strictly decreasing order
            }
            indicesdeq.AddLast(right);

            if(indicesdeq.First.Value < left){
                indicesdeq.RemoveFirst(); //remove stale element
            }

            if(right+1 >= k){
                result[left] = nums[indicesdeq.First.Value];
                left++;
            }
            right++;
        }

        return result;
    }
}
