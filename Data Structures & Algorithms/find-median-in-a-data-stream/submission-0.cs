public class MedianFinder {

    private PriorityQueue<int,int> minheap;
    private List<int> nums;

    public MedianFinder() {
        minheap = new();
        nums = new();
    }
    
    public void AddNum(int num) {
        nums.Add(num);

        foreach(var n in nums){
            Console.WriteLine(n);
        }
    }
    
    public double FindMedian() 
    {
        nums.Sort();
        if(nums.Count % 2 == 1){
            return nums[nums.Count/2];
        }
        int mid = nums.Count/2;
        return ((nums[mid] + nums[mid-1]) / 2.0);
    }
}
