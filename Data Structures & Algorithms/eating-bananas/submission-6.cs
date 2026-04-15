public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
         Array.Sort(piles);

        var higherlimit = 0;
        var highlimitidx = -1;

        for(int i=0; i<piles.Length;i++){
            int totaltime =0;
            int speed = piles[i];
            for(int j=0; j<piles.Length; j++){
                totaltime += CalculateHoursTakeToEatTheithPile(piles[j],speed);
            }

            if(totaltime <= h){
                higherlimit = speed;
                highlimitidx = i;
                break;
            }
        }

        if(highlimitidx <=0){
            int left =1; int right = higherlimit;
            int result = -1;
            while(left <= right){
                int mid = (left + right)/2;
                int totaltime =0;
                foreach(var pile in piles){
                    totaltime += CalculateHoursTakeToEatTheithPile(pile,mid);
                }
                if(totaltime <= h){
                    result = mid; right = mid-1;
                }
                else{
                    left = mid+1;
                }

            }
            return result;
        }

        for(int i= piles[highlimitidx-1]; i<higherlimit && highlimitidx > 0; i++){
            int totaltime = 0;
            var speed = i;
             for(int j=0; j<piles.Length; j++){
                totaltime += CalculateHoursTakeToEatTheithPile(piles[j],speed);
             }

             if(totaltime <= h) return speed;
        }

        return higherlimit;
    }

    private int CalculateHoursTakeToEatTheithPile(int pile, int rate)
    {
        return pile % rate == 0 ? pile/rate : (pile/rate+1);
    }
    
}
