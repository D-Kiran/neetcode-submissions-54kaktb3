public class Solution {
    public void MoveZeroes(int[] nums) {
        int n= nums.Length;
        int left =0; int right=1;

        while(right < n && left <= right)
        {
            while(left < n && nums[left] != 0) left++;

            Console.WriteLine($"left: {left} ");

            if( left > right) right = left;
            while(right <n && nums[right] == 0) right++;

            Console.WriteLine($"right: {right}");

            if(right < n) Swap(nums,left,right);
        }
    }

    private void Swap(int[] nums, int left, int right){
        Console.WriteLine($"Swap left {left} and right {right}");
        var temp = nums[left];
        nums[left] = nums[right];
        nums[right] = temp;
    }
}