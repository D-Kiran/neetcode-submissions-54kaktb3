public class KthLargest {

   private List<int> nums; 
   private int k;
    public KthLargest(int k, int[] nums) {
        this.nums = new List<int>(nums);
        this.k = k;
    }
    
    public int Add(int val) {
        nums.Add(val);
        nums.Sort();
        return nums[nums.Count-k];

    }
}
