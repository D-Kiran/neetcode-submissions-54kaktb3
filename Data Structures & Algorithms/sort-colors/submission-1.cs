public class Solution {
    public void SortColors(int[] nums) {
        QuickSort3Way(nums,0,nums.Length-1);
        
    }

    private void QuickSort3Way(int[] nums,int lo, int hi){
        if(hi<=lo) return;
        int lt = lo;
        int gt = hi;
        int i=lo+1;
        int v = nums[lo];

        while(i <= gt){
            if(nums[i] < v) {
                Swap(nums,lt++,i++);
            }
            else if(nums[i]>v){
                Swap(nums,gt--,i);
            }
            else{
                i++;
            }
        }

        QuickSort3Way(nums,lo,lt-1);
        QuickSort3Way(nums,gt+1,hi);

    }



    private static void Swap(int[] nums, int i, int j){
        var temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}