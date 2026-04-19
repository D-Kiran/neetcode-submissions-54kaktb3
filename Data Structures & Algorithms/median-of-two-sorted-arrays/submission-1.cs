public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {

        int m = nums1.Length; int n = nums2.Length;
        int[] array = new int[m + n];

        int i=0; int j=0;

       for(int k=0; k<m+n; k++){

          if(i >= m){
            array[k] = nums2[j]; j++;
          }
          else if(j>=n){
            array[k] = nums1[i]; i++;
          }
          else if(nums1[i] <= nums2[j])
          {
            array[k] = nums1[i];
            i++;
          }
          else if(nums2[j] < nums1[i])
          {
            array[k] = nums2[j];
            j++;
          }   
       }


        int left =0; int right = array.Length-1;
        int mid = left + (right-left)/2;
        Console.WriteLine($"length {array.Length} and mid {mid}");
        if((array.Length)%2 !=0 ){return (double)array[mid];}
        return ((double)array[mid]+array[mid+1])/2;
    }
}
