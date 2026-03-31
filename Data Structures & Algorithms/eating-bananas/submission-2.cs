public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        Array.Sort(piles);
        int lo = 1; int hi = piles[piles.Length-1];
        int bestValue = Int32.MaxValue;

        while(lo<=hi){
            int mid = lo+((hi-lo)/2);
            int time = TotalTime(piles,mid);
            if(time<=h){
                if(mid < bestValue) { 
                  bestValue = mid;
                  hi = mid-1;
                }
            } 
            else{
                lo = mid+1;
            }
        }
        return bestValue;
    }

    private int TotalTime(int[] piles, int mid){
        int totalTime = 0;
        foreach(int pile in piles){
            totalTime+= (int)Math.Ceiling((double)pile/mid);
        }

        return totalTime;
    }
}
