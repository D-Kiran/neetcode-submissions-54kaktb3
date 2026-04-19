public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {

        int m = nums1.Length; int n = nums2.Length;
        int[] array = new int[m + n];

        for(int i=0; i<m; i++){
            array[i] = nums1[i];
        }
        for(int j=0;j<n;j++){
            array[m+j] = nums2[j];
        }

        Array.Sort(array);


        int left =0; int right = array.Length-1;
        int mid = left + (right-left)/2;
        Console.WriteLine($"length {array.Length} and mid {mid}");
        if((array.Length)%2 !=0 ){return (double)array[mid];}
        return ((double)array[mid]+array[mid+1])/2;
    }
}
