// public class Pair {
//     public int Key;
//     public string Value; 
//
//     public Pair(int key, string value) {
//         Key = key;
//         Value = value;
//     }
// }
public class Solution {
    public List<Pair> QuickSort(List<Pair> pairs) {
         QuickSortAlgo(pairs,0,pairs.Count-1);
         return pairs;
    }

    private void QuickSortAlgo(List<Pair> pairs, int lo, int hi){
        if(hi<=lo) return ;
        int j = Partition(pairs,lo,hi);
       QuickSortAlgo(pairs,lo,j-1);
       QuickSortAlgo(pairs,j+1,hi);
       //return pairs;
    }

    private int Partition(List<Pair> pairs, int lo, int hi){
        int v = pairs[hi].Key;
        int left = lo;
        for(int k=lo; k<hi;k++){
            if(pairs[k].Key<v){
                Swap(pairs,k,left++);
            }
        }
        Swap(pairs,hi,left);
        return left;
    }

    private void Swap(List<Pair> pairs, int i, int j)
    {
        var temp = pairs[i];
        pairs[i] = pairs[j];
        pairs[j] = temp; 
    }


}
