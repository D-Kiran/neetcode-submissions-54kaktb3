public class Solution {
    public bool hasDuplicate(int[] nums) {
        var map = new Dictionary<int,int>();

        foreach(var num in nums){
            if(map.ContainsKey(num)) return true;
            else{
                map[num] = 1;
            }
        }
        return false;

    }
}