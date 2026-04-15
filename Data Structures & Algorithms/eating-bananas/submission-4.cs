public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        
        int left =1;
        int right = piles.Max();

        int result = -1;

        while(left <= right){
            int mid = (left + right)/2;
            int totaltime =0;

            foreach(var pile in piles){
                totaltime += (int)Math.Ceiling((double)pile/mid);
            }

            if(totaltime <=h){
                result = mid;
                right = mid-1;
            }
            else{
                left = mid+1;
            }
        }

        return result;
    }
}
