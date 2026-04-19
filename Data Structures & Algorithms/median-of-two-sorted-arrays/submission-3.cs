public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int[] A = nums1;
        int[] B = nums2;

        if(nums2.Length < nums1.Length){
            int[] temp = B;
            B = A;
            A = temp;
        }

        int left =0; int right = A.Length;
        int total = A.Length+ B.Length;
        int half = (total+1)/2;

        while(left<=right){
            int midA = left + (right - left)/2;
            int Bidx = half-midA;

            int Aleft = midA>0? A[midA-1] : int.MinValue;
            int Aright = midA <A.Length ? A[midA] : int.MaxValue;
            int Bleft = Bidx>0 ? B[Bidx-1]: int.MinValue;
            int Bright = Bidx < B.Length ? B[Bidx]: int.MaxValue;

            if(Aleft <= Bright && Bleft <= Aright){
                if(total % 2 != 0){
                    return Math.Max(Aleft,Bleft);
                }
                return (Math.Max(Aleft,Bleft)+ Math.Min(Aright,Bright))/2.0;
            }
            else if(Aleft > Bright){
                right = midA-1;
            }
            else left = midA+1;
        }
        return -1;

    }
}
