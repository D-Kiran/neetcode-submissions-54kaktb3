public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var result = new int[2];

        int start =0; int end = numbers.Length-1;

        while(start < end){
            var sum = numbers[start] + numbers[end];
            if(sum == target){
                result[0] = start+1;
                result[1] = end+1;
                return result;
            }
            else if(sum < target){start ++;}
            else if(sum > target){end--;}
        }
        return result;
    }
}
