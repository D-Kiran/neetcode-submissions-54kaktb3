public class Solution {
    public int FindDuplicate(int[] nums) {
        
        //core intuition is figuring out how a cycled linkedlist is created
        // i->nums[i] -> nums[nums[i]]  etc


        int slow = 0; int fast =0;
        while(true){
            slow = nums[slow];
            fast = nums[nums[fast]];
            if(slow == fast) break;
        }

        int slow2 =0;
        int meetcount =0;
        while(true){
            slow = nums[slow];
            slow2 = nums[slow2];
            meetcount++;
            Console.WriteLine($"meetcount : {meetcount}");
            if(slow == slow2) return slow;
        }
        
    }
}
