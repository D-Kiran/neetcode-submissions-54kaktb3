public class Solution {
    public List<List<int>> ThreeSum(int[] nums) 
    {
        int i=0; int j = 0; int k=0;
        int len = nums.Length;
        var result = new List<List<int>>();
        Array.Sort(nums);

        while(i<len)
        {
            while((i>0)&&(i<len) && nums[i-1] == nums[i]) i++;    

            j = i+1; k=len-1;
            while(j<len && k<len && j<k)
            {   
                int sum = nums[i]+nums[j]+nums[k];
                Console.WriteLine(sum);
                if(sum == 0){
                    var triplet = new List<int>{nums[i], nums[j], nums[k]};
                    result.Add(triplet);
                    
                    j++; k--;

                    while(j<k && nums[j] == nums[j-1]) j++;
                }
                else if(sum > 0){k--;}
                else{j++;}
            }
            i++;
        }

        return result;
    }
}
